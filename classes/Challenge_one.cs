public class Challenge_one
{
    public void PrintNumbers()
    {
        // Todo: Print out the numbers 1 - 10
        List<int> ints = [1,2,3,4,5,6,7,8,9,10];
        foreach (var item in ints)
        {
            Console.WriteLine(item);
        }
    }

    public void PrintStrings(string[] arr)
    {
        /* Todo: Print out each string that is passed to the array as an argument*/
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    public void CheckIfNumberIsPositiveOrNegative(int number)
    {
        /*
        Todo: Check if a number is positive, negative or zero.
        */
        if(number>0) Console.WriteLine($"{number} is not negative");
        else if(number==0) Console.WriteLine($"{number} is 0");
        else Console.WriteLine($"{number} is negative");
    }


}