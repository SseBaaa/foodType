using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodType
{
    internal class FoodType
    {
        private string name;
        private int protein, carbs, fat;
        private static int instances = 0;

        public FoodType()
        {
            instances++;
        }
        ~FoodType()
        {
            instances--;
        }
        public static int GetActiveInstances()
        {
            return instances;
        }

        public FoodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
        }
        public override string ToString()
        {
            return name + ":" + " p- " + protein + "% , " + " c- " + carbs + "% , " + "f-" + fat + "%";
        }

        public string Name { get => name; set => name = value; }
        public int Protein { get => protein; set => protein = value; }
        public int Carbs { get => carbs; set => carbs = value; }
        public int Fat { get => fat; set => fat = value; }
    }
}
