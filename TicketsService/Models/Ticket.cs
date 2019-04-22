using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TicketsService.Models
{
    public enum Statuses
    {
        oneOfNew,
        inProgress,
        Blocked,
        Done
    }
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Statuses Status { get; set; }
        public string Category { get; set; }
    }
}