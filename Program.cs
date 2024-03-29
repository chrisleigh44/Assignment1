﻿namespace Assignment1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hold the Peanut Butter!");
        // question1();
        // un-comment the above line to execute user input workflow.

        // question2;
        Console.WriteLine(StringReverse("University of South Florida"));


        // question3;
        int[] arrayOfNumbers = { 40, 40 };
        Console.WriteLine(minSum(arrayOfNumbers));

        // question4
        FreqSort("Dell");
        FreqSort("eebhhh");
        FreqSort("yYkk");
        FreqSort("Hello World of Peanut Butter");

        // question5();


        //question6
        char[] charArray =
        {
            'a', 'b', 'c', 'a', 'b', 'c'
        };

        isValidDistanceBetweenPairs(charArray, 2);
        isValidDistanceBetweenPairs(charArray, 3);


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
            var target = int.Parse(Console.ReadLine());
            var searchval = Array.IndexOf(marks, target);

            // Control flow - if user input found, run code block else return [-1,-1] and notify user 

            if (searchval > 0)
            {
                var i = 0;
                foreach (var mark in marks)
                    if (mark == target)
                        i++;
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
        static string reverseString(string word)
        {
            word = word.Trim();

            var reverse_word = "";

            for (var index = word.Length - 1; index >= 0; index--) reverse_word = reverse_word + word[index];

            reverse_word += " ";


            return reverse_word;
        }


        ;

        // Reverse array

        static string StringReverse(string inputPhrase)
        {
            var outputPhrase = "";
            var startIndex = 0;

            // Create sub-arrays/dicts
            for (var index = 0; index < inputPhrase.Length; index++)
                if (char.IsWhiteSpace(inputPhrase[index]))
                {
                    var endIndex = index;
                    outputPhrase += reverseString(inputPhrase[startIndex..endIndex]);
                    startIndex = endIndex;
                }

            outputPhrase += reverseString(inputPhrase[startIndex..]);

            return outputPhrase;
        }


        //Question #3 Start __________________________________________________
        static int minSum(int[] arrayOfNumbers)
        {
            //Start at index 1 
            for (var index = 1; index < arrayOfNumbers.Length; index++)
                //current element in array is equal to its pre-decessor, increase by 1
                if (arrayOfNumbers[index - 1] == arrayOfNumbers[index])
                    arrayOfNumbers[index]++;

            return arrayOfNumbers.Sum();
        }


        //Question #4 Start __________________________________________________
        static string FreqSort(string s)
        {
            // Create a dictionary of lower case characters and their frequency in the string as key value pairs
            var freq = new Dictionary<char, int>();

            foreach (var c in s)
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq.Add(c, 1);

            // order characters into new string using descending frequency as scoring method.
            // For clairty on longer input strings, we order by frequency, then by character (default ascii ordering), so .
            var sorted_string = new string(s.OrderByDescending(c => freq[c]).ThenByDescending(c => c).ToArray());

            Console.WriteLine(sorted_string);

            return sorted_string;
        }

        //Question #5 Start __________________________________________________
        static void question5()
        {
            int[] numbs1 = { 1, 2, 2, 5, 6, 6 };
            int[] numbs2 = { 2, 2, 5, 6, 6, 7 };
            Console.WriteLine("The intersecting values are: ");
            foreach (var num in numbs1)
            {
                int[] numb3 = { num };

                var intersection = numb3.Intersect(numbs2).FirstOrDefault();

                if (intersection != 0) Console.WriteLine(intersection);
            }
        }


        //
        // Question #6 Start __________________________________________________
        static bool isValidDistanceBetweenPairs(char[] charArray, int maxAbsoluteDistanceBetweenPairs)
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
                                "FALSE - The distance between the pairs is greater than the max distance of " +
                                maxAbsoluteDistanceBetweenPairs + " - returning false");
                            return false;
                        }

                        // an index has found it's pairEndIndex that is within range, so can be added to the measuredIndexPairStore to prevent further use.
                        measuredIndexPairStore.Add(pairEndIndex);
                        break;
                    }
            }

            Console.WriteLine("The distance between all pairs is less than the max distance - returning true");
            return true;
        }
    }
}