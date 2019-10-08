namespace Testability
{
    public class Order
    {
        public bool IsShipped
        {
            get { return Shipment != null; }
        }

        public Shipment Shipment { get; set; }
    }
}