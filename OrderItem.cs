//==========================================================
// Student Number : S1234567
// Student Name : [Your Name]
// Partner Name : [Partner Name]
//==========================================================

using System;

namespace GruberooFoodDelivery
{
    class OrderItem
    {
        private FoodItem foodItem;
        private int quantity;

        // Properties
        public FoodItem FoodItem
        {
            get { return foodItem; }
            set { foodItem = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        // Constructor
        public OrderItem() { }

        public OrderItem(FoodItem foodItem, int quantity)
        {
            this.foodItem = foodItem;
            this.quantity = quantity;
        }

        // Methods
        public double CalculateSubtotal()
        {
            return foodItem.Price * quantity;
        }

        // ToString method
        public override string ToString()
        {
            return $"{foodItem.ItemName} - {quantity}";
        }
    }
}
