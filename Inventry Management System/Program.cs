using System;

namespace Inventry_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Inventory management System");

            Inventory inventory = new Inventory();

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Display All Items");
                Console.WriteLine("3. Find Item by ID");
                Console.WriteLine("4. Update Item");
                Console.WriteLine("5. Delete Item");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Item ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Item Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Item Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Item Quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        inventory.addItem(new Item(id, name, price, quantity));
                        Console.WriteLine("Item added successfully.");
                        break;

                    case 2:
                        Console.WriteLine("Displaying all items:");
                        inventory.getItems();
                        break;

                    case 3:
                        Console.Write("Enter Item ID to find: ");
                        int findId = Convert.ToInt32(Console.ReadLine());
                        Item foundItem = inventory.GetItemById(findId);
                        if (foundItem != null)
                        {
                            Console.WriteLine("Item found: " + foundItem);
                        }
                        else
                        {
                            Console.WriteLine("Item not found.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter Item ID to update: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter New Item Name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter New Item Price: ");
                        double newPrice = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter New Item Quantity: ");
                        int newQuantity = Convert.ToInt32(Console.ReadLine());
                        bool isUpdated = inventory.updateItem(updateId, newName, newPrice, newQuantity);
                        if (isUpdated)
                        {
                            Console.WriteLine("Item updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Item not found or could not be updated.");
                        }
                        break;

                    case 5:
                        Console.Write("Enter Item ID to delete: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        bool isDeleted = inventory.deleteItem(deleteId);
                        if (isDeleted)
                        {
                            Console.WriteLine("Item deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Item not found or could not be deleted.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting the program.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
