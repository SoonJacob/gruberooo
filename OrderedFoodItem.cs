//==========================================================
// Student Number : S10273376H, S10273736K
// Student Name   : Zander Fernandez, Jacob Soon
// Class done by  : Jacob Soon
//==========================================================
using System;
using System.Collections.Generic;

namespace GruberooFoodDelivery
{
    public class OrderedFoodItem : FoodItem
    {
        public OrderedFoodItem() { }

        public OrderedFoodItem(string itemName, string itemDesc, double itemPrice, string customise, int qtyOrdered)
            : base(itemName, itemDesc, itemPrice, customise)
        {
            QtyOrdered = qtyOrdered;
            SubTotal = 0;
        }

        public int QtyOrdered { get; set; }
        public double SubTotal { get; set; }

        public double CalculateSubtotal()
        {
            SubTotal = ItemPrice * QtyOrdered;
            return SubTotal;
        }

        public override string ToString()
        {
            return $"{ItemName} x{QtyOrdered}  ${ItemPrice:0.00}  Subtotal: ${SubTotal:0.00}  Customise: {Customise}";
        }
    }
}



