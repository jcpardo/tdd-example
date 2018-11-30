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

     }
}
