using System;

namespace exercise_105
{
  public class Statistics
  {
    public int count { get; set; }
    public int sum { get; set; }

    public Statistics()
    {
      this.sum = 0;
      this.count = 0;
      //while(true)
      //int count = 0;
      // initialize the variables here
      //if (count == 0)
      //{
        //break;  
      //}
      //count = count++;      //count++;
    }

    public void AddNumber(int number)
    {
      //this.number = number;
      // write code here
      //this.number = number; 
      this.count++;
      this.sum = sum + number;
      
    }
  }
}
