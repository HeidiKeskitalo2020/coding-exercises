namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      Hand hand1 = new Hand();

      hand1.Add(new Card(2, Suit.Diamond));
      hand1.Add(new Card(14, Suit.Spade));
      hand1.Add(new Card(12, Suit.Heart));
      hand1.Add(new Card(2, Suit.Spade));

      Hand hand2 = new Hand();

      hand2.Add(new Card(11, Suit.Diamond));
      hand2.Add(new Card(11, Suit.Spade));
      hand2.Add(new Card(11, Suit.Heart));

      int comparison = hand1.CompareTo(hand2);

      if (comparison < 0)
      {
        Console.WriteLine("better hand is");
        hand2.Print();
      }
      else if (comparison > 0)
      {
        Console.WriteLine("better hand is");
        hand1.Print();
      }
      else
      {
        Console.WriteLine("hands are equal");
      }
      /*Card first = new Card(2, Suit.Diamond);
      Card second = new Card(14, Suit.Spade);
      Card third = new Card(12, Suit.Heart);
      Card fourth = new Card(2, Suit.Spade);
      //Card fifth = new Card(12, Suit.Diamond);*/
      /*Hand hand = new Hand();

      hand.Add(new Card(2, Suit.Diamond));
      hand.Add(new Card(14, Suit.Spade));
      hand.Add(new Card(12, Suit.Heart));
      hand.Add(new Card(2, Suit.Spade));

      hand.Sort();
      hand.Print();
      /*List<Card> list = new List<Card> { first, second, third, fourth, fifth };
      list.Sort();
      list.ForEach(Console.WriteLine);
      /*Console.WriteLine(first);
      Console.WriteLine(second);
      Console.WriteLine(third);*/
    }
  }
}
