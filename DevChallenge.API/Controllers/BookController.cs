using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevChallenge.Data.Entities;
using DevChallenge.Service.Services.Interfaces;
using DevChallenge.Data.Dto;
using AutoMapper;

namespace DevChallenge.API.Controllers
{
    [ApiController]
    [Route("obras")]
    public class BookController : ControllerBase
    {
        readonly IBookService _bookService;
        readonly IMapper _mapper;

        public BookController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<Book>> Get() => await _bookService.GetAllBooks();
        

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] BookDto bookDto)
        {
            try
            {
                var book = _mapper.Map<Book>(bookDto);
                await _bookService.InsertBook(book);
            }
            catch(Exception exception)
            {
                return BadRequest($"Ops! We couldn't save the book :(\n {exception.Message}");
            }
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult Put(BookDto bookDto)
        {
            try
            {
                var book = _mapper.Map<Book>(bookDto);

                _bookService.UpdateBook(book);
            }
            catch(Exception exception)
            {
                return BadRequest("Ops! We couldn't update the book :(\n" + exception.Message);
            }
            return Ok();
        }

        [HttpDelete]
        [Route("id")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _bookService.RemoveBook(id);
            }
            catch(Exception exception)
            {
                return BadRequest("Ops! We couldn't remove the Book :(\n" + exception.Message);
            }
            return Ok();
        }
    }
}