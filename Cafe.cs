using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallenges
{
    public class Menu
    {
        public int MealNumber { get; set; }
        public string Name { get; set; }
        public string MealDescription { get; set; }
        public List<string> Ingredients { get; set; }
        public int Price { get; set; }

        public Menu() { }
        public Menu(int mealNumber, string name, string mealDescription, List<string> ingredients, int price)
        {
            MealNumber = mealNumber;
            Name = name;
            MealDescription = mealDescription;
            Ingredients = ingredients;
            Price = price;
        }
    }
}
