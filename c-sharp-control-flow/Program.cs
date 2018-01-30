﻿using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace c_sharp_control_flow
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ////else if statements:
            //string timeOfDay = "afternoon";
            //if (timeOfDay == "afternoon")
            //    Console.WriteLine("Good afternoon!");
            //else if (timeOfDay == "morning")
            //    Console.WriteLine("Good morning!");
            //else
            //    Console.WriteLine("good evening!");

            ////switch version:
            //switch (timeOfDay)
            //{
            //    case "morning":
            //        Console.WriteLine("Good morning!");
            //        break;
            //    case "afternoon":
            //        Console.WriteLine("Good afternoon!");
            //        break;
            //    default:
            //        Console.WriteLine("good evening!");
            //        break;
            //}

            //var color = CarColor.Blue;

            //switch (color)
            //{
            //    case CarColor.Red:
            //        Console.WriteLine("your car is red");
            //        break;
            //    case CarColor.Blue:
            //        Console.WriteLine("your car is blue");
            //        break;
            //    case CarColor.Black:
            //    default:
            //        Console.WriteLine("I don't know your color...");
            //        break;
            //}

            //// #1: Write a program that checks whether a number is between 1-10.

            //int inputNum;
            //inputNum = -5;

            //if (inputNum >= 1 && inputNum <= 10)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            //// #2: Write a program that displays the higher of two numbers.

            //int firstNum = 12;
            //int secondNum = 10;

            //if (firstNum > secondNum)
            //{
            //    Console.WriteLine("{0} is greater than {1}.", firstNum, secondNum);
            //}
            //else if (secondNum > firstNum)
            //{
            //    Console.WriteLine("{0} is greater than {1}.", secondNum, firstNum);
            //}
            //else
            //{
            //    Console.WriteLine("They're equal!");
            //}

            //// #3: Enter image width/height as array. Write program that determines portait or landscape.

            //float[] widthHeight = new float[2];
            //widthHeight[0] = 100.5f;
            //widthHeight[1] = 200.9f;

            //if (widthHeight[0] > widthHeight[1])
            //{
            //    Console.WriteLine("It's a landscape");
            //}
            //else {
            //    Console.WriteLine("It's a portrait.");
            //}

            //// #4: Speed limit question.

            //int speedLimit = 60;
            //int speedCar = 80;

            //if (speedCar <= speedLimit)
            //{
            //    Console.WriteLine("OK");
            //}
            //else
            //{
            //    int demeritPoints;
            //    demeritPoints = (speedCar - speedLimit) / 5;

            //    if (demeritPoints > 12)
            //    {
            //        Console.WriteLine("you're suspended.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("you have {0} demerit points", demeritPoints);
            //    }
            //}

            //Console.Write("Tell me a number.");
            //Int32 newNum1 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine(newNum1);

            //// loop over an enumerable
            //string testStr = "The sun also rises.";
            //foreach (var i in testStr){
            //    Console.WriteLine("i: " + i);
            //}


            //// loop through name until nothing entered
            //while (true)
            //{
            //    Console.Write("What's your name?");
            //    string name = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(name)){
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your name is {0}.", name);
            //        continue;
            //    }
            //}

            var random = new Random();
            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(1, 100));
            //}

            //create a password using Random()

            const int pwLength = 10;
            char[] pwArr = new char[pwLength];
            for (int i = 0; i < pwLength; i++)
            {
                // cast to character
                pwArr[i] = (char)(97 + random.Next(0, 26));
            }
            // build pwArr into string
            string password = new String(pwArr);
            //Console.WriteLine(pwArr);

            //LoopExercises.Exercise1();
            //LoopExercises.Exercise2();
            //LoopExercises.Exercise3();
            //LoopExercises.Exercise4();
            //LoopExercises.Exercise5();

            //ListExercises.Exercise1();
            //ListExercises.Exercise2();
            //ListExercises.Exercise3();
            //ListExercises.Exercise4();
            //ListExercises.Exercise5();

            //// datetimes
            //var dateTime = new DateTime(1999, 8, 30);
            //Console.WriteLine(dateTime.ToString());
            //var now = DateTime.Now;
            //var today = DateTime.Today;
            //Console.WriteLine("Today: " + today);
            //var max = DateTime.MaxValue;
            //var min = DateTime.MinValue;
            //Console.WriteLine("Date Min {0} - Max {1}", min, max);

            //// time spans
            //var span = new TimeSpan(3, 3, 3);
            //Console.WriteLine(span);
            //var fiveHours = TimeSpan.FromHours(5);
            //Console.WriteLine(fiveHours);

            //var myName = "Mike";
            //myName = myName.ToUpper();
            //Console.WriteLine(myName);
            //myName.Replace("M", "t");
            //Console.WriteLine(myName);
            //Console.WriteLine(char.MaxValue + " " + char.MinValue);
            ////split string by space by finding indexof and substring(); and split
            //var fullName = "Mike Pettman";
            //int index = fullName.IndexOf(' ');
            //string first = fullName.Substring(0, index);
            //int lastLength = fullName.Length - first.Length - 1;
            //string last = fullName.Substring(index + 1, lastLength);
            //Console.WriteLine(first);
            //Console.WriteLine(last);
            //string[] nameArr = fullName.Split(' ');
            //Console.WriteLine("Name: " + nameArr[0] + " " + nameArr[1]);

            //var ex1Result = TextExercises.Exercise1();
            //Console.WriteLine(ex1Result);
            //TextExercises.Exercise2();
            TextExercises.Exercise3();
            

        } // end Main method

        
    } // end program class

    public class LoopExercises
    {
        public static void Exercise1()
        {
            //1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
            for (var i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine();
        }
        public static void Exercise2()
        {
            //2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
            int num = 0;
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                var inputString = Console.ReadLine();
                if (inputString == "ok")
                {
                    Console.WriteLine(num);
                    break;
                }
                else
                {
                    num += System.Convert.ToInt32(inputString);
                    continue;
                }
            }
        }
        public static void Exercise3()
        {
            //3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            Console.WriteLine("Give me a number");
            string input = Console.ReadLine();
            int inputInt = System.Convert.ToInt32(input);
            int total = 1;
            for (var i = inputInt; i > 0; i--)
            {
                total *= inputInt;
                inputInt -= 1;
            }
            Console.WriteLine("Factorial is {0}.", total);
        }
        public static void Exercise4()
        {
            //4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
            // determine random number
            var randomInstance = new Random();
            int magicNum = randomInstance.Next(1, 10);
            string magicNumStr = magicNum.ToString();
            Console.WriteLine("Magic number is... " + magicNum);
            // user can guess 4 times
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess what the magic number is!");
                string inputStr = Console.ReadLine();
                // compare to magicNum
                if (inputStr == magicNumStr)
                {
                    Console.WriteLine("you win!");
                    break;
                }
                else
                {
                    Console.WriteLine("Guess again...");
                    continue;
                }
            }
        }
        public static void Exercise5()
        {
            //5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            // ask for numbers in string format
            Console.WriteLine("Give me a series of numbers separated by a comma (no space!).");
            string seriesInput = Console.ReadLine();
            // separate string by comma into array elements
            char[] separatedStrings = new char[] { ',' };
            string[] result;
            result = seriesInput.Split(separatedStrings, StringSplitOptions.None);
            int[] resultInt = new int[result.Length];
            // convert each array element to int
            for (var i = 0; i < result.Length; i++)
            {
                resultInt[i] = System.Convert.ToInt32(result[i]);
            }
            // sort array and display
            Array.Sort(resultInt);
            for (var i = 0; i < resultInt.Length; i++)
            {
                Console.Write(resultInt[i]);
                Console.Write(",");
            }
            Console.WriteLine();
            // display final element
            Console.WriteLine("The largest number you entered is: " + resultInt[resultInt.Length - 1]);
        }
    }

    public class ListExercises
    {
        public static void Exercise1()
        {
            //#1: Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
            //declare list
            List<string> friends = new List<string>();
            // while loop. Add names to list.
            while (true)
            {
                Console.WriteLine("Enter a name");
                string newFriend = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(newFriend))
                    break;
                // add to list
                friends.Add(newFriend);
            }
            // if else statements for list count
            if (friends.Count == 1)
                Console.WriteLine(friends[0] + " likes your post.");
            else if (friends.Count == 2)
                Console.WriteLine(friends[0] + " and " + friends[1] + " like your post.");
            else if (friends.Count > 2)
                Console.WriteLine(friends[0] + ", " + friends[1] + " and " + (friends.Count - 2) + " others like your post.");
            else
                Console.WriteLine("No one has liked yet.");
        }
        public static void Exercise2()
        {
            //2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
            // cw and cr save name
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            // declare array of length equal to name length
            char[] nameArr = new char[name.Length];
            // save letters as array
            for (var i = 0; i < nameArr.Length; i++)
            {
                nameArr[i] = name[i];
            }
            // use reverse method on array
            Array.Reverse(nameArr);
            // store as string and cw
            string reversedName = String.Join("", nameArr);
            Console.WriteLine(reversedName);
        }
        public static void Exercise3()
        {
            //3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
            // declare list
            var numList = new List<string>();
            int count = 0;
            //ask for numbers
            while (count < 5)
            {
                Console.WriteLine("Give me number");
                var newNum = Console.ReadLine();
                if (numList.Contains(newNum))
                {
                    // throw error and retry
                    Console.WriteLine("Try a DIFFERENT number.");
                    continue;
                }
                else
                {
                    // add to list and increase count
                    numList.Add(newNum);
                    count++;
                }
            }
            Console.WriteLine("Congratulations!");
            numList.Sort();
            foreach (var number in numList)
            {
                Console.WriteLine(number);
            }
        }
        public static void Exercise4()
        {
            //4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
            // declare a list
            var numList = new List<string>();
            //while loop to run continuously
            while (true)
            {
                // ask for numbers and push to numList
                Console.WriteLine("Enter a number, or type quit.");
                string input = Console.ReadLine();
                // if statement to exit loop
                if (input.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    numList.Add(input);
                }
            }
            // display numbers
            Console.WriteLine("all numbers entered");
            foreach (var number in numList)
            {
                Console.WriteLine(number);
            }
            // display UNIQUE numbers
            var uniqueList = new List<string>();
            foreach (var number in numList)
            {
                if (uniqueList.Contains(number))
                {
                    continue;
                }
                else
                {
                    uniqueList.Add(number);
                }
            }
            Console.WriteLine("all UNIQUE numbers entered");
            foreach (var number in uniqueList)
            {
                Console.WriteLine(number);
            }
        }

        public static void Exercise5()
        {
            //5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
            // declare list<int>
            var numList = new List<int>();
            // start while true loop for try again feature
            Console.WriteLine("Give me 5 numbers separated with a comma");
            while (true)
            {
                string inputStr = Console.ReadLine();
                // if null, cw "try again" and continue
                if (System.String.IsNullOrWhiteSpace(inputStr))
                {
                    Console.WriteLine("Try again");
                    continue;
                }
                // else: separate string, int32 convert and add to list
                else
                {
                    String[] subStrings = inputStr.Split(',');
                    foreach (var subString in subStrings)
                    {
                        var subInt = System.Convert.ToInt32(subString);
                        numList.Add(subInt);
                    }
                    // if list .count = < 5, cw "try again" and continue; else break
                    if (numList.Count < 5)
                    {
                        Console.WriteLine("Try again");
                        continue;
                    }
                    break;
                }
            }
            numList.Sort();
            Console.WriteLine("The lowest three numbers are {0}, {1}, and {2}.", numList[0], numList[1], numList[2]);
        }    
        
    }
}
