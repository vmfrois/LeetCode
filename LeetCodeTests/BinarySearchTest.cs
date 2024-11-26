using LeetCode.Algorithms;

namespace LeetCodeTests
{
    public class BinarySearchTest
    {
        [Fact]
        public void LeetCode_Case_1()
        {
            //arrange
            int[] nums = [-1, 0, 3, 5, 9, 12];
            int target = 9;
            int expected = 4;

            //act
            var result = BinarySearch.Search(nums, target);

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void LeetCode_Case_2()
        {
            //arrange
            int[] nums = [-1, 0, 3, 5, 9, 12];
            int target = 2;
            int expected = -1;

            //act
            var result = BinarySearch.Search(nums, target);

            //asert
            Assert.Equal(expected, result);
        }

    }
}