﻿

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
		public void EditProduct(string name) 
		{
			bool isFound = false;
			foreach (var product in products)
			{
                if (product.Name == name)
				{
					isFound = true;

					Console.Write("Enter the new name: ");
					product.Name = Console.ReadLine();

					Console.Write("Enter the new price: ");
					product.Price = Convert.ToDouble(Console.ReadLine());

					Console.Write("Enter the new quantity: ");
					product.Quantity = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("Product Updated Successfully.");

				}
			}
			if (!isFound)
			{
				Console.WriteLine("Product not found.");
			}
		}

		public void DeleteProduct(string name)
		{
            bool isFound = false;
            foreach (var product in products)
            {
                if (product.Name == name)
                {
                    isFound = true;
					products.Remove(product);

                    Console.WriteLine("Product Deleted Successfully.");
					break;

                }
            }
            if (!isFound)
            {
                Console.WriteLine("Product not found.");
            }
        }

		public void SearchProduct(string name)
		{
            bool isFound = false;
            foreach (var product in products)
            {
                if (product.Name == name)
                {
                    isFound = true;
					Console.WriteLine(product.ToString());
                    break;

                }
            }
            if (!isFound)
            {
                Console.WriteLine("Product not found.");
            }
        }
		
	}
}

