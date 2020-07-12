using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            //List<string> string = new List<string>();
           int count = 0;
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end") 
                {
                    break;
                }
                count++;
                //int number = Convert.ToInt32(line);
                //string[] strings = new string[number];
               
            }
            Console.WriteLine(count);
        }
    }
}
