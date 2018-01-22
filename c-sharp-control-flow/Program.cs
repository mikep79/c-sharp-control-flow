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
            //else if statements:
            string timeOfDay = "afternoon";
            if (timeOfDay == "afternoon")
                Console.WriteLine("Good afternoon!");
            else if (timeOfDay == "morning")
                Console.WriteLine("Good morning!");
            else
                Console.WriteLine("good evening!");

            //switch version:
            switch (timeOfDay)
            {
                case "morning":
                    Console.WriteLine("Good morning!");
                    break;
                case "afternoon":
                    Console.WriteLine("Good afternoon!");
                    break;
                default:
                    Console.WriteLine("good evening!");
                    break;
            }

            var color = CarColor.Blue;

            switch (color)
            {
                case CarColor.Red:
                    Console.WriteLine("your car is red");
                    break;
                case CarColor.Blue:
                    Console.WriteLine("your car is blue");
                    break;
                case CarColor.Black:
                default:
                    Console.WriteLine("I don't know your color...");
                    break;
            }

            // #1: Write a program that checks whether a number is between 1-10.

            int inputNum;
            inputNum = -5;

            if (inputNum >= 1 && inputNum <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        
            // #2: Write a program that displays the higher of two numbers.

            int firstNum = 12;
            int secondNum = 10;

            if (firstNum > secondNum)
            {
                Console.WriteLine("{0} is greater than {1}.", firstNum, secondNum);
            }
            else if (secondNum > firstNum)
            {
                Console.WriteLine("{0} is greater than {1}.", secondNum, firstNum);
            }
            else
            {
                Console.WriteLine("They're equal!");
            }
            
            // #3: Enter image width/height as array. Write program that determines portait or landscape.

            float[] widthHeight = new float[2];
            widthHeight[0] = 100.5f;
            widthHeight[1] = 200.9f;

            if (widthHeight[0] > widthHeight[1])
            {
                Console.WriteLine("It's a landscape");
            }
            else {
                Console.WriteLine("It's a portrait.");
            }
        
            // #4: Speed limit question.

            int speedLimit = 60;
            int speedCar = 80;

            if (speedCar <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int demeritPoints;
                demeritPoints = (speedCar - speedLimit) / 5;

                if (demeritPoints > 12)
                {
                    Console.WriteLine("you're suspended.");
                }
                else
                {
                    Console.WriteLine("you have {0} demerit points", demeritPoints);
                }
            }
        }
    }
}
