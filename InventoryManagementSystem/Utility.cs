namespace InventoryManagementSystem;

class Program
{
    static void Main(string[] args)
    {

        Inventory inventory = new Inventory();

        while (true)
        {
            Console.WriteLine("Inventory Management System: ");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Edit Prodcut");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Search Product");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter product name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter product Price: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter product quntity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    Product product = new Product(name, price, quantity);

                    inventory.AddProduct(product);

                    break;

                case "2":
                    inventory.ViewProducts();

                    break;

                case "3":
                    Console.Write("Enter a Product Name to Edit: ");
                    name = Console.ReadLine();
                    inventory.EditProduct(name);

                    break;

                case "4":

                    Console.Write("Enter a Product Name to Delete: ");
                    name = Console.ReadLine();
                    inventory.DeleteProduct(name);

                    break;

                case "5":

                    break;

                case "6":

                    break;

                default:
                    Console.WriteLine("Invalid Choice. Try Again.");
                    break;


            }
        }


        



    }


}

