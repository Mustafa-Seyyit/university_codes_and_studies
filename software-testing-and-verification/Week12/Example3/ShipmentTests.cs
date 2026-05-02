public class ShipmentTests
    {
        [Fact]
        public void ValidStateTransitions_ShouldWorkCorrectly()
        {
            // Arrange
            var shipment = new Shipment();

            // Act
            shipment.PickUp(); // Created → PickedUp
            Assert.Equal("PickedUp", shipment.State);

            shipment.Transit(); // PickedUp → InTransit
            Assert.Equal("InTransit", shipment.State);

            shipment.Deliver(); // InTransit → Delivered
            Assert.Equal("Delivered", shipment.State);
        }


        [Fact]
        public void InvalidStateTransitions_ShouldThrowExceptions()
        {
            // Arrange
            var shipment = new Shipment();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => shipment.Transit()); // Created → InTransit (Geçersiz)

            shipment.PickUp(); // Created → PickedUp
            Assert.Throws<InvalidOperationException>(() => shipment.Deliver()); // PickedUp → Delivered (Geçersiz)
        }

    }