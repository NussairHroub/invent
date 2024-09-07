using System;
namespace InventoryManagementSystem
{
	public class Product
	{
        private String name;
        private double price;
        private int quantity;

        public Product()
		{
		}
		public Product(String name, double price, int quantity)
		{
			this.name = name;
			this.price = price;
			this.quantity = quantity;
		}

		public string Name { set; get; }
		public double Price { set; get; }
		public int Quantity { set; get; }

        public override string ToString()
        {
			return "Product: " + name + ", Price: " + price + ", Quantity: " + quantity;

        }

    }
}

