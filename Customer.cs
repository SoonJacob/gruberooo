//==========================================================
// Student Number : S10273376H, S10273736K
// Student Name   : Zander Fernandez, Jacob Soon
// Class done by  : Zander Fernandez
//==========================================================

using System;
using System.Collections.Generic;

namespace GruberooFoodDelivery
{
    class Customer
    {
        private string name;
        private string email;
        private List<Order> orderList;

        // Properties
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

        public List<Order> OrderList
        {
            get { return orderList; }
            set { orderList = value; }
        }

        // Constructor
        public Customer()
        {
            orderList = new List<Order>();
        }

        public Customer(string name, string email)
        {
            this.name = name;
            this.email = email;
            orderList = new List<Order>();
        }

        // Methods
        public void AddOrder(Order order)
        {
            orderList.Add(order);
        }

        public Order GetOrderById(int orderId)
        {
            foreach (Order order in orderList)
            {
                if (order.OrderId == orderId)
                {
                    return order;
                }
            }
            return null;
        }

        public List<Order> GetPendingOrders()
        {
            List<Order> pendingOrders = new List<Order>();
            foreach (Order order in orderList)
            {
                if (order.Status == "Pending")
                {
                    pendingOrders.Add(order);
                }
            }
            return pendingOrders;
        }

        // ToString method
        public override string ToString()
        {
            return $"Customer: {name} ({email})";
        }
    }
}
