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
            // Initialize an array of points between 1 and 10
            int[] marks = { 2, 3, 4, 4, 6, 6, 7, 7, 9, 9, 9, 9 };

            //Prompt the user to enter a number between 1 and 10
            Console.WriteLine("Give me a number between 1 and 10. I will tell you when it starts and stops in the sequense or [-1,-1] if it is not in the sequence");
            int target = int.Parse(Console.ReadLine());

            //Find the first occurance of the point in the array - count until it stops
            int searchval  = Array.IndexOf(marks, target);
            

            // Display the results to the user
            Console.WriteLine(searchval);
        }

    }
}