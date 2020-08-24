namespace Exercise
{
  public class Book : IPackable
  {
    public string s;
    public string s2;
    public int i;
    public int weight;
    
    public Book(string s, string s2, int i)
    {
      this.s = s;
      this.s2 = s2;
      this.i = i;
      this.weight = 1;
    }

    public int Weight()
    {
      return this.weight;
    }

    public override string ToString()
    {
      return this.s + ": " + this.s2 + " (" + this.i + ")";
    }
  }
}