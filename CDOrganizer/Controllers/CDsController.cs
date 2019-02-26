using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;
using System.Collections.Generic;

namespace CdOrganizer.Controllers
{
  public class CdsController : Controller
  {
    [HttpGet("/cds")]
    public ActionResult Index()
    {
      return View(Cd.GetAll());
    }
    // [HttpGet("/cds/new")]
    // public ActionResult New()
    // {
    //   return View();
    // }
    [HttpPost("/cds")]
    public ActionResult Create(string title)
    {
      Cd myCd = new Cd(title);
      return RedirectToAction("Index");
    }
    [HttpPost("/cds/delete")]
    public ActionResult DeleteAll()
    {
      Cd.ClearAll();
      return RedirectToAction("Index");
    }

    // [HttpGet("/cds/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Cd oneCd = Cd.Find(id);
    //   return View(oneCd);
    // }

    [HttpPost("/cds/delete/{id}")]
    public ActionResult Delete(int id)
    {
      Cd.Delete(id);
      return RedirectToAction("Index");
    }

    [HttpGet("/cds/{id}/edit")]
    public ActionResult Edit(int id)
    {
      Cd oneCd = Cd.Find(id);
      return View(oneCd);
    }

    [HttpPost("/cds/{id}")]
    public ActionResult Update(int id, string title)
    {
      Cd oneCd = Cd.Find(id);
      oneCd.SetTitle(title);
      return RedirectToAction("Index");
    }

    [HttpGet("/artists/{artistId}/cds/{cdId}")]
    public ActionResult Show(int artistId, int cdId)
    {
      Cd oneCd = Cd.Find(cdId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist oneArtist = Artist.Find(artistId);
      model.Add("cd", oneCd);
      model.Add("artist", oneArtist);
      return View(model);
    }

    [HttpGet("/artists/{artistId}/cds/new")]
    public ActionResult New(int artistId)
    {
       Artist artist = Artist.Find(artistId);
       return View(artist);
    }
  }
}
