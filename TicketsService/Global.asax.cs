using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using TicketsService.Models;
using System.Data.Entity;

namespace TicketsService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new TicketDbInitializer());
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
