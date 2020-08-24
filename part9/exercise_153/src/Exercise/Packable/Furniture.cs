namespace Exercise
{
  public class Furniture : IPackable
  {
    public string s;
    public string s2;
    public int i;
    

    public Furniture(string s, string s2, int i)
    {
      this.s = s;
      this.s2 = s2;
      this.i = i;
      //this.weight = weight;

    }

    public int Weight()
    {
      return this.i;
    }

    public override string ToString()
    {
      return this.s2 + " " + this.s + " - weight " + this.i + " kg";
    }
  }
}