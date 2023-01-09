using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = FoodType.GetActiveInstances();
            FoodType foodType = new FoodType("banana", 4, 93, 3);
            Food food = new Food(foodType, 110);
            Console.WriteLine("protein: " + food.getProtein() + "\ncarbs: " + food.getCarbs() + "\nfat: " + food.getFat());
            Console.WriteLine(food.toStringInGrams());
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
