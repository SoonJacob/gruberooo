//==========================================================
// Student Number : S10273376H, S10273736K
// Student Name   : Zander Fernandez, Jacob Soon
// Class done by  : Jacob Soon
//==========================================================
using System;
using System.Collections.Generic;

namespace gruberoo
{
    public class FoodItem
    {
        public FoodItem() { }

        public FoodItem(string itemName, string itemDesc, double itemPrice, string customise)
        {
            ItemName = itemName;
            ItemDesc = itemDesc;
            ItemPrice = itemPrice;
            Customise = customise;
        }

        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public double ItemPrice { get; set; }
        public string Customise { get; set; }
        public override string ToString()
        {
            return $"{ItemName} {ItemDesc} ${ItemPrice:0.00} Customise: {Customise}";
        }
    }
}




