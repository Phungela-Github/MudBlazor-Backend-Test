namespace ServerApp.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description{ get; set; }
        public DateTime? MeetingDate{ get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public string Participants { get; set; } 
        public string MeetingPack { get; set; }
    }
}