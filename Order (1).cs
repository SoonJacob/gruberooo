//==========================================================
// Student Number : S10273376H, S10273736K
// Student Name   : Zander Fernandez, Jacob Soon
// Class done by  : Zander Fernandez
//==========================================================
using System;
using System.Collections.Generic;

namespace GruberooFoodDelivery
{
    public class Order
    {
        private int orderId;
        private DateTime orderDateTime;
        private double orderTotal;
        private string orderStatus;
        private DateTime deliveryDateTime;
        private string deliveryAddress;
        private string orderPaymentMethod;
        private bool orderPaid;
        private List<OrderedFoodItem> orderedFoodItems;

        // Properties
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public DateTime OrderDateTime
        {
            get { return orderDateTime; }
            set { orderDateTime = value; }
        }

        public double OrderTotal
        {
            get { return orderTotal; }
            set { orderTotal = value; }
        }

        public string OrderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }

        public DateTime DeliveryDateTime
        {
            get { return deliveryDateTime; }
            set { deliveryDateTime = value; }
        }

        public string DeliveryAddress
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }

        public string OrderPaymentMethod
        {
            get { return orderPaymentMethod; }
            set { orderPaymentMethod = value; }
        }

        public bool OrderPaid
        {
            get { return orderPaid; }
            set { orderPaid = value; }
        }

        public List<OrderedFoodItem> OrderedFoodItems
        {
            get { return orderedFoodItems; }
            set { orderedFoodItems = value; }
        }

        // Constructors
        public Order()
        {
            orderedFoodItems = new List<OrderedFoodItem>();
        }

        public Order(int orderId, DateTime orderDateTime, string deliveryAddress, 
                     DateTime deliveryDateTime, string orderStatus, string orderPaymentMethod, bool orderPaid)
        {
            this.orderId = orderId;
            this.orderDateTime = orderDateTime;
            this.deliveryAddress = deliveryAddress;
            this.deliveryDateTime = deliveryDateTime;
            this.orderStatus = orderStatus;
            this.orderPaymentMethod = orderPaymentMethod;
            this.orderPaid = orderPaid;
            orderedFoodItems = new List<OrderedFoodItem>();
        }

        // Methods
        public void AddOrderedFoodItem(OrderedFoodItem item)
        {
            if (item != null)
            {
                orderedFoodItems.Add(item);
            }
        }

        public bool RemoveOrderedFoodItem(OrderedFoodItem item)
        {
            return orderedFoodItems.Remove(item);
        }

        public void DisplayOrderedFoodItems()
        {
            foreach (OrderedFoodItem item in orderedFoodItems)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public double CalculateOrderTotal()
        {
            double total = 0;
            foreach (OrderedFoodItem item in orderedFoodItems)
            {
                total += item.CalculateSubtotal();
            }
            orderTotal = total + 5.00;  // Add delivery fee
            return orderTotal;
        }

        public override string ToString()
        {
            return "Order ID: " + orderId + ", Status: " + orderStatus + ", Total: $" + CalculateOrderTotal().ToString("F2");
        }
    }
}
