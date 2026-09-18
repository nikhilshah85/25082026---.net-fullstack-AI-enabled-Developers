namespace CoffeeShopApp.Models;

public class Customer
{
    public int CustomerId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public List<Order> Orders { get; set; } = new();
}