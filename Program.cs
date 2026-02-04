//==========================================================
// Student Number : S10273376H, S10273736K
// Student Name   : Zander Fernandez, Jacob Soon
//==========================================================
using System;
using System.Collections.Generic;

namespace GruberooFoodDelivery
{
    internal class Program
    {
        // Global lists to store all data
        static List<Restaurant> restaurants = new List<Restaurant>();
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            // Load sample data
            LoadSampleData();

            // Display welcome message
            Console.WriteLine("Welcome to the Gruberoo Food Delivery System");
            Console.WriteLine(restaurants.Count + " restaurants loaded!");
            Console.WriteLine("(Sample data created for demonstration)");
            Console.WriteLine();

            // Main menu loop
            bool exit = false;
            while (!exit)
            {
                DisplayMainMenu();
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    ListAllRestaurantsAndMenuItems();
                }
                else if (choice == "2")
                {
                    ListAllOrders();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Feature 3 - Create a new order (Not yet implemented)");
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Feature 4 - Process an order (Not yet implemented)");
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Feature 5 - Modify an existing order (Not yet implemented)");
                }
                else if (choice == "6")
                {
                    Console.WriteLine("Feature 6 - Delete an existing order (Not yet implemented)");
                }
                else if (choice == "0")
                {
                    exit = true;
                    Console.WriteLine("Thank you for using Gruberoo Food Delivery System!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                if (!exit)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("Gruberoo Food Delivery System");
            Console.WriteLine("==============================");
            Console.WriteLine("1. List all restaurants and menu items");
            Console.WriteLine("2. List all orders");
            Console.WriteLine("3. Create a new order");
            Console.WriteLine("4. Process an order");
            Console.WriteLine("5. Modify an existing order");
            Console.WriteLine("6. Delete an existing order");
            Console.WriteLine("0. Exit");
            Console.WriteLine();
        }

        // Feature 3: List all restaurants and menu items
        // Feature done by: Jacob Soon
        static void ListAllRestaurantsAndMenuItems()
        {
            Console.WriteLine("All Restaurants and Menu Items");
            Console.WriteLine("==============================");
            Console.WriteLine();

            foreach (Restaurant restaurant in restaurants)
            {
                Console.WriteLine("Restaurant: " + restaurant.Name + " (" + restaurant.RestaurantId + ")");

                if (restaurant.Menu.Count == 0)
                {
                    Console.WriteLine("  - No menu items available");
                }
                else
                {
                    foreach (FoodItem item in restaurant.Menu)
                    {
                        Console.WriteLine("  - " + item.ItemName + ": " + item.ItemDesc + " - $" + item.ItemPrice.ToString("0.00"));
                    }
                }
                Console.WriteLine();
            }
        }

        // Feature 4: List all orders
        // Feature done by: Zander Fernandez
        static void ListAllOrders()
        {
            Console.WriteLine("All Orders");
            Console.WriteLine("==========");
            Console.WriteLine();

            // Print table header with proper spacing
            Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}{4,-10}{5,-15}",
                "Order ID", "Customer", "Restaurant", "Delivery Date/Time", "Amount", "Status");

            Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}{4,-10}{5,-15}",
                new string('-', 8),
                new string('-', 10),
                new string('-', 13),
                new string('-', 18),
                new string('-', 6),
                new string('-', 9));

            // Create a list to hold all orders for display
            List<OrderDisplayInfo> allOrders = new List<OrderDisplayInfo>();

            // Collect all orders from all customers
            foreach (Customer customer in customers)
            {
                foreach (Order order in customer.OrderList)
                {
                    // Find the restaurant for this order
                    Restaurant orderRestaurant = FindRestaurantForOrder(order);

                    string restaurantName;
                    if (orderRestaurant != null)
                    {
                        restaurantName = orderRestaurant.Name;
                    }
                    else
                    {
                        restaurantName = "Unknown";
                    }

                    // Build delivery date/time string
                    string deliveryDateTime = order.DeliveryDate.ToString("dd/MM/yyyy") + " " + order.DeliveryTime;

                    // Create display info object
                    OrderDisplayInfo displayInfo = new OrderDisplayInfo();
                    displayInfo.OrderId = order.OrderId;
                    displayInfo.CustomerName = customer.Name;
                    displayInfo.RestaurantName = restaurantName;
                    displayInfo.DeliveryDateTime = deliveryDateTime;
                    displayInfo.Amount = order.CalculateTotal();
                    displayInfo.Status = order.Status;

                    allOrders.Add(displayInfo);
                }
            }

            // Check if there are any orders
            if (allOrders.Count == 0)
            {
                Console.WriteLine("No orders found.");
            }
            else
            {
                // Display all orders
                foreach (OrderDisplayInfo info in allOrders)
                {
                    Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-20}${4,-9:0.00}{5,-15}",
                        info.OrderId,
                        info.CustomerName,
                        info.RestaurantName,
                        info.DeliveryDateTime,
                        info.Amount,
                        info.Status);
                }
            }
        }

        // Helper class to hold order display information
        class OrderDisplayInfo
        {
            public int OrderId { get; set; }
            public string CustomerName { get; set; }
            public string RestaurantName { get; set; }
            public string DeliveryDateTime { get; set; }
            public double Amount { get; set; }
            public string Status { get; set; }
        }

        // Helper method to find which restaurant an order belongs to
        static Restaurant FindRestaurantForOrder(Order order)
        {
            foreach (Restaurant restaurant in restaurants)
            {
                foreach (Order restaurantOrder in restaurant.OrderQueue)
                {
                    if (restaurantOrder.OrderId == order.OrderId)
                    {
                        return restaurant;
                    }
                }
            }
            return null;
        }

        // Load sample data for demonstration
        // Hardcoded just for stage 1 to demonstrate how it works, will link csv files later
        static void LoadSampleData()
        {
            // Create restaurants
            Restaurant r1 = new Restaurant("R001", "Grill House", "grillhouse@email.com");
            Restaurant r2 = new Restaurant("R002", "Noodle Palace", "noodlepalace@email.com");
            Restaurant r3 = new Restaurant("R003", "Bento Express", "bentoexpress@email.com");

            // Create food items for R001 (Grill House)
            FoodItem f1 = new FoodItem("Chicken Rice", "Steamed chicken with fragrant rice", 5.50, "");
            FoodItem f2 = new FoodItem("Beef Burger", "Grilled beef patty with fries", 9.80, "");
            FoodItem f3 = new FoodItem("Caesar Salad", "Romaine lettuce with house dressing", 7.00, "");

            r1.AddFoodItem(f1);
            r1.AddFoodItem(f2);
            r1.AddFoodItem(f3);

            // Create food items for R002 (Noodle Palace)
            FoodItem f4 = new FoodItem("Spicy Ramen", "House-special broth with chilli oil", 11.20, "");
            r2.AddFoodItem(f4);

            // Create food items for R003 (Bento Express)
            FoodItem f5 = new FoodItem("Salmon Bento", "Grilled salmon with rice and vegetables", 12.50, "");
            FoodItem f6 = new FoodItem("Teriyaki Chicken", "Chicken teriyaki with steamed rice", 8.90, "");
            r3.AddFoodItem(f5);
            r3.AddFoodItem(f6);

            // Add restaurants to list
            restaurants.Add(r1);
            restaurants.Add(r2);
            restaurants.Add(r3);

            // Create customers
            Customer c1 = new Customer("Alice Tan", "alice.tan@email.com");
            Customer c2 = new Customer("Joseph Lim", "joseph.lim@email.com");
            Customer c3 = new Customer("Wendy Ong", "wendy.ong@email.com");

            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            // Create sample orders
            // Order 1001 - Alice Tan orders from Bento Express
            Order order1 = new Order(1001, DateTime.Now.AddDays(-2), new DateTime(2026, 2, 12), "12:00", "123 Main Street", "Delivered");
            OrderedFoodItem ofi1 = new OrderedFoodItem(2, f5); // 2x Salmon Bento
            order1.AddOrderItem(ofi1);
            c1.AddOrder(order1);
            r3.AddOrder(order1);

            // Order 1002 - Joseph Lim orders from Grill House
            Order order2 = new Order(1002, DateTime.Now.AddDays(-1), new DateTime(2026, 2, 13), "18:30", "456 Oak Avenue", "Cancelled");
            OrderedFoodItem ofi2 = new OrderedFoodItem(1, f1); // 1x Chicken Rice
            OrderedFoodItem ofi3 = new OrderedFoodItem(2, f2); // 2x Beef Burger
            order2.AddOrderItem(ofi2);
            order2.AddOrderItem(ofi3);
            c2.AddOrder(order2);
            r1.AddOrder(order2);

            // Order 1003 - Wendy Ong orders from Noodle Palace
            Order order3 = new Order(1003, DateTime.Now, new DateTime(2026, 2, 14), "19:00", "789 Elm Street", "Preparing");
            OrderedFoodItem ofi4 = new OrderedFoodItem(1, f4); // 1x Spicy Ramen
            order3.AddOrderItem(ofi4);
            c3.AddOrder(order3);
            r2.AddOrder(order3);
        }
    }
}

    }
}
