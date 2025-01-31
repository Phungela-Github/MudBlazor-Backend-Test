using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Components.Data
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime  { get; set; }
        public string Participants { get; set; }
        public string Files { get; set; }
    }
}