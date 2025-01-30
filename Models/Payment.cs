namespace ServerApp.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string purchaseOrder { get; set; }
        public decimal paymentAmount { get; set; }
        public DateTime? paymentDate { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Files { get; set; }
    }
}