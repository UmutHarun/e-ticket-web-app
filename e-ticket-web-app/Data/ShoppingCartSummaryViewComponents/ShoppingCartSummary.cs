using e_ticket_web_app.Data.Cart;
using Microsoft.AspNetCore.Mvc;

namespace e_ticket_web_app.Data.ShoppingCartSummaryViewComponents
{
    public class ShoppingCartSummary : ViewComponent
    {
        public readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();

            return View(items.Count);
        }
    }
}
