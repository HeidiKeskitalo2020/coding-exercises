using System;

namespace exercise_121
{
    public class Fitbyte
    {
        private int age {get; set;}
        private int restingHeartRate {get; set;}
        private double target = 0;
        //private double percentageOfMaximum = 0;
    
        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;


        }
        public double TargetHeartRate(double percentageOfMaximum)
        {
            this.target = 206.3 - (0.711 * age);
            return (target - restingHeartRate) * percentageOfMaximum + restingHeartRate;
             
        }
    }
}