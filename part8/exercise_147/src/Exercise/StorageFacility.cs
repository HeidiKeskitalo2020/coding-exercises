using System.Collections.Generic;
using System;

namespace Exercise
{
  public class StorageFacility
  {
    private Dictionary<string, List<string>> StoraDictionary;
    public StorageFacility()
    {
      this.StoraDictionary = new Dictionary<string, List<string>>();
    }
    public void Add(string unit, string item)
    {
      if (!this.StoraDictionary.ContainsKey(unit))
      {
        this.StoraDictionary.Add(unit, new List<string>());
      }
      this.StoraDictionary[unit].Add(item);

    }

    public List<string> Contents(string storageUnit)
    {
      if (!this.StoraDictionary.ContainsKey(storageUnit))
      {
        this.StoraDictionary.Add(storageUnit, new List<string>());
      }
      return this.StoraDictionary[storageUnit];
    }

    public void Remove(string storageUnit, string item)
    {
      this.StoraDictionary[storageUnit].Remove(item);
      if (this.StoraDictionary[storageUnit].Count == 0)
      {
        this.StoraDictionary.Remove(storageUnit);
      }
    }

    public List<string> StorageUnits()
    {
      List<string> StorageUList = new List<string>();
      Dictionary<string, List <string>>.KeyCollection keyes = this.StoraDictionary.Keys;
      foreach (string StoraDictionary in keyes)
      {
        StorageUList.Add(StoraDictionary);
      }

      return StorageUList;
    }
  }
}
