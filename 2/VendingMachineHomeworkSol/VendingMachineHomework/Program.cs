/*********************************************************************
 * Course: PROG 120
 * Programmer: Hui-An Hsieh
 * Assigned Homework Number: HW-2
 * Date Submitted: <current date>
 * Purpose: Write a program that a user can enter one of several commands and then do the appropriate actions 
 * by making calls to the VendingMachine object created. 
 ***************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineClassLibrary;

namespace VendingMachineHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object
            VendingMachine myVendingMachine = new VendingMachine();

            // define one variable to store the user's answer 
            // and the other one to keep track of how many times the user has put money in
            string answer;
            int howmany = 0;

            // ask a user to enter one of several commands 
            // P to pay a dollar, B to buy a Coke, R  refund to get all their money back, or Q to quit the program.  
            do
            {
                Console.WriteLine("Please type P to insert a dollar, \nor B to buy a Coke, \nor R to get all your money back, \nor Q to quit this program.");
                Console.WriteLine();
                answer = Console.ReadLine().ToUpper();
                switch (answer)
                {
                    case "P":
                        myVendingMachine.AcceptCash();
                        howmany++;
                        Console.WriteLine("Thank you, you now have " + string.Format("{0:c}", myVendingMachine.MoneyBalance));
                        break;
                    case "B":
                        int returnValue = myVendingMachine.BuyCoke();
                        switch (returnValue)
                        {
                            case 0:
                                Console.WriteLine("Thank you for your purchase, you have {0:c} left.", myVendingMachine.MoneyBalance);
                                break;
                            case 1:
                                Console.WriteLine("Sorry, the machine is empty, enter an R to get your money back.");
                                break;
                            case 2:
                                if (howmany == 0)
                                {
                                    Console.WriteLine("Sorry, you need to insert a dollar.");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, you have to insert more money.");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Sorry, the machine is empty, and you have no money left in the machine.");
                                break;
                        }
                        break;
                    case "R":
                        int refund = myVendingMachine.GiveRefund();
                        Console.WriteLine("Here is your {0:c}", refund);
                        break;
                    case "Q":
                        if (myVendingMachine.MoneyBalance != 0)
                        {
                            int refundWithouturchase = myVendingMachine.GiveRefund();
                            Console.WriteLine("Here is your {0:c}", refundWithouturchase);
                        }
                        Console.WriteLine("Thank you, have a nice day.");
                        break;
                }

                Console.WriteLine();

            } while (answer != "Q");

            Console.ReadLine();
        }
    }
}
