using System.Linq;
using ServerApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServerApp.Models;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace ServerApp.Services
{
    public class MeetingService
    {
        private readonly ApplicationDbContext _context;

        public MeetingService(ApplicationDbContext context)
        {
            _context = context;
        }
         public async Task<bool> NewMeeting(string meetingTitle, string description, DateTime? meetingDate, TimeSpan start, TimeSpan end,string participants)
        {
            var meeting = new Meeting
            {
                
                Description = description,
                End = end,
                MeetingDate  = meetingDate,
                MeetingPack = "test",
                Participants = "test",
                Start = start,
                Title = meetingTitle
            };

            _context.Meetings.Add(meeting);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Meeting>> GetMeetingsAsync()
        {
            return await _context.Meetings.ToListAsync();
        }

    }

}