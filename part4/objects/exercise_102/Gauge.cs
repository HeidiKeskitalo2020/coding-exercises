using System;

namespace exercise_102
{
    public class Gauge
    {
        public int value {get; set;}
        public void Increase()
        {
            if (value < 5)
            {
                value = value + 1;
            }
        }
        public void Decrease()
        {
            if (value == 5)
            {
                value = value -1;
            }
        }
        public bool Full()
        {
            if (value == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}