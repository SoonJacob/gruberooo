//==========================================================
// Student Number : S1234567
// Student Name : [Your Name]
// Partner Name : [Partner Name]
//==========================================================

using System;
using System.Collections.Generic;

namespace GruberooFoodDelivery
{
    class Restaurant
    {
        private string restaurantId;
        private string name;
        private string email;
        private List<FoodItem> menu;
        private List<SpecialOffer> specialOffers;
        private Queue<Order> orderQueue;

        // Properties
        public string RestaurantId
        {
            get { return restaurantId; }
            set { restaurantId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public List<FoodItem> Menu
        {
            get { return menu; }
            set { menu = value; }
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

        // Constructor
        public Restaurant() 
        {
            menu = new List<FoodItem>();
            specialOffers = new List<SpecialOffer>();
            orderQueue = new Queue<Order>();
        }

        public Restaurant(string restaurantId, string name, string email)
        {
            this.restaurantId = restaurantId;
            this.name = name;
            this.email = email;
            menu = new List<FoodItem>();
            specialOffers = new List<SpecialOffer>();
            orderQueue = new Queue<Order>();
        }

        // Methods
        public void AddFoodItem(FoodItem foodItem)
        {
            menu.Add(foodItem);
        }

        public void AddSpecialOffer(SpecialOffer offer)
        {
            specialOffers.Add(offer);
        }

        public void AddOrder(Order order)
        {
            orderQueue.Enqueue(order);
        }

        public FoodItem GetFoodItemByName(string itemName)
        {
            foreach (FoodItem item in menu)
            {
                if (item.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }
            return null;
        }

        // ToString method
        public override string ToString()
        {
            return $"Restaurant: {name} ({restaurantId})";
        }
    }
}
