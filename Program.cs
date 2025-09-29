namespace Assignment6._1._3
{
    internal class Program
    {
        static void DisplayArray(int[] nums)
        {
            Console.WriteLine("Array elements:");
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        public static void MoveZeroes(int[] nums)
        {
            DisplayArray(nums);
            if (nums == null || nums.Length == 0)
            {
                return; // Handle empty or null arrays
            }

            int nonZeroPointer = 0; // Pointer to place the next non-zero element

            
            for (int current = 0; current < nums.Length; current++)// Iterate through the array with a 'current' pointer
            {
                
                if (nums[current] != 0)// If the current element is not zero, move it to the position indicated by nonZeroPointer
                {
                    nums[nonZeroPointer] = nums[current];
                    nonZeroPointer++; // Increment nonZeroPointer to the next available position
                }
            }

            
            while (nonZeroPointer < nums.Length)// After moving all non-zero elements to the beginning, fill the remaining positions with zeros
            {
                nums[nonZeroPointer] = 0;
                nonZeroPointer++;
            }
            DisplayArray(nums);
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 0, 5, 0, 4, 0, 3 };
            MoveZeroes(nums);
        }
    }
}
