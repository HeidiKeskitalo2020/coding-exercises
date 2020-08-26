namespace Exercise
{
  using System.Text.RegularExpressions;
  public class Checker
  {
    public string str;
    public bool DayOfWeek(string str)
    {
      this.str = str;

      Regex regex = new Regex("^mon$|^tue$|^wed$|^thu$|^fri$|^sat$|^sun$");
      if (regex.IsMatch(str))
      {
        return true;
      }
      else 
      {
        return false;
      }
      
    }

    public bool AllVowels(string str)
    {
      this.str = str;

      Regex regex = new Regex("^(a|e|i|o|u)*$");
      if (regex.IsMatch(str))
      {
        return true;
      }
      else 
      {
        return false;
      }
    }

    public bool TimeOfDay(string str)
    {
      Regex regex = new Regex("(([0-1][0-9])|([2][0-3])):([0-5][0-9]):([0-5][0-9])");
      if (regex.IsMatch(str))
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