using System;   

namespace Assignment1
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hold the Peanut Butter!");
            question1();
        }
        static void question1()
        {
            // Initialize an array of points between 1 and 10, ask for user input
            int[] marks = { 2, 3, 4, 4, 6, 6, 7, 7, 9, 9, 9, 9 };
            Console.WriteLine
                (
                "Give me a number between 1 and 10. I will tell you its index position start" +
                " and end in the array or [-1,-1] if it is not in the sequence:"
                );
            int target = int.Parse(Console.ReadLine());
            int searchval = Array.IndexOf(marks, target);

            // Control flow - if user input found, run code block else return [-1,-1] and notify user 

            if (searchval > 0)
            {
                int i = 0;
                foreach (int mark in marks)
                {
                    if (mark == target)
                    {
                        i++;
                    }
                }
                // Display count of integer occurance in array 
                // Display initial position of integer in array using searchval
                // Display final position of integer in array using searchval plus count of occurance i 

                Console.WriteLine("Your values appears " + i + " times");
                Console.WriteLine(
                    "Your target appeared starting at index position " + searchval +
                    " and stopped at " + (searchval + i - 1));
            }

            else
                    {
                        Console.WriteLine("[-1,-1] your value is not in my array");
                    }
        }

    }
}