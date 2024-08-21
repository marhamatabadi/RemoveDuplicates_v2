using Solution;

namespace RemoveDuplicates_v2.Test
{
    public class MainTest
    {
        [Theory]
        [InlineData([new int[] { 1, 1, 1, 2, 2, 3 }, new int[] { 1, 1, 2, 2, 3 }, 5])]
        [InlineData([new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }, new int[] { 0, 0, 1, 1, 2, 3, 3 }, 7])]
        [InlineData([new int[] { 0 }, new int[] { 0 }, 1])]
        [InlineData([new int[] { 0, 0 }, new int[] { 0, 0 }, 2])]
        [InlineData([new int[] { 0, 0, 0 }, new int[] { 0, 0 }, 2])]
        public void Solution_AnswerTest(int[] nums, int[] expectednums, int ecpectedval)
        {
            int actual = Main.RemoveDuplicates(ref nums);
            Assert.Equal(ecpectedval, actual);

            Assert.Equal(expectednums, nums);
        }
    }
}