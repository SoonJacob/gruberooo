using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // You can adjust formatting to match your expected output
            return $"{ItemName} | {ItemDesc} | ${ItemPrice:0.00} | Customise: {Customise}";
        }
    }
}
