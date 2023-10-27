// See https://aka.ms/new-console-template for more information
using CadastreCustomer;
using System.Reflection.Metadata;
using System;
using System.Collections.Generic;

namespace CadastreCustomer
{
    class Program 
    {
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
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
                    case 5: 
                        running = false;
                        break;
                    default: 
                        Console.WriteLine("Invalid option!");
                        break;
                }

            }
        }

        static void AddCustomer()
        {
            Console.WriteLine("Enter the customer's name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the customer's email: ");
            string email = Console.ReadLine();

            Customer customer = new Customer(name,email);
            customers.Add(customer);

            Console.WriteLine("Client added successfully");
        }

        static void VisualizeCustomer() 
        {
            foreach (Customer customer  in customers)
            {
                Console.WriteLine($"Name: {customer.Name}");
                Console.WriteLine($"E-mail: {customer.Email}");
                Console.WriteLine("---------------------");
            }
        }

        static void EditCustomer() 
        {
            Console.WriteLine("Enter the name of the customer you want to edit: ");
            string name = Console.ReadLine();
            
            Customer customer = customers.Find(c => c.Name == name);
            if (customer is null)
            {
                Console.WriteLine("Customer not found.");
            }
            else
            {
                Console.WriteLine("Enter the new customer name: ");
                string newName = Console.ReadLine();

                Console.WriteLine("Enter the customer's new email: ");
                string newEmail = Console.ReadLine();

                customer.Name = newName;
                customer.Email = newEmail;
                Console.WriteLine("Customer edited successfully.");
            }
        }

        static void DeleteCustomer() 
        {
            Console.WriteLine("Enter name of customer that you want to delete: ");
            string name = Console.ReadLine();

            Customer customer = customers.Find(c=>c.Name == name);
            if (customer is not null)
            {
                customers.Remove(customer);
                Console.WriteLine("Customer Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
    }
    

}

