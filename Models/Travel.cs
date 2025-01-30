namespace ServerApp.Models
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