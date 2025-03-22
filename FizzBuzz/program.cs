
using System;

namespace FizzBuzz
{
    public class program
    {
        static void Main(string[] args)
        {
            Fizz_Buzz New_Fizz_Buzz = new Fizz_Buzz();
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            var result = New_Fizz_Buzz.New_Fizz_Buzz_Result(input);

            Console.WriteLine("Output String:");
            Console.WriteLine(result.Output);
            Console.WriteLine("Count: " + result.counter);

        }
    }
}
