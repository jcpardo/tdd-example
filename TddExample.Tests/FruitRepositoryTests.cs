using System.Collections.Generic;
using Newtonsoft.Json;
using Xunit;

namespace TddExample.Tests
{
    public class FruitRepositoryTests
    {
        [Fact]
        public void GetFruitWithLessCalories_GivenCaloriesAmount_ReturnsFruit()
        {
            var result = FruitRepository.GetFruitWithLessCalories(50);
            var expectedResult = new Fruit
            {
                Name = "Peach",
                Calories = 39,
                GramsPer = 100,
                GeoDistribution = "Temperate"
            };

            var resultSerializedObject = JsonConvert.SerializeObject(result);
            var expectedResultSerializedObject = JsonConvert.SerializeObject(expectedResult);

            Assert.Equal(expectedResultSerializedObject, resultSerializedObject);
        }

        [Fact]
        public void ExistFruit_GivenFruitName_ReturnsFalse()
        {
            var result = FruitRepository.ExistFruit("Mango");
            Assert.False(result);
        }

        [Fact]
        public void GetFruits_GivenGeoDistribution_ReturnsFruitList()
        {
            var result = FruitRepository.GetFruitsByGeoDistribution("Tropical");

            var expectedResult = new List<Fruit>
            {
                new Fruit {Name = "Banana", Calories = 89, GramsPer = 100, GeoDistribution = "Tropical"},
                new Fruit {Name = "Pineapple", Calories = 50, GramsPer = 100, GeoDistribution = "Tropical"}
            };

            var resultSerializedObject = JsonConvert.SerializeObject(result);
            var expectedResultSerializedObject = JsonConvert.SerializeObject(expectedResult);

            Assert.Equal(expectedResultSerializedObject, resultSerializedObject);
        }

        [Fact]
        public void GetFruits_GivenGeoDistribution_ReturnsEmpty()
        {
            var result = FruitRepository.GetFruitsByGeoDistribution("Wrong GeoDistribution");
            Assert.Empty(result);
        }

        [Fact]
        public void GetCaloriesAmount_GivenFruitAndAmount_ReturnsTotalCalories()
        {
            var result = FruitRepository.GetCaloriesAmount("Apple", 350); //Apple 52cal/100g --> (52 x 350) / 100 = 182
            var expectedResult = 182;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetCaloriesAmount_GivenFruitAndAmount_ReturnsZero()
        {
            var result = FruitRepository.GetCaloriesAmount("Mango", 350); //Mango is not in the fruit list
            var expectedResult = 0;
            Assert.Equal(expectedResult, result);
        }

    }
}
