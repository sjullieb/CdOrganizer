using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CdOrganizer.Controllers;
using CdOrganizer.Models;

namespace CdOrganizer.Tests
{
    [TestClass]
    public class CdsControllerTest
    {
      [TestMethod]
      public void Create_ReturnsCorrectActionType_RedirectToActionResuult()
      {
        CdsController controller = new CdsController();
        IActionResult view = controller.Create("Title goes here");
        Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
      }
      [TestMethod]
      public void Create_RedirectsToCorrectAction_Index()
      {
        CdsController controller = new CdsController();
        RedirectToActionResult actionResult = controller.Create("Title goes here") as RedirectToActionResult;
        string result = actionResult.ActionName;
        Assert.AreEqual(result, "Index");
      }
    }
}
