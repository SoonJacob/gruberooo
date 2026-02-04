//==========================================================
// Student Number : S10273376H, S10273736K
// Student Name   : Zander Fernandez, Jacob Soon
// Class done by  : Jacob Soon
//==========================================================
using System;
using System.Collections.Generic;

namespace GruberooFoodDelivery
{
    public class Menu
    {
        private string menuId;
        private string menuName;
        private List<FoodItem> foodItems;

        public string MenuId
        {
            get { return menuId; }
            set { menuId = value; }
        }

        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }

        public List<FoodItem> FoodItems
        {
            get { return foodItems; }
        }

        public Menu()
        {
            foodItems = new List<FoodItem>();
        }

        public Menu(string menuId, string menuName) : this()
        {
            this.menuId = menuId;
            this.menuName = menuName;
        }

        public void AddFoodItem(FoodItem foodItem)
        {
            if (foodItem != null)
            {
                foodItems.Add(foodItem);
            }
        }

        public bool RemoveFoodItem(FoodItem foodItem)
        {
            return foodItems.Remove(foodItem);
        }

        public void DisplayFoodItems()
        {
            foreach (FoodItem fi in foodItems)
            {
                Console.WriteLine("  - " + fi.ToString());
            }
        }

        public override string ToString()
        {
            return menuName + " (" + menuId + ")";
        }
    }
}
