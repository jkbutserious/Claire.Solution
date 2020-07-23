using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    private static List<Category> _instances = new List<Category> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Item> Items { get; set; }
    public Category(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
      Items = new List<Item>{};
    }
  }
}