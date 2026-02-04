//==========================================================
// Student Number : S10273376H, S10273736K
// Student Name   : Zander Fernandez, Jacob Soon
// Class done by  : Jacob Soon
//==========================================================
using System;

namespace GruberooFoodDelivery
{
    public class OrderedFoodItem
    {
        private FoodItem foodItem;
        private int qtyOrdered;
        private double subTotal;

        // Properties
        public FoodItem FoodItem
        {
            get { return foodItem; }
            set { foodItem = value; }
        }

        public int QtyOrdered
        {
            get { return qtyOrdered; }
            set { qtyOrdered = value; }
        }

        public double SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }

        // Constructors
        public OrderedFoodItem() { }

        public OrderedFoodItem(int qtyOrdered, FoodItem foodItem)
        {
            this.qtyOrdered = qtyOrdered;
            this.foodItem = foodItem;
            this.subTotal = 0;
        }

        // Methods
        public double CalculateSubtotal()
        {
            if (foodItem != null)
            {
                subTotal = foodItem.ItemPrice * qtyOrdered;
            }
            return subTotal;
        }

        public override string ToString()
        {
            if (foodItem != null)
            {
                return foodItem.ItemName + " x" + qtyOrdered + " $" + foodItem.ItemPrice.ToString("0.00") + 
                       " Subtotal: $" + subTotal.ToString("0.00");
            }
            return "Invalid OrderedFoodItem";
        }
    }
}


