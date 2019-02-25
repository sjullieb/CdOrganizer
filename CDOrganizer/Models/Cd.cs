using System.Collections.Generic;

namespace CdOrganizer.Models
{
  public class Cd
  {
    private string Title;
    private static List<Cd> Instances = new List<Cd> {};

    public Cd (string title)
    {
      Title = title;
      Instances.Add(this);
    }

    public string GetTitle()
    {
      return Title;
    }

    public void SetTitle(string newTitle)
    {
      Title = newTitle;
    }

    public static List<Cd> GetAll()
    {
      return Instances;
    }

    public static void ClearAll()
    {
      Instances.Clear();
    }
  }
}
