using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TicketsService.Models;

namespace TicketsService.Controllers
{
    public class TicketsController : ApiController
    {
        TicketContext db = new TicketContext();
        public IEnumerable<Ticket> GetTickets()
        {
            return db.Tickets;
        }

        [HttpPost]
        public void CreateTicket([FromBody]Ticket ticket)
        {
            db.Tickets.Add(ticket);
            db.SaveChanges();
        }
    }
}
