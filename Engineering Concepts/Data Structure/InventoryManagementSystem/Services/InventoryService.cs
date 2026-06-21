using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services
{
    public class InventoryService
    {
        private Dictionary<int, Product> inventory;

        public InventoryService()
        {
            inventory = new Dictionary<int, Product>();
        }

        public void AddProduct(Product product)
        {
            inventory[product.ProductId] = product;
        }

        public void UpdateProduct(int id, int quantity, double price)
        {
            if (inventory.ContainsKey(id))
            {
                inventory[id].Quantity = quantity;
                inventory[id].Price = price;
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void DeleteProduct(int id)
        {
            inventory.Remove(id);
        }

        public void DisplayProducts()
        {
            foreach (var product in inventory.Values)
            {
                Console.WriteLine(
                    $"ID: {product.ProductId}, Name: {product.ProductName}, Quantity: {product.Quantity}, Price: {product.Price}");
            }
        }
    }
}