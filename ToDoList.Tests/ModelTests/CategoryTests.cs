using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTest : IDisposable
  {
    public void Dispose()
    {
      Category.ClearAll();
    }
    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {
      Category newCategory = new Category("test category");
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Category";
      Category newCategory = new Category(name);

      string result = newCategory.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      string name = "Test Category";
      Category newCategory = new Category(name);

      int result = newCategory.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllCategoryObjects_CategoryList()
    {
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Category newCategory1 = new Category(description01);
      Category newCategory2 = new Category(description02);
      List<Category> newList = new List<Category> { newCategory1, newCategory2 };

      List<Category> result = Category.GetAll();

      CollectionAssert.AreEqual(newList, result);
      
    }
  }
}