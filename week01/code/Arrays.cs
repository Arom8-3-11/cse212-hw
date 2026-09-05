using System.Diagnostics;
// this is what helps with debugging, allowing to use certain methods such as debug.writeline 

// for testing to see the different multiples and rotations use in terminal: dotnet test .\week01\code\code.csproj --logger "console;verbosity=detailed"




public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start: Remember: Using comments in your program, write down your process for solving this problem step by step before you write the code. The plan should be clear enough that it could be implemented by another person.
        //create array w/len pos
        //loop each index (0 - len-1)
        //calc mult: num * (ind + 1)
        //store result in array
        //return comp. array

        // Create/return array of multiples of numbers
        var result = new double[length];
        // loop through each pos. in array
        for (var i = 0; i < length; i++)
        {
            // 1st mult.is #*1, index + 1
            // store each mult. in array
            result[i] = number * (i + 1);
        }
        // return completed array
        //these will debug and printout the different lists of multiples using the debug test on line 4
        Debug.WriteLine($"MultiplesOf({number}, {length}) -> {{{string.Join(", ", result)}}}");
        Console.WriteLine($"MultiplesOf({number}, {length}) -> {{{string.Join(", ", result)}}}");
        return result;
    }






    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start: Remember: Using comments in your program, write down your process for solving this problem step by step before you write the code. The plan should be clear enough that it could be implemented by another person.
        // find splint point: count - amount (where rotation begins)
        // extract last amount(move to front)
        // extract first part (move to back)
        // clear list/rebuild: end->first, beginning items


        // Find the index where the final amount of items begins.
        var splitIndex = data.Count - amount;
        // example: splitIndex - 9-3 = 6 , so last 3 items move to the front

        // Copy the items that will move to the front.
        var endingPart = data.GetRange(splitIndex, amount);
        // example if 3: {7, 8, 9}
        // example if 5: {5, 6, 7, 8, 9}

        // Copy the items that will move to the back.
        var beginningPart = data.GetRange(0, splitIndex);
        // example if 3: {7, 8, 9, (1, 2, 3, 4, 5, 6)}
        // example if 5: {5, 6, 7, 8, 9, (1, 2, 3, 4)}

        // Clear the original list.
        data.Clear();

        // Add the ending items first, followed by the beginning items.
        data.AddRange(endingPart);
        data.AddRange(beginningPart);
        //these will debug and printout the rotated list using the debug test on line 4
        Debug.WriteLine($"Rotate right by {amount} -> {{{string.Join(", ", data)}}}");
        Console.WriteLine($"Rotate right by {amount} -> {{{string.Join(", ", data)}}}");
    }
}
