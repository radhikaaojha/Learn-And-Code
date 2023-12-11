using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2.ProblemStatement2
{
    class Product
    {
        private string Name;
        private double Price;
        private int Quantity;

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetPrice()
        {
            return Price;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }

    class InventorySystem
    {
        private List<Product> products;

        public InventorySystem()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetInventoryProducts()
        {
            return products;
        }
    }

    class Program
    {
        public static void Main(string[] p)
        {
            InventorySystem inventory = new InventorySystem();

            while (true)
            {
                Console.WriteLine("\nInv Mgmt System");
                Console.WriteLine("1. Add Prod");
                Console.WriteLine("2. Display Inv");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                int userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.Write("Enter prod name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter prod price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter prod qty: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        Product newProduct = new Product(name, price, quantity);
                        inventory.AddProduct(newProduct);

                        Console.WriteLine("Prod added successfully!");
                        break;

                    case 2:
                        Console.WriteLine("\nCurrent Inv:");
                        List<Product> inventoryProducts = inventory.GetInventoryProducts();
                        foreach (Product product in inventoryProducts)
                        {
                            Console.WriteLine("Name: " + product.GetName() +
                                    ", Price: $" + product.GetPrice() +
                                    ", Quantity: " + product.GetQuantity());
                        }
                        break;

                    case 3:
                        Console.WriteLine("Exiting program. Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }

}
