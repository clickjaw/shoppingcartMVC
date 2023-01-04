namespace ShoppingCartMVC.Models.ViewModels
{
	public class CheckoutViewModel
	{
        public List<CartItem> CartItems { get; set; }
        public decimal GrandTotal { get; set; }
    }
}

