/*********************************************************************
 * Course: PROG 120
 * Programmer: Kurt Friedrich, Hui-An Hsieh
 * Assigned Homework Number: HW3
 * Date Submitted: 4/21/2019
 * Purpose: add code in this car clas to detect 3 nonsensical situations (1: trying to accelerate when the engine 
 * is not running; 2: trying to start the engine when it is already started; 3: trying to stop the engine when 
 * it is already stopped) and throw exceptions when these occur
 ***************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Car
    {
        // fields
        private decimal _CurrentSpeedMPH; // the cars current speed
        private decimal _MaxSpeedMPH;  // the upper limit, the car cannot exceed this value
        private bool _EngineRunning;  // true means the engine has been started and is running, false says engine is off

        public Car(decimal maxSpeed) // constuctor, user chooses to set maxSpeed as they create the object
        {
            _MaxSpeedMPH = maxSpeed;
            _CurrentSpeedMPH = 0;
            _EngineRunning = false;
        }

      
        public bool EngineRunning   // Property to allow reading the current value
        {   get   {   return _EngineRunning;   }   }

        public decimal CurrentSpeedMPH    // Property to allow reading the current value
        {   get   {   return _CurrentSpeedMPH;   }   }
     

    
        public void StartEngine()  // method used to start car's engine
        {
            if (_EngineRunning == true)
            {
                throw new ApplicationException("Engine is already started.");
            }
            _EngineRunning = true;
        }

        public void StopEngine()    // method used to stop car's engine
        {
            if (_EngineRunning == false)
            {
                throw new ApplicationException("Engine is not running.");
            }
            _EngineRunning = false;
        }


        public void Accelerate()  // method used to increase the cars speed
        {
            if (_EngineRunning == false)
            {
                throw new ApplicationException("Please start engine.");
            }
            _CurrentSpeedMPH = _CurrentSpeedMPH + 10;  // this method always tries to increase by 10 mph
            if (_CurrentSpeedMPH > _MaxSpeedMPH)  // but it can never exceed the max speed as set in the constructor
            {
                _CurrentSpeedMPH = _MaxSpeedMPH;  // if speed is higher than max, slow it to max
            }
          }

        public void Decelerate()  // this method always tries to decrease the speed by 5 mph
        {
            _CurrentSpeedMPH = _CurrentSpeedMPH - 5;  // but never lets it go below 0 and become negative.
            if (_CurrentSpeedMPH < 0)
            {
                _CurrentSpeedMPH = 0;
            }
        }

       
    }
}
