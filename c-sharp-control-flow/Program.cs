using System;
//using System.Collections.Generic;
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
            Console.WriteLine(pwArr);

            
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
    }
}
