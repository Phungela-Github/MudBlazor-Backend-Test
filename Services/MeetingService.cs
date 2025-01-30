using System.Linq;
using ServerApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Services
{
    public class MeetingService
    {
        private readonly ApplicationDbContext _context;

        public MeetingService(ApplicationDbContext context)
        {
            _context = context;
        }
         public async Task<bool> NewMeeting(string meetingTitle, string description, DateTime? meetingDate, DateTime? start, DateTime? end,string participants)
        {
            var meeting = new Meeting
            {
                Title = meetingTitle,
                Description = description,
                MeetingDate  = meetingDate,
                Start = start,
                End = end,
                Participants = participants,
                MeetingPack = "test"
            };

            _context.Meetings.Add(meeting);
            await _context.SaveChangesAsync();
            return true;
        }

    }

}