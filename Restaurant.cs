

//==========================================================
// Student Number : S10273376H, S10273736K
// Student Name   : Zander Fernandez, Jacob Soon
// Jacob soon did this
//==========================================================

using System;
using System.Collections.Generic;

namespace GruberooFoodDelivery
{
    class Restaurant
    {
        
        private string restaurantId;
        private string restaurantName;
        private string restaurantEmail;

       
        private List<Menu> menus;
        private List<SpecialOffer> specialOffers;
        private Queue<Order> orderQueue;

       
        public string RestaurantId
        {
            get { return restaurantId; }
            set { restaurantId = value; }
        }

        public string RestaurantName
        {
            get { return restaurantName; }
            set { restaurantName = value; }
        }

        public string RestaurantEmail
        {
            get { return restaurantEmail; }
            set { restaurantEmail = value; }
        }

        public List<Menu> Menus
        {
            get { return menus; }
            set { menus = value; }
        }

        public List<SpecialOffer> SpecialOffers
        {
            get { return specialOffers; }
            set { specialOffers = value; }
        }

        public Queue<Order> OrderQueue
        {
            get { return orderQueue; }
            set { orderQueue = value; }
        }

       
        public Restaurant()
        {
            menus = new List<Menu>();
            specialOffers = new List<SpecialOffer>();
            orderQueue = new Queue<Order>();
        }

        public Restaurant(string restaurantId, string restaurantName, string restaurantEmail)
        {
            this.restaurantId = restaurantId;
            this.restaurantName = restaurantName;
            this.restaurantEmail = restaurantEmail;
            menus = new List<Menu>();
            specialOffers = new List<SpecialOffer>();
            orderQueue = new Queue<Order>();
        }

        

        
        public void DisplayOrders()
        {
            Console.WriteLine($"Orders for {restaurantName}:");
            if (orderQueue.Count == 0)
            {
                Console.WriteLine("No orders in the queue.");
                return;
            }

            foreach (Order order in orderQueue)
            {
                Console.WriteLine(order);
            }
        }

        
        public void DisplaySpecialOffers()
        {
            Console.WriteLine($"Special offers for {restaurantName}:");
            if (specialOffers.Count == 0)
            {
                Console.WriteLine("No special offers available.");
                return;
            }

            foreach (SpecialOffer offer in specialOffers)
            {
                Console.WriteLine(offer);
            }
        }

       
        public void DisplayMenu()
        {
            Console.WriteLine($"Menus for {restaurantName}:");
            if (menus.Count == 0)
            {
                Console.WriteLine("No menus found.");
                return;
            }

            foreach (Menu menu in menus)
            {
                Console.WriteLine(menu);      
                menu.DisplayFoodItems();      
                Console.WriteLine();
            }
        }

        
        public void AddMenu(Menu menu)
        {
            if (menu == null) return;
            menus.Add(menu);
        }

       
        public bool RemoveMenu(Menu menu)
        {
            if (menu == null) return false;
            return menus.Remove(menu);
        }

        // EXTRA HELPERS just in case

        public void AddSpecialOffer(SpecialOffer offer)
        {
            if (offer == null) return;
            specialOffers.Add(offer);
        }

        public void AddOrder(Order order)
        {
            if (order == null) return;
            orderQueue.Enqueue(order);
        }

        
        public override string ToString()
        {
            return $"Restaurant: {restaurantName} ({restaurantId}) - {restaurantEmail}";
        }
    }
}
