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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        //Jarom: I need declare a results array<double> with a size correponding to length
        double[] multiplesOfTheNumber = new double[length];
        /*Jarom: I need a while loop with the condition that whereas multiplesCount < length then keeps with the loop*/
        int multiplesCount = 0;
        /*Jarom: I need a variable called product to multiply by number*/
        int product = 1;
        while (multiplesCount < length)
        {
            //Jarom: I multiply the number by a index to get the multiples and with the count breaks the loop
            multiplesOfTheNumber[multiplesCount] = number * product;
            multiplesCount++;
            /*Jarom: I need to increase the product variable for getting new multiples*/
            product++;
        }
        return multiplesOfTheNumber; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        //Jarom: I need to slice starting with the last until the number of elements necessary for moving
        //Jarom: I decided to see the difference between the amount and count
        int differenceBetweenAmountAndCount = data.Count - amount;
        // Console.WriteLine("Amount: " + amount + " COunt: " + data.Count);
        if (differenceBetweenAmountAndCount != 0)
        {

            // Console.WriteLine(differenceBetweenAmountAndCount);
            List<int> slideElementsByAmountIndex = data.GetRange(differenceBetweenAmountAndCount, amount);
            //Jarom: I need to extract the first elements until the differenceBetweenAmountAndCount
            List<int> firstElements = data.GetRange(0, differenceBetweenAmountAndCount);
            //Jarom: I need to put the last elements in the data list starts firstly 0 to indexToMove + 1
            // Console.WriteLine("" + slideElementsByAmountIndex.Count + " " + differenceBetweenAmountAndCount);
            //Jarom: I clear the list because I saved before the elements
            data.Clear();
            // Console.WriteLine("SLideElementsByAmountIndex");
            //Jarom: I start to add the elements contained in slideElementsByAmountIndex
            foreach (var value in slideElementsByAmountIndex)
            {
                data.Add(value);
                // Console.Write("" + value);
            }
            // Console.WriteLine("\nFirstElements");
            //Jarom: I need to put the first elements after the indexToMove + 1
            foreach (var value in firstElements)
            {
                data.Add(value);
                // Console.Write("" + value);
            }

        }


    }
}
