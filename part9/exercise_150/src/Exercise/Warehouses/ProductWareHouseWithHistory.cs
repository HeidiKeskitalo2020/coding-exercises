namespace Exercise
{
  public class ProductWarehouseWithHistory : ProductWarehouse
  {
    public int initialBalance;
    public ChangeHistory changes;
    public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance) : base(productName, capacity)
    {
      this.initialBalance = initialBalance;
      this.changes = new ChangeHistory();
      AddToWarehouse(initialBalance);
    }

    public string History()
    {
      return this.changes.ToString();
    }

    new public void AddToWarehouse(int amount)
    {
      base.AddToWarehouse(amount);
      this.changes.Add(this.balance);
      /*if (amount <= 0)
      {
        return;
      }
      if (amount <= HowMuchSpaceLeft())
      {
        this.balance = this.balance + this.changes;
      }
      else
      {
        this.balance = this.capacity;
      }*/
    }

    new public int TakeFromWarehouse(int amount)
    {
      base.TakeFromWarehouse(amount);
      this.changes.Add(this.balance);
      return this.balance;
    }
  }
}
