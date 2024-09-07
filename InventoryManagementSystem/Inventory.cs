

using System;
namespace InventoryManagementSystem
{
	public class Inventory
	{
		private List<Product> products = new List<Product>();
		public Inventory()
		{
		
		}

		public void AddProduct(Product product)
		{
			products.Add(product);
			Console.WriteLine("Product added successfully.");
		}
	}
}

