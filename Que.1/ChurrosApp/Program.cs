using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {   
        Test.TestPayBill();
        
        Queue<Order> orderQueue = new Queue<Order>();
        Churros churros = new Churros();

        int orderCounter = 1;

        while (true)
        {
            Console.WriteLine("\n=============================");
            Console.WriteLine("     Delicious Churros");
            Console.WriteLine("==============================");
            Console.WriteLine("\n1. Place Order");
            Console.WriteLine("2. Deliver Order");
            Console.WriteLine("0. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                churros.ShowMenu();

                Console.Write("Choose item: ");
                int itemChoice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter quantity: ");
                int qty = Convert.ToInt32(Console.ReadLine());

                string itemName = churros.GetItemName(itemChoice);
                double price = churros.GetPrice(itemChoice);

                Order order = new Order(orderCounter++, itemName, qty);
                double total = order.PayBill(price);

                Console.WriteLine($"Total Bill: €{total}");

                orderQueue.Enqueue(order);

                Console.WriteLine("Order placed successfully!");
            }
            else if (choice == 2)
            {
                if (orderQueue.Count > 0)
                {
                    Order served = orderQueue.Dequeue();
                    Console.WriteLine("\nDelivering Order:");
                    served.DisplayOrder();
                }
                else
                {
                    Console.WriteLine("No orders in queue.");
                }
            }
            else if (choice == 0)
            {
                break;
            }
        }
    }
}