using System;

namespace SuganyaDinerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu foodMenu = new FoodMenu();
            foodMenu.AddMenutem("Chicken Briyani", "Biriyani with chicken", 100);
            foodMenu.AddMenutem("Mutton Briyani", "Biriyani with Mutton", 200);
            foodMenu.Name = "Suganya Diner";
            foodMenu.HospitalDirection = "Government Hospital is near to Bus stand";

            DrinkMenu drinkMenu = new DrinkMenu();
            drinkMenu.Name = "Suganya DrinkMenu";
            drinkMenu.AddMenutem("Fanta", "Fanta description", 50);
            drinkMenu.AddMenutem("Mango", "Mango description", 50);
            drinkMenu.Disclaimer="if you drink juice,you will get cold";

            Order venkatOrder = new Order();
            foreach (var item in foodMenu.MenuItems)
            {
                venkatOrder.items.Add(item);
            }

            for(int i = 0; i < drinkMenu.MenuItems.Count; i++)
            {
                venkatOrder.items.Add(drinkMenu.MenuItems[i]);
            }
        }
    }
}
