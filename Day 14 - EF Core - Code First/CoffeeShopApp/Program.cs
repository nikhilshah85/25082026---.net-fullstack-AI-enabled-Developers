using CoffeeShopApp.Data;
using CoffeeShopApp.Models;

using var db = new CoffeeShopDbContext();

if (!db.Categories.Any())
{
    var coffee = new Category
    {
        Name = "Coffee"
    };

    var tea = new Category
    {
        Name = "Tea"
    };

    var snacks = new Category
    {
        Name = "Snacks"
    };

    var desserts = new Category
    {
        Name = "Desserts"
    };

    db.Categories.AddRange(
        coffee,
        tea,
        snacks,
        desserts);

    db.SaveChanges();

    db.Products.AddRange(

        new Product
        {
            Name = "Espresso",
            Price = 120,
            CategoryId = coffee.CategoryId
        },

        new Product
        {
            Name = "Cappuccino",
            Price = 180,
            CategoryId = coffee.CategoryId
        },

        new Product
        {
            Name = "Cafe Latte",
            Price = 200,
            CategoryId = coffee.CategoryId
        },

        new Product
        {
            Name = "Masala Tea",
            Price = 100,
            CategoryId = tea.CategoryId
        },

        new Product
        {
            Name = "Veg Sandwich",
            Price = 220,
            CategoryId = snacks.CategoryId
        },

        new Product
        {
            Name = "Chocolate Brownie",
            Price = 150,
            CategoryId = desserts.CategoryId
        });

    db.SaveChanges();

    Console.WriteLine("Initial data inserted.");
}