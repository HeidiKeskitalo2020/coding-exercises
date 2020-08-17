using System.Collections.Generic;

namespace Exercise
{
  public class Abbreviations
  {
    private Dictionary<string, string> dictionary;
    public Abbreviations()
    {
       this.dictionary = new Dictionary<string, string>();
    }
    public void AddAbbreviation(string abbreviation, string explanation)
    {
      //this.abbreviation = abbreviation;
      //this.explanation = explanation;

     
      this.dictionary.Add(abbreviation, explanation);

    }

    public bool HasAbbreviation(string abbreviation)
    {
      if (this.dictionary.ContainsKey(abbreviation))
      {
        return true;
      }
      else
      {
        return false;
      }
      
    }

    public string FindExplanationFor(string abbreviation)
    {
      if (HasAbbreviation(abbreviation))
      {
        return this.dictionary[abbreviation];
      }
      return "not found";
    }
  }
}
