namespace CoffeeShopApp.Models;

public class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public bool IsAvailable { get; set; } = true;

    public int CategoryId { get; set; }

    public Category? Category { get; set; }

    public List<OrderItem> OrderItems { get; set; } = new();
}