namespace Solution
{
    public static class Main
    {
        public static int RemoveDuplicates(ref int[] nums)
        {
            if (nums.Length < 2)
                return nums.Length;
            int writeIndex = 2;
            for (int readIndex = 2; readIndex < nums.Length; readIndex++)
            {
                if (nums[readIndex] != nums[writeIndex - 1] || nums[readIndex] != nums[writeIndex - 2])
                {
                    writeIndex++;
                    nums[writeIndex - 1] = nums[readIndex];

                }

            }
            nums = nums[0..writeIndex];
            return writeIndex;
        }

    }
}
