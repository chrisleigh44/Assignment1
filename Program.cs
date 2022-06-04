using System;
using System.Runtime.InteropServices;
using System.Linq;

namespace Assignment1;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hold the Peanut Butter!");
        // question1();
        // question2();
        // question3();
        FreqSort("Dell");
        FreqSort("eebhhh");
        FreqSort("yYkk");
        FreqSort("Hello World of Peanut Butter");
        // question5();
        char[] charArray =
        {
            'a', 'b', 'c', 'a', 'b', 'c'
        };

        isValidDistanceBetweenPairs(charArray: charArray, maxAbsoluteDistanceBetweenPairs: 2);
        isValidDistanceBetweenPairs(charArray: charArray, maxAbsoluteDistanceBetweenPairs: 3);


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
        static string FreqSort(string s)
        {
            // Create a dictionary of lower case characters and their frequency in the string as key value pairs
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (freq.ContainsKey(c))
                {
                    freq[c]++;
                }
                else
                {
                    freq.Add(c, 1);
                }
            }

            // order characters into new string using descending frequency as scoring method.
            // For clairty on longer input strings, we order by frequency, then by character (default ascii ordering), so .
            string sorted_string = new string(s.OrderByDescending(c => freq[c]).ThenByDescending(c => c).ToArray());

            Console.WriteLine(sorted_string);

            return sorted_string;

        }

        //Question #5 Start __________________________________________________
        static void question5()
        {
            // int[] numbs1 = { 1, 2, 3, 3, 4, 5, 6 };
            // int[] numbs2 = { 2, 3, 3, 4, 5 };
            // int numblength1 = numbs1.Length;
            // int numblength2 = numbs2.Length;
            // int resultlength;
            // int[] longarray;
            //
            //
            //
            // if (numblength1 > numblength2)
            // {
            //     resultlength = numblength1;
            //     longarray = numbs1;
            // }
            // else
            // {
            //     resultlength = numblength2;
            //     longarray = numbs2;
            // }
            //
            // int[] results = new int[resultlength];
            // int[] distinctarray = longarray.Distinct().ToArray();
            //
            // foreach (int i in longarray)
            // {
            //     int countnumb1 = numbs1.Count(i);
            //     int countnumb2 = numbs2.Count(i);
            //     int loopcounter;
            //     if (countnumb1 + countnumb2 > 1)
            //     {
            //         if (countnumb1 > countnumb2)
            //         {
            //             loopcounter = countnumb1;
            //         }
            //         else
            //         {
            //             loopcounter = countnumb2;
            //         }
            //
            //         for (int j = 0; j <= loopcounter; j++)
            //         {
            //
            //         }
            //     }
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
    //
    // Question #6 Start __________________________________________________
    //  /Example 2: arr=[k, y, k, k], k=1
    //  Output= true
    //  Example 3: 
    //  Input: arr=[a, b, c, a, b, c], k=2
    //  Output: false
    private static bool isValidDistanceBetweenPairs(char[] charArray, int maxAbsoluteDistanceBetweenPairs)
    {
        // used to track indices which have already been measured.
        var measuredIndexPairStore = new List<int>();

        for (var index = 0; index < charArray.Length; index++)
        {
            // Gaurd clause assumptions: Characters without a pair have distance = 0 not distance = infinite.
            if (measuredIndexPairStore.Contains(index)) continue;

            // Each starting value is only valid once, once it has been a starting character, it can not also be a ending character of another pair and vice versa.
            measuredIndexPairStore.Add(index);

            // The left most character in the Array - e.g. the starting point for measuring distance between indices.
            var pairStartingChar = charArray[index];

            // Search forward in the array until a pair is found, then measure the distance, and add the indice of the pair to measuredIndexPairStore
            for (var pairEndIndex = index + 1; pairEndIndex < charArray.Length; pairEndIndex++)
            {   


                if (pairStartingChar == charArray[pairEndIndex])
                {
                    if (measuredIndexPairStore.Contains(pairEndIndex)) continue;

                    var distance = Math.Abs(pairEndIndex - index);

                    Console.WriteLine(charArray[index] + " " + index + " -> " + charArray[pairEndIndex] + " " +
                                      pairEndIndex + " in the array " + string.Join("", charArray) +
                                      "has a distance of " + distance);

                    if (distance > maxAbsoluteDistanceBetweenPairs)
                    {
                        // We only need one instance of the distance being out of range for this function to return false - so we can do that here, true will only be returned if every distance pair is valid.
                        Console.WriteLine(
                            "FALSE - The distance between the pairs is greater than the max distance of " + maxAbsoluteDistanceBetweenPairs + " - returning false");
                        return false;
                    }

                    // an index has found it's pairEndIndex that is within range, so can be added to the measuredIndexPairStore to prevent further use.
                    measuredIndexPairStore.Add(pairEndIndex);
                    break;
                }
            }
        }

        Console.WriteLine("The distance between all pairs is less than the max distance - returning true");
        return true;
    }
}
