
public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length'
    /// starting with 'number' followed by multiples of 'number'.
    /// For example, MultiplesOf(7, 5) will result in:
    /// {7, 14, 21, 28, 35}.
    /// </summary>
    /// <returns>Array of doubles containing the multiples</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // So this is how it works

        // Step 1: Create a new double array with the given length.
        // Step 2: Use a for loop to go through each position.
        // Step 3: Multiply the number by the current index plus 1.
        // Step 4: Store the result in the array.
        // Step 5: Return the completed array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.
    /// For example, {1, 2, 3, 4, 5, 6, 7, 8, 9}
    /// rotated by 3 becomes {7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// This function modifies the original list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // How it works

        // Step 1: Find where the last 'amount' elements begin.
        // Step 2: Copy those elements into a temporary list.
        // Step 3: Remove those elements from the original list.
        // Step 4: Insert the saved elements at the beginning.
        // Step 5: The original list is now rotated to the right.

        int startIndex = data.Count - amount;

        List<int> lastElements = data.GetRange(startIndex, amount);

        data.RemoveRange(startIndex, amount);

        data.InsertRange(0, lastElements);
    }
}
