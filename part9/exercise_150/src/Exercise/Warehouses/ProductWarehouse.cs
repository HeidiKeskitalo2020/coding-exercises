namespace Exercise
{
  public class ProductWarehouse : Warehouse
  {

    public string productName;

    public ProductWarehouse(string productName, int capacity) : base(capacity)
    {
      this.productName = productName;
    }

    public override string ToString()
    {
      return this.productName + ": " + base.ToString(); //": balance: " + this.balance + ", " + "space left " +  ;
    }
  }
}
