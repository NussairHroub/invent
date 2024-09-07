

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

		public void ViewProducts()
		{
			if(products.Count() == 0)
			{
				Console.WriteLine("No products.");
				return;
			}

			foreach (var product in products)
			{
				Console.WriteLine(product.ToString());
			}
		}
		
	}
}

