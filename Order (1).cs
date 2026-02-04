//==========================================================
// Student Number : S10273376H, S10273736K
// Student Name   : Zander Fernandez, Jacob Soon
// Class done by  : Zander Fernandez
//==========================================================

using System;
using System.Collections.Generic;

namespace GruberooFoodDelivery
{
    class Order
    public class Order
    {
        private int orderId;
        private DateTime createdDateTime;
        private DateTime deliveryDate;
        private string deliveryTime;
        private DateTime orderDateTime;
        private double orderTotal;
        private string deliveryAddress;
        private string specialRequest;
        private string status;
        private List<OrderItem> orderItems;
        private Payment payment;
        private DateTime deliveryDateTime;
        private string orderStatus;
        private string orderPaymentMethod;
        private bool orderPaid;
        private List<OrderedFoodItem> orderedFoodItems;

        // Properties
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public DateTime CreatedDateTime
        public DateTime OrderDateTime
        {
            get { return createdDateTime; }
            set { createdDateTime = value; }
            get { return orderDateTime; }
            set { orderDateTime = value; }
        }

        public DateTime DeliveryDate
        public double OrderTotal
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
            get { return orderTotal; }
            set { orderTotal = value; }
        }

        public string DeliveryTime
        public string OrderStatus
        {
            get { return deliveryTime; }
            set { deliveryTime = value; }
            get { return orderStatus; }
            set { orderStatus = value; }
        }

        public string DeliveryAddress
        public DateTime DeliveryDateTime
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
            get { return deliveryDateTime; }
            set { deliveryDateTime = value; }
        }

        public string SpecialRequest
        public string DeliveryAddress
        {
            get { return specialRequest; }
            set { specialRequest = value; }
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }

        public string Status
        public string OrderPaymentMethod
        {
            get { return status; }
            set { status = value; }
            get { return orderPaymentMethod; }
            set { orderPaymentMethod = value; }
        }

        public List<OrderItem> OrderItems
        public bool OrderPaid
        {
            get { return orderItems; }
            set { orderItems = value; }
            get { return orderPaid; }
            set { orderPaid = value; }
        }

        public Payment Payment
        public List<OrderedFoodItem> OrderedFoodItems
        {
            get { return payment; }
            set { payment = value; }
            get { return orderedFoodItems; }
            set { orderedFoodItems = value; }
        }

        // Constructor
        public Order()
        {
            orderItems = new List<OrderItem>();
            orderedFoodItems = new List<OrderedFoodItem>();
        }

        public Order(int orderId, DateTime createdDateTime, DateTime deliveryDate, string deliveryTime, 
                     string deliveryAddress, string status)
        public Order(int orderId, DateTime orderDateTime, string deliveryAddress, DateTime deliveryDateTime,
            string orderStatus, string orderPaymentMethod, bool orderPaid)
        {
            this.orderId = orderId;
            this.createdDateTime = createdDateTime;
            this.deliveryDate = deliveryDate;
            this.deliveryTime = deliveryTime;
            this.orderDateTime = orderDateTime;
            this.deliveryAddress = deliveryAddress;
            this.status = status;
            orderItems = new List<OrderItem>();
            this.deliveryDateTime = deliveryDateTime;
            this.orderStatus = orderStatus;
            this.orderPaymentMethod = orderPaymentMethod;
            this.orderPaid = orderPaid;
            orderedFoodItems = new List<OrderedFoodItem>();
        }

        
        public void AddOrderItem(OrderItem item)
        public void AddOrderedFoodItem(OrderedFoodItem item)
        {
            orderItems.Add(item);
            if (item != null)
            {
                orderedFoodItems.Add(item);
            }
        }

        public bool RemoveOrderedFoodItem(OrderedFoodItem item)
        {
            return orderedFoodItems.Remove(item);
        }

        public double CalculateTotal()
        public void DisplayOrderedFoodItems()
        {
            double subtotal = 0;
            foreach (OrderItem item in orderItems)
            foreach (OrderedFoodItem item in orderedFoodItems)
            {
                subtotal += item.CalculateSubtotal();
                Console.WriteLine(item.ToString());
            }
            return subtotal + 5.00; 
        }

        public void UpdateStatus(string newStatus)
        public double CalculateOrderTotal()
        {
            status = newStatus;
            double total = 0;
            foreach (OrderedFoodItem item in orderedFoodItems)
            {
                total += item.CalculateSubtotal();
            }
            orderTotal = total;
            return orderTotal;
        }

       
        public override string ToString()
        {
            return $"Order ID: {orderId}, Status: {status}, Total: ${CalculateTotal():F2}";
            return $"Order ID: {orderId}, Status: {orderStatus}, Total: ${CalculateOrderTotal():F2}";
        }
    }
}
