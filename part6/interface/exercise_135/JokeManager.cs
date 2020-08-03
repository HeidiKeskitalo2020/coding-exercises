using System.Collections.Generic;
using System;

public class JokeManager
{
    List<string> jokes = new List<string>();
    
    public void AddJoke(string joke)
    {
        this.jokes.Add(joke);
    }
    public string DrawJoke()
    {
        

        if (this.jokes.Count == 0)
        {
            return "Jokes are in short supply.";
        }
        else
        {
            Random randomJoke = new Random();
            int index = randomJoke.Next(0, this.jokes.Count);
            return this.jokes[index];
        }
    }
    public void PrintJokes()
    {
        foreach (string joke in jokes)
        {
            Console.WriteLine(joke);
        }
    }
}