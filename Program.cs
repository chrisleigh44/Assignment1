using System;

namespace Assignment1
    
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hold the Peanut Butter!");
            question1();
            question2();
            question3();
            question4();
            question5();
            question6();
        }


        //Question #1 Start __________________________________________________
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
                        Console.WriteLine("[-1,-1] your value is not in my array or there is peanut butter in my circuits");
                    }
        }

        //Question #2 Start __________________________________________________
        static void question2()
        { 

        }

        //Question #3 Start __________________________________________________
        static void question3()
        using System;
        using System.Linq;

        public class GFG
        {

            // Returns minimum possible
            // sum of all  min int[] arr
            static int minSum(int[] arr, int n)
            {
                int min_val = arr.Sum();
                return min_val;
                ;
            }

            // Driver Code
            static public void Main()
            {
                int[] A = { 2,3,5,6,9,40 };
                int n = A.Length;
                Console.WriteLine(minSum(A, n));

            }
        }

        //Question #4 Start __________________________________________________
        static void question4()
        { 

        }

        //Question #5 Start __________________________________________________
        static void question5()
        {
            int[] numbs1 = { 1, 2, 3, 3, 4, 5, 6 };
            int[] numbs2 = { 2, 3, 3, 4, 5 };
            int numblength1 = numbs1.Length;
            int numblength2 = numbs2.Length;
            int resultlength;
            int[] longarray;
          
         

            if (numblength1>numblength2)
            {
                resultlength = numblength1;
                longarray = numbs1;
            }
            else
            {
                resultlength = numblength2;
                longarray = numbs2;
            }

            int[] results = new int[resultlength];
            int[] distinctarray = longarray.Distinct().ToArray();

            foreach(int i in longarray)
            {
                int countnumb1 = numbs1.Count(i);
                int countnumb2 = numbs2.Count(i);
                int loopcounter;
                if (countnumb1+countnumb2 > 1)
                {
                    if(countnumb1 > countnumb2)
                    {
                        loopcounter = countnumb1;
                    }
                    else
                    {
                        loopcounter = countnumb2;
                    }
                    for(int j=0; j <= loopcounter; j++)
                    {

                    }
                }
            }


            //initialize an array or list variable thats length/size is set to the longest length array numb1 / numb2; call it results
            //determine the longer length array
            //initialize a new array with distinct values of the longer array
            //start a for loop
            //for *each value in the distinct array, count how many times it appears in numbs1 - call it countnumb1
            //for *each value in the distinct array, count how many times it appears in numbs2 - call it countnumb2
            //if the value of countnumb1 + countnumb2  < 2, end loop and go to next number (no matches found) 
            //if the value is 2 or larger proceed on
            //create a new variable in the loop that contains the smaller count number (call it loopcounter)
            //if countnumb1 < countnumb2, countnumb1 = loopcounter
            //else countnumb2 = loopcounter
            //add *each value to the results array / list by loopcounter times
            //print the results of results array

        }

        //Question #6 Start __________________________________________________
        static void question6()
        { 
        
        }

    }
}
