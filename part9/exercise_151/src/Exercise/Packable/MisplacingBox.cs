namespace Exercise
{
  using System.Collections.Generic;
  public class MisplacingBox : Box
  {
    public List<Item> list;
    public MisplacingBox()
    {
       this.list = new List <Item>();
    }

    public override void Add(Item item)
    {
       //if (list.Count == 0)
      {
        list.Add(item);
      }
    }


    public override bool IsInBox(Item item)
    {
      /*if (list.Contains(item))
      {
        return false;
      }
      else*/
      {
        return false;
      }
    }
  }
}