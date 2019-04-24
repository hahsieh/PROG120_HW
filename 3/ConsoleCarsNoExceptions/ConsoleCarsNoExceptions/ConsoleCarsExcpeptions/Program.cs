/*********************************************************************
 * Course: PROG 120
 * Programmer: Kurt Friedrich, Hui-An Hsieh
 * Assigned Homework Number: HW3
 * Date Submitted: 4/21/2019
 * Purpose: modify the UI code in this program.cs to surround certain operations with try-catch structures, 
 * and then catch any exceptions thrown by the Car object
 ***************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleCarsExcpeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(35);  // call constructor and set speed max to 35 (tiny engine!!)
            string ErrorMessage = "All is well";

            bool done = false; // loop control variable
            while (!done)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("start = start engine, stop = stop engine");
                Console.Write("accel = accelerate, brake = brake, q = quit. Command? :");
                Console.ResetColor();
                string userInput = Console.ReadLine();
                userInput = userInput.ToLower();  // in case user happened to enter capital letters
                Console.Clear();  // each time we get a new command, clear the prior history from the console
                switch (userInput)
                {
                    case "start":
                        try
                        {
                            myCar.StartEngine();
                        }
                        catch (ApplicationException e)
                        {
                            ErrorMessage = e.Message;
                        }
                        break;
                    case "stop":
                        try
                        {
                            myCar.StopEngine();
                        }
                        catch (ApplicationException e)
                        {
                            ErrorMessage = e.Message;
                        }
                        break;
                    case "accel":
                        try
                        {
                            myCar.Accelerate();
                        }
                        catch (ApplicationException e)
                        {
                            ErrorMessage = e.Message;
                        }
                        break;
                    case "brake":
                        myCar.Decelerate();
                        break;
                    case "q":
                    case "e":
                        Console.WriteLine("Goodbye");
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Not a valid input.");
                        break;
                }
                // at the end of each command, call this method to show status
                DisplayCarState(ErrorMessage, myCar);
                ErrorMessage = "All is well";
            }
            Console.ReadLine();

        }

        private static void DisplayCarState(string msg, Car myCar)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(msg);
            Console.WriteLine("Engine is running: " + myCar.EngineRunning);
            Console.WriteLine("Current speed is: " + myCar.CurrentSpeedMPH);
            Console.ResetColor();
        }
    }
}
