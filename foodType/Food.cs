using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodType
{
    internal class Food
    {
        FoodType type;
        double weight;

        public Food(FoodType type, double weight)
        {
            this.type = type;
            this.weight = weight;
        }
        public override string ToString()
        {
            
            return type.Name + ":" + " p- " + type.Protein + "% , " + " c- " + type.Carbs + "% , " + "f-" + type.Fat + "% , w - " + weight + "g";
        }

        public double getProtein()
        {
            return weight * (type.Protein/100.0);
        }
        public double getCarbs()
        {
            return weight * (type.Carbs/100.0);
        }
        public double getFat()
        {
            return weight * (type.Fat/100.0);
        }

        public string toStringInGrams()
        {
            return type.Name + ":" + " p- " + getProtein() + "g , " + " c- " + getCarbs() + "g , " + "f-" + getFat() + "g , w - " + weight + "g";
        }

        public double Weight { get => weight; set => weight = value; }
        internal FoodType Type { get => type; set => type = value; }
    }
}
