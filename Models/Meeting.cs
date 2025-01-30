namespace ServerApp.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description{ get; set; }
        public DateTime? MeetingDate{ get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string Participants { get; set; } 
        public string MeetingPack { get; set; }
    }
}