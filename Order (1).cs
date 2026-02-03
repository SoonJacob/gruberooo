//==========================================================
// Student Number : S1234567
// Student Name : [Your Name]
// Partner Name : [Partner Name]
//==========================================================

using System;
using System.Collections.Generic;

namespace GruberooFoodDelivery
{
    class Order
    {
        private int orderId;
        private DateTime createdDateTime;
        private DateTime deliveryDate;
        private string deliveryTime;
        private string deliveryAddress;
        private string specialRequest;
        private string status;
        private List<OrderItem> orderItems;
        private Payment payment;

        // Properties
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public DateTime CreatedDateTime
        {
            get { return createdDateTime; }
            set { createdDateTime = value; }
        }

        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }

        public string DeliveryTime
        {
            get { return deliveryTime; }
            set { deliveryTime = value; }
        }

        public string DeliveryAddress
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }

        public string SpecialRequest
        {
            get { return specialRequest; }
            set { specialRequest = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public List<OrderItem> OrderItems
        {
            get { return orderItems; }
            set { orderItems = value; }
        }

        public Payment Payment
        {
            get { return payment; }
            set { payment = value; }
        }

        // Constructor
        public Order()
        {
            orderItems = new List<OrderItem>();
        }

        public Order(int orderId, DateTime createdDateTime, DateTime deliveryDate, string deliveryTime, 
                     string deliveryAddress, string status)
        {
            this.orderId = orderId;
            this.createdDateTime = createdDateTime;
            this.deliveryDate = deliveryDate;
            this.deliveryTime = deliveryTime;
            this.deliveryAddress = deliveryAddress;
            this.status = status;
            orderItems = new List<OrderItem>();
        }

        // Methods
        public void AddOrderItem(OrderItem item)
        {
            orderItems.Add(item);
        }

        public double CalculateTotal()
        {
            double subtotal = 0;
            foreach (OrderItem item in orderItems)
            {
                subtotal += item.CalculateSubtotal();
            }
            return subtotal + 5.00; // Add delivery fee
        }

        public void UpdateStatus(string newStatus)
        {
            status = newStatus;
        }

        // ToString method
        public override string ToString()
        {
            return $"Order ID: {orderId}, Status: {status}, Total: ${CalculateTotal():F2}";
        }
    }
}
