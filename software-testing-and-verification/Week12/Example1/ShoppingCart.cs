public class ShoppingCart
    {

        private readonly List<CartItem> items = new List<CartItem>();

        public void AddItem(string productId, int quantity, decimal price)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");
            if (price < 0)
                throw new ArgumentException("Price cannot be negative.");

            var existingItem = items.FirstOrDefault(item => item.ProductId == productId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                items.Add(new CartItem(productId, quantity, price));
            }
        }

        public void RemoveItem(string productId)
        {
            var item = items.FirstOrDefault(i => i.ProductId == productId);
            if (item != null)
                items.Remove(item);
        }

        public decimal CalculateTotal()
        {
            return items.Sum(item => item.Quantity * item.Price);
        }

        public int GetItemCount()
        {
            return items.Sum(item => item.Quantity);
        }

        public bool IsEligibleForDiscount()
        {
            return CalculateTotal() >= 100; // İndirim için sepet toplamı en az 100 olmalı
        }

        public IEnumerable<CartItem> GetItems()
        {
            return items;
        }
    }
    