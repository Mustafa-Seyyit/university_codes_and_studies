public class CartItem
    {
        public string ProductId { get; }
        public int Quantity { get; set; }
        public decimal Price { get; }

        public CartItem(string productId, int quantity, decimal price)
        {
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }
    }