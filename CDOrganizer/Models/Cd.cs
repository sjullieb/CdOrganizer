using System.Collections.Generic;

namespace CdOrganizer.Models
{
  public class Cd
  {
    private string Title;
    private int Id;
    private static int CurrentId = 0;
    private static List<Cd> Instances = new List<Cd> {};

    public Cd (string title)
    {
      Title = title;
      Instances.Add(this);
      CurrentId++;
      Id = CurrentId;
    }

    public string GetTitle()
    {
      return Title;
    }

    public void SetTitle(string newTitle)
    {
      Title = newTitle;
    }

    public int GetId()
    {
      return Id;
    }

    public static List<Cd> GetAll()
    {
      return Instances;
    }

    public static void ClearAll()
    {
      Instances.Clear();
    }

    public static Cd Find(int id)
    {
      foreach(Cd oneCd in Instances)
        if(oneCd.Id == id)
          return oneCd;

      return null;
    }

    public static void Delete(int id)
    {
      Cd oneCd = Find(id);
      Instances.Remove(oneCd);
    }
  }
}
