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
        }
        
        
    }
}
