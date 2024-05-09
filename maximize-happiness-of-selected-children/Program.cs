using System;
using System.Linq;

class Solution
{
    public long MaximumHappinessSum(int[] happiness, int k)
    {
        // Sort the array in descending order
        Array.Sort(happiness, (a, b) => b.CompareTo(a));

        long totalHappiness = 0;
        int i = 0;

        // Iterate through the sorted array to select `k` children
        while (k > 0)
        {
            // Adjust the current child's happiness value, ensure it does not go below 0
            happiness[i] = Math.Max(happiness[i] - i, 0);
            
            // Add the adjusted happiness value to the total
            totalHappiness += happiness[i];
            
            // Increment the index for the next iteration
            i++;
            
            // Decrease k by 1 each iteration
            k--;
        }

        // Return the total happiness sum
        return totalHappiness;
    }

    static void Main()
    {
        // Provided test case
        int[] happiness = {1, 2, 3};
        int k = 2;

        // Create a solution instance
        Solution solution = new Solution();
        
        // Calculate the maximum happiness sum and print the output
        Console.WriteLine("Output: " + solution.MaximumHappinessSum(happiness, k)); // Expected output: 4
    }
}
