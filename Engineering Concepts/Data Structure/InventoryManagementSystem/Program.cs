using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryService inventory = new InventoryService();

            inventory.AddProduct(new Product(101, "Laptop", 20, 75000));
            inventory.AddProduct(new Product(102, "Mouse", 50, 500));

            Console.WriteLine("Inventory:");

            inventory.DisplayProducts();

            inventory.UpdateProduct(101, 15, 72000);

            Console.WriteLine("\nAfter Update:");

            inventory.DisplayProducts();

            inventory.DeleteProduct(102);

            Console.WriteLine("\nAfter Deletion:");

            inventory.DisplayProducts();
        }
    }
}