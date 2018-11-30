using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TddExample
{
    public class FruitRepository
    {
        private static readonly List<Fruit> fruitList = new List<Fruit>
        {
            new Fruit { Name = "Banana", Calories = 89, GramsPer = 100, GeoDistribution = "Tropical" },
            new Fruit { Name = "Apple", Calories = 52, GramsPer = 100, GeoDistribution = "Temperate" },
            new Fruit { Name = "Pineapple", Calories = 50, GramsPer = 100, GeoDistribution = "Tropical" },
            new Fruit { Name = "Grape", Calories = 67, GramsPer = 100, GeoDistribution = "SubTropical" },
            new Fruit { Name = "Peach", Calories = 39, GramsPer = 100, GeoDistribution = "Temperate" }
        };


        public static Fruit GetFruitWithLessCalories(int calories)
        {
            return fruitList.FirstOrDefault(x => x.Calories < calories);
        }

        public static bool ExistFruit(string name)
        {
            return fruitList.Any(x => x.Name == name);
        }

        public static List<Fruit> GetFruitsByGeoDistribution(string geoDistribution)
        {
            return fruitList.Where(x => x.GeoDistribution == geoDistribution).ToList();
        }

        public static int GetCaloriesAmount(string fruitName, int amountGrams)
        {
            var fruit = fruitList.FirstOrDefault(x => x.Name == fruitName);

            if (fruit != null)
            {
                return fruit.Calories * amountGrams / fruit.GramsPer;
            }

            return 0;
            
        }
    } 
}
