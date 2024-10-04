public class Challenge_two
{
    public void GuessNumber()
    {
        Random rnd = new();
        int secret = rnd.Next(0,10); // Assign the secret value
        int? guess = -1;
        while (guess != secret)
        {
            Console.WriteLine("Guess the secret number: ");
            guess = int.Parse(Console.ReadLine());
            // Todo: Implement the correct conditionals inside the while loop.
            if(guess == secret) {Console.WriteLine("You guessed it!");break;}
        }
    }

    public void Fibonacci(int n)
    {
        int a = 0, b = 1, c;
        //Console.WriteLine($"{a} + {b} + ");
        // Todo: Write out the Fibonacci sequence, tips: use a for loop.
        // c = a + b;
        // a = b;
        // b = c;
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        for (int i = 0; i < n; i++)
        {
            c=a+b;
            Console.WriteLine($"{c}");
            a=b;
            b=c;
        }
    }

    public void CheckIfNumberIsEvenOrOdd(double a, double b)
    {
        // Todo: Check if a number is even or odd
        // if the number is even, write out "even"
        // if the number is odd, write out "odd"
        if(a%2==0)Console.WriteLine($"{a} is even");
        else Console.WriteLine($"{a} is odd");
        if(a%2==0)Console.WriteLine($"{b} is even");
        else Console.WriteLine($"{b} is odd");
        
    }
}