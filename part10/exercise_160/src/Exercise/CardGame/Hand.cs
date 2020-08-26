namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Hand : IComparable<Hand>
  {
    private List<Card> hand;

     public Hand()
    {
      this.hand = new List<Card>();
    }

    public void Add(Card card)
    {
      if (!this.hand.Contains(card))
      {
        this.hand.Add(card);      
      }
    }

    public void Print()
    {
      hand.ForEach(Console.WriteLine);
    }

    public void Sort()
    {
      this.hand.Sort();
    }


    public int CompareTo(Hand hand)
    {
      int handSum1 = 0;
      foreach (Card card in this.hand)
      {
        handSum1 += card.value;
      }

      int handSum2 = 0;
      foreach (Card card in hand.hand)
      {
        handSum2 += card.value;
      }

      
      if (handSum1 == handSum2)
      {
        return 0;
      }
      else if (handSum1 > handSum2)
      {
        return 1;
      }
      else
      {
        return -1;
      }
    }
  }
}