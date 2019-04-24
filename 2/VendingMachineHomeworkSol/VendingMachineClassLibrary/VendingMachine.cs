/*********************************************************************
 * Course: PROG 120
 * Programmer: Hui-An Hsieh
 * Assigned Homework Number: HW-2
 * Date Submitted: <current date>
 * Purpose: Write the VendingMachine class which has 2 private class fiels, a constructor method, 2 public properties
 * and 3 methods.
 ***************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineClassLibrary
{
    public class VendingMachine
    {
        // 2 private class fields
        // one to keep track of how much money the user has put in
        // and one field to keep track of how many bottles are left.
        private int _MoneyBalance;
        private int _BottleCount;
        
        // a constructor method that starts the bottle count field at 5 bottles and sets the money balance field to zero.
        public VendingMachine()
        {
            _MoneyBalance = 0;
            _BottleCount = 5;
        }

        // 2 public properties
        // one should return the current number of bottles
        // the other should return the amount of cash the customer has put in.  
        public int BottleCount
        {
            get
            {
                return _BottleCount;
            }    
        }

        public int MoneyBalance
        {
            get
            {
                return _MoneyBalance;
            }
        }

        // 3 methods
        // this method should run through logic and dispense or not, reduce the balance and inventory if successful,  
        // and then return
        // 0 if it was a success
        // 1 if there are no more bottles left
        // 2 if the user’s balance is zero
        // 3 if there are no more bottles and the user’s balance is zero
        public int BuyCoke()
        {
            if (BottleCount == 0 && MoneyBalance != 0)
            {
                return 1;
            }
            else if (MoneyBalance == 0 && BottleCount != 0)
            {
                return 2;
            }
            else if (BottleCount == 0 && MoneyBalance == 0)
            {
                return 3;
            }
            else
            {
                _MoneyBalance--;
                _BottleCount--;
                return 0;
            }
        }

        // each time this is called, 1 dollar is added to the user’s balance. 
        public void AcceptCash()
        {
            _MoneyBalance++;
        }

        // this method should return the amount of money the user has not used as an int to the calling code (the Console App.), and also set the balance to zero, (pretending that the machine actually refunded the money). 
        public int GiveRefund()
        {
            if (MoneyBalance != 0)
            {
                int returnBalance = MoneyBalance;
                _MoneyBalance = 0;
                return returnBalance;
            }
            else
            {
                return 0;
            }
        }

    }
}
