using System;
using System.Collections.Generic;

namespace c_sharp_control_flow
{
    public class TextExercises
    {
        public static string Exercise1()
        {
            //1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
            //cw ask for numbers
            Console.WriteLine("Give me some numbers separated with a hypthen.");
            //crl store as string
            string inputStr = Console.ReadLine();
            //use .Split method to store in array
            string[] inputArr = inputStr.Split('-');
            // convert to Int32 in new list
            var intList = new List<int>();
            foreach (var thing in inputArr)
            {
                intList.Add(Convert.ToInt32(thing));
            }
            // sort to simplify original question
            intList.Sort();
            bool isConsecutive = true;
            string result;
            for (var i = 1; i < intList.Count; i++)
            {
                if (intList[i] == intList[i - 1] + 1)
                {
                    continue;
                }
                else
                {
                    isConsecutive = false;
                    break;
                }
            }
            if (isConsecutive)
                result = "Is Consecutive";
            else
                result = "Is NOT consecutive";
            return result;
        } //end Exercise1()

        public static void Exercise2()
        {
            //2- Write a program and ask the user to enter a few numbers separated by a hyphen.
            // If the user simply presses Enter, without supplying an input, exit immediately; 
            // otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            Console.WriteLine("Give me some numbers separated by a hyphen, please!");
            string input = Console.ReadLine();
            if (System.String.IsNullOrEmpty(input))
            {

            }
            else
            {
                // split into array
                var inputArr = input.Split('-');
                var inputList = new List<string>();
                bool isDuplicate = false;
                // foreach, compare string. If equal, duplicate, break. Else, continue. Flag.
                foreach (var num in inputArr)
                {
                    if (inputList.Contains(num))
                    {
                        isDuplicate = true;
                        break;
                    }
                    else
                        inputList.Add(num);
                }
                if (isDuplicate)
                    Console.WriteLine("Contains duplicate");
                else
                    Console.WriteLine("All numbers are unique.");
            }
        } //end exercise2()

        public static void Exercise3()
        {
            //3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time 
            //should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't 
            //provide any values, consider it as invalid time.
            // check if null or empty
            // split using ':' char into array
            // check that array length = 2
            // check that arr[0] >= 0 && <= 23
            // check that arr[1] >= 0 && <= 59
            Console.WriteLine("give me a military time");
            var input = Console.ReadLine();
            if (System.String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time");
            }
            else
            {
                string[] inputArr = input.Split(':');
                if (inputArr.Length == 2)
                {
                    int hour = Convert.ToInt32(inputArr[0]);
                    int min = Convert.ToInt32(inputArr[1]);
                    if (hour >= 0 && hour <= 23 && min >= 0 && min <= 59)
                    {
                        Console.WriteLine("OK");
                    }
                    else
                    {
                        Console.WriteLine("Invalid time");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid time");
                }
            }
        } // end exercise3()

    }
}
