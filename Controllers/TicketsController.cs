using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TicketsApi.Models;
using TicketsApi.Service;

namespace TicketsApi.Controller 
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly TicketsService _ticketsService;
        public TicketController(TicketsService ticketsService)
        {
            _ticketsService = ticketsService;
        }

        [HttpGet]
        public ActionResult<List<Ticket>> Get() =>
            _ticketsService.Get();

        [HttpGet("{id:length(24)}", Name = "GetBook")]
        public ActionResult<Ticket> Get(string id)
        {
            var ticket = _ticketsService.Get(id);

            if (ticket == null)
            {
                return NotFound();
            }

            return ticket;
        }

        [HttpPost]
        public ActionResult<Ticket> Create(Ticket book)
        {
            _ticketsService.Create(book);

            return CreatedAtRoute("GetBook", new { id = book.Id.ToString() }, book);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Ticket ticketIn)
        {
            var ticket = _ticketsService.Get(id);

            if (ticket == null)
            {
                return NotFound();
            }

            _ticketsService.Update(id, ticketIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var ticket = _ticketsService.Get(id);

            if (ticket == null)
            {
                return NotFound();
            }

            _ticketsService.Remove(ticket.Id);

            return NoContent();
        }
    }
}