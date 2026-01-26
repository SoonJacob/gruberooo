using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gruberoo
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
