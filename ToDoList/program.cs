using System.Collections.Generic;
using System;
using ToDoList.Models;
namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string userInput= Console.ReadLine();
      if (userInput== "add" || userInput== "Add")
      {
        Console.WriteLine("Please enter the description for the new item. ");
        userInput= Console.ReadLine();
        Item newItem = new Item (userInput);
        Main();
      }
      else if (userInput=="view" || userInput== "View")
      {
        List<Item> itemList= Item.GetAll();
        if (itemList.Count<1)
        {
        Console.WriteLine("No Item in the list");
        }
        else
        {
          for (int i=0; i<itemList.Count; i++)
          {
            Console.WriteLine((i+1) + " "+  itemList[i].Description);
          }
        }
        Main();
      }
      else
      {
      Console.WriteLine("Kindly enter a valid options");
      Main();
      }
    }
  }
}
