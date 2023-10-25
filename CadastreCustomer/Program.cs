// See https://aka.ms/new-console-template for more information
using CadastreCustomer;

namespace CadastreCustomer
{
    class Program 
    {
        static List<Customer> customers = new List<Customer>();

        static void main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Select a option:");
                Console.WriteLine("1 - Add Customer");
                Console.WriteLine("2 - Visualize Customer");
                Console.WriteLine("3 - Edit Customer");
                Console.WriteLine("4 - Delete Customer");
                Console.WriteLine("5 - Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option) 
                { 
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        VisualizeCustomer();
                        break;

                    case 3:
                        EditCustomer();
                        break;
                    case 4:
                        DeleteCustomer();
                        break;
                    default: 
                        Console.WriteLine("Invalid option!");
                        break;
                }

            }
        }

        static void AddCustomer()
        { 
        }

        static void VisualizeCustomer() { }

        static void EditCustomer() { }

        static void DeleteCustomer() { }
    }
    

}

