using System.Linq;
using ServerApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Services
{
    public class TravelService
    {
        private readonly ApplicationDbContext _context;

        public TravelService(ApplicationDbContext context)
        {
            _context = context;
        }
         public async Task<bool> AddTravel(string destination, DateTime? departureDate, DateTime? returnDate, string type, string airline, string motivation)
        {
            var travel = new Travel
            {
                Destination = destination,
                DepartureDate = departureDate,
                ReturnDate = returnDate,
                Type = type,
                Airline = airline,
                Motivation = motivation,
                SupportingDocuments = "test"
            };

            _context.Travels.Add(travel);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<List<Travel>> GetTravelsAsync()
        {
            return await _context.Travels.ToListAsync();
        }

    }

}