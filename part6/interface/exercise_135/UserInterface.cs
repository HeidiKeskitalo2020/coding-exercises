using System;
namespace exercise_135
{
  public class UserInterface
  {
    private JokeManager manager;
    public UserInterface(JokeManager manager)
    {
        this.manager = manager;
    }

    public void Start()
    {
        //List<string> jokes = new List<string>();
        //Console.WriteLine("What a joke!");

        while (true)
        {
            Console.WriteLine("Commands:");
            Console.WriteLine(" 1 - add a joke");
            Console.WriteLine(" 2 - draw a joke");
            Console.WriteLine(" 3 - list jokes");
            Console.WriteLine(" X - stop");

            string command = Console.ReadLine();

            if (command == "X" || command == "x")
            {
                break;
                //return;
            }
            /*int score = Convert.ToInt32(command);
            if (score < 3 || score > 0) 
            {
                continue;
            }*/

            if (command == "1")
            {
                Console.WriteLine("Write the joke to be added:");
                string joke = Console.ReadLine();
                manager.AddJoke(joke);
            }
            if (command == "2")
            {
                Console.WriteLine("Drawing a joke.");
                string joke = manager.DrawJoke();
                Console.WriteLine(joke);
            }
            if (command == "3")
            {   
                Console.WriteLine("Printing the jokes.");
                manager.PrintJokes();
            } 
        }
    }  
  }
} 
  

