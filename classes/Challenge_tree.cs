using System.Text;
/*
These are very difficult.
*/
public class Challenge_three
{
    public void FizzBuzz(int number)
    {
        // Todo: Implement fizzbuzz, if a number is divisible by 3: Fizz, if a number is divisible by 5: Buzz, if the number is divisible by both 3 and 5, FizzBuzz
        // https://www.geeksforgeeks.org/fizz-buzz-implementation/
        if (number % 3 == 0 && number % 5 == 0){
            Console.WriteLine("FizzBuzz");
        }
        else if(number%3==0) Console.WriteLine("Fizz");
        else if(number%5==0) Console.WriteLine("Buzz");

    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        
        if (n == 0)
        {
            return 1;
        }
        else return n*RecursiveFactorial(n - 1);
    }

    public string ReverseString(string str)
    {
        // Todo: reverse the given string
        
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}