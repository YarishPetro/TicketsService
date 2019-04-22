using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TicketsService.Models
{
    public class TicketDbInitializer : DropCreateDatabaseAlways<TicketContext>
    {
        protected override void Seed(TicketContext db)
        {
            db.Tickets.Add( new Ticket { Id = 1, Title = "Title1", Status = Statuses.oneOfNew, Category = "SomeCategory1" } );
            db.Tickets.Add( new Ticket { Id = 2, Title = "Title2", Status = Statuses.inProgress, Category = "SomeCategory2" } );
            db.Tickets.Add( new Ticket { Id = 3, Title = "Title3", Status = Statuses.Done, Category = "SomeCategory3" } );

            base.Seed(db);
        }
    }
}