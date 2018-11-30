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
                geoDistribution = "Temperate"
            };

            Assert.Equal(expectedResult, result);
        }
    }
}
