using System;
using System.Collections.Generic;
using System.Text;

namespace TddExample
{
    public class FruitRepository
    {
        private readonly List<Fruit> FruitList;

        public FruitRepository()
        {
            FruitList = new List<Fruit>
            {
                new Fruit { Name = "Banana", Calories = 89, GramsPer = 100, GeoDistribution = "Tropical" },
                new Fruit { Name = "Apple", Calories = 52, GramsPer = 100, GeoDistribution = "Temperate" },
                new Fruit { Name = "Pineapple", Calories = 50, GramsPer = 100, GeoDistribution = "Tropical" },
                new Fruit { Name = "Grape", Calories = 67, GramsPer = 100, GeoDistribution = "SubTropical" },
                new Fruit { Name = "Peach", Calories = 39, GramsPer = 100, GeoDistribution = "Temperate" }
            };
        }

        public static Fruit GetFruitWithLessCalories(int calories)
        {
            return new Fruit {Name = "Peach", Calories = 39, GramsPer = 100, GeoDistribution = "Temperate"};
        }
    }
}
