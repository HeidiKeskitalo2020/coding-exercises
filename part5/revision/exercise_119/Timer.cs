using System;
namespace exercise_119
{
    public class Timer
    {
        private ClockHand hundred;
        private ClockHand seconds;
        public Timer()
        {
            this.hundred = new ClockHand(100);
            this.seconds = new ClockHand(60);
        }
        public override string ToString()
        {
            return this.seconds + ":" + this.hundred;
        }
        public void Advance()
        {
            this.hundred.Advance();
            if (this.hundred.value == 0)
            {
                this.seconds.Advance();
            }
        }

    }
}