using System.Collections.Generic;

namespace CdOrganizer.Models
{
  public class Artist
  {
    private string Name;
    private int Id;
    private static int CurrentId = 0;
    private static List<Artist> Instances = new List<Artist> {};
    private List<Cd> Cds;

    public Artist (string name)
    {
      Name = name;
      Cds = new List<Cd>{};
      Instances.Add(this);
      CurrentId++;
      Id = CurrentId;
    }

    public string GetName()
    {
      return Name;
    }

    public void SetName(string newName)
    {
      Name = newName;
    }

    public int GetId()
    {
      return Id;
    }

    public static List<Artist> GetAll()
    {
      return Instances;
    }

    public static void ClearAll()
    {
      Instances.Clear();
    }

    public static Artist Find(int id)
    {
      foreach(Artist oneArtist in Instances)
        if(oneArtist.Id == id)
          return oneArtist;

      return null;
    }

    public static void Delete(int id)
    {
      Artist oneArtist = Find(id);
      Instances.Remove(oneArtist);
    }

    public List<Cd> GetCds()
    {
      return Cds;
    }

    public void AddCd(Cd oneCd)
    {
      Cds.Add(oneCd);
    }
  }
}
