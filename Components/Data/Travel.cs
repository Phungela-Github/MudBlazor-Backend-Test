using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Components.Data
{
    public class Travel
    {
        public int Id { get; set; }
        public string Destination{ get; set; }
        public DateTime? DepartureDate{ get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Type { get; set; }
        public string Airline { get; set; } 
        public string Motivation {get; set;}
        public string SupportingDocuments { get; set; }
    }
}