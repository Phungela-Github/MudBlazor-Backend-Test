using System.Linq;
using ServerApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Services
{
    public class PaymentService
    {
        private readonly ApplicationDbContext _context;

        public PaymentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddPaymentAsync(Payment payment)
        {
            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> NewPayment(string purchaseOrder, decimal amount, DateTime? payDate, string type, string description)
        {
            var payment = new Payment
            {
                purchaseOrder = purchaseOrder,
                paymentAmount = amount,
                paymentDate  = payDate,
                Type = type,
                Description = description,
                Files = "test"
            };

            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Payment>> GetPaymentsAsync()
        {
            return await _context.Payments.ToListAsync();
        }
    }
}