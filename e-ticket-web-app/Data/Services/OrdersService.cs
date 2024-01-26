using e_ticket_web_app.Models;
using Microsoft.EntityFrameworkCore;

namespace e_ticket_web_app.Data.Services
{
    public class OrdersService : IOrdersService
    {
        public readonly ApplicationDbContext _context;
        public OrdersService(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task<List<Order>> GetOrdersAsync(string UserId)
        {
            var orders = await _context.Orders.Include(n => n.OrderItems).ThenInclude(m => m.Movie).Where(u => u.UserId == UserId).ToListAsync();

            return orders;
        }

        public async Task StoreOrderAsync(List<ShoppingCartItem> items, string UserId, string userEmailAddress)
        {
            var order = new Order()
            {
                UserId = UserId,
                Email = userEmailAddress,
            };

            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    MovieId = item.Movie.Id,
                    OrderId = order.Id,
                    Price = item.Movie.Price,
                };

                await _context.AddAsync(orderItem);
            }
            await _context.SaveChangesAsync();
        }
    }
}
