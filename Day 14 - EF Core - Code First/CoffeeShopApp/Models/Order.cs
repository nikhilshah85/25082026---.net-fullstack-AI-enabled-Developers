namespace CoffeeShopApp.Models;

public class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; } = DateTime.Now;

    public decimal TotalAmount { get; set; }

    public string Status { get; set; } = "Pending";

    public int CustomerId { get; set; }

    public Customer? Customer { get; set; }

    public List<OrderItem> OrderItems { get; set; } = new();

    public Payment? Payment { get; set; }
}