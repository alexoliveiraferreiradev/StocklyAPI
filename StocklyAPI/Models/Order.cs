namespace StocklyAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; } 
        public string CustomerName { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; }
        // Status do pedido (ex: "Pending", "Shipped", "Delivered", "Canceled")
        public string Status { get; set; }
        public List<Product> OrderProducts { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }

        // Data de envio do pedido (caso o pedido já tenha sido enviado)
        public DateTime? ShippingDate { get; set; }

        // Data de entrega do pedido (caso o pedido tenha sido entregue)
        public DateTime? DeliveryDate { get; set; }

        // Identificador do número de rastreamento (caso exista)
        public string TrackingNumber { get; set; }
    }
}
