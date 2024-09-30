using System;

class GfG
{

    // Function to return the maximum water that can be stored
    static int maxWater(int[] arr)
    {
        int res = 0;

        // For every element of the array
        for (int i = 1; i < arr.Length - 1; i++)
        {

            // Find the maximum element on its left
            int left = arr[i];
            for (int j = 0; j < i; j++)
                left = Math.Max(left, arr[j]);

            // Find the maximum element on its right
            int right = arr[i];
            for (int j = i + 1; j < arr.Length; j++)
                right = Math.Max(right, arr[j]);

            // Update the maximum water
            res += Math.Min(left, right) - arr[i];
        }

        return res;
    }

    // Driver code
    static void Main()
    {
        int[] arr = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        Console.WriteLine(maxWater(arr));
    }
}