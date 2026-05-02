public class ShoppingCartTests
    {


        private readonly ShoppingCart _cart = new ShoppingCart();


        /// <summary>
        /// Denklik Sınıflarına Ayırma
        /// </summary>
        [Theory]
        [InlineData("P001", 1, 10.5)] // Geçerli giriş
        [InlineData("P002", 5, 0)] // Geçerli fiyat sıfır
        public void AddItem_ShouldAddItem_WhenInputsAreValid(string productId, int quantity, decimal price)
        {
            // Act
            _cart.AddItem(productId, quantity, price);

            // Assert
            Assert.Single(_cart.GetItems(), item => item.ProductId == productId);
        }

        [Theory]
        [InlineData("P001", 0, 10.5)] // Geçersiz: Miktar sıfır
        [InlineData("P002", 5, -10)] // Geçersiz: Negatif fiyat
        public void AddItem_ShouldThrowException_WhenInputsAreInvalid(string productId, int quantity, decimal price)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => _cart.AddItem(productId, quantity, price));
        }



        /// <summary>
        /// Sınır Değer Analizi
        /// </summary>
        [Theory]
        [InlineData(99.99, false)] // Alt sınırın hemen altı
        [InlineData(100, true)] // Tam sınır
        [InlineData(100.01, true)] // Sınırın hemen üstü
        public void IsEligibleForDiscount_ShouldReturnCorrectResult(decimal total, bool expected)
        {
            // Arrange
            _cart.AddItem("P001", 1, total);

            // Act
            var result = _cart.IsEligibleForDiscount();

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Karar Tablosu Testleri
        /// </summary>

        [Theory]
        [InlineData(0, false)] // Sepet boş
        [InlineData(50, false)] // Toplam alt sınırın altında
        [InlineData(100, true)] // Toplam tam sınırda
        [InlineData(150, true)] // Toplam üst sınırın üzerinde
        public void DiscountEligibility_ShouldBehaveCorrectly(decimal total, bool expected)
        {
            // Arrange
            _cart.AddItem("P001", 1, total); // Sepet boş değilken toplam tutar ekleniyor

            // Act
            var result = _cart.IsEligibleForDiscount();

            // Assert
            Assert.Equal(expected, result);
        }




        /// <summary>
        /// Durum Geçiş Testi
        /// </summary>

        [Fact]
        public void AddAndRemoveItem_ShouldUpdateCartStateCorrectly()
        {
            // Arrange
            _cart.AddItem("P001", 2, 10);
            _cart.AddItem("P002", 1, 20);

            // Act
            _cart.RemoveItem("P001");

            // Assert
            Assert.Single(_cart.GetItems());
            Assert.Equal(20, _cart.CalculateTotal());
        }




    }