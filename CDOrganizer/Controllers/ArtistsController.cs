using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;

namespace CdOrganizer.Controllers
{
  public class ArtistController : Controller
  {
    [HttpGet("/artists")]
    public ActionResult Index()
    {
      return View(Artist.GetAll());
    }

    [HttpGet("/artists/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/artists")]
    public ActionResult Create(string artistName)
    {
      Artist newArtist = new Artist(artistName);
      List<Artist> allArtists = Artist.GetAll();
      return View("Index", allArtists);
    }

    [HttpGet("/artists/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> dict = new Dictionary<string, object>();
      Artist selectedArtist = Artist.Find(id);
      List<Cd> artistCds = selectedArtist.GetCds();
      dict.Add("artist", selectedArtist);
      dict.Add("cds", artistCds);
      return View(dict);
    }


  }
}
