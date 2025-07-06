using RetailInventorySystem.Data;
using RetailInventorySystem.Models;
using Microsoft.EntityFrameworkCore;

using var db = new RetailDbContext();

// Add data if DB is empty
if (!db.Categories.Any())
{
    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };

    db.Categories.AddRange(electronics, groceries);
    db.Products.AddRange(
        new Product { Name = "TV", Quantity = 10, Price = 45000, Category = electronics },
        new Product { Name = "Mobile", Quantity = 25, Price = 15000, Category = electronics },
        new Product { Name = "Rice", Quantity = 100, Price = 50, Category = groceries }
    );

    db.SaveChanges();
}

// Display inventory
var products = db.Products.Include(p => p.Category).ToList();
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} ({p.Category?.Name}) - {p.Quantity} units @ ₹{p.Price}");
}
