using e_ticket_web_app.Models;

namespace e_ticket_web_app.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items , string UserId , string userEmailAddress);

        Task<List<Order>> GetOrdersAsync(string UserId);
    }
}
