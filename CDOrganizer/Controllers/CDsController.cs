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
    [HttpGet("/cds/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/cds")]
    public ActionResult Create(string title)
    {
      Cd myCd = new Cd(title);
      return RedirectToAction("Index");
    }
  }
}
