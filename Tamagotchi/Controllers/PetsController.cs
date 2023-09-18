using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;


namespace Tamagotchi.Controllers
{
  public class PetsController : Controller
  {

    [HttpGet("/pet/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/pet")]
    public ActionResult Create(string name, int foodStatus, int attentionStatus, int restStatus)
    {
      Pets newPet = new Pets(name, foodStatus, attentionStatus, restStatus);
      return RedirectToAction("Index");
    }

    [HttpGet("/pet")]
    public ActionResult Index()
    {
      Pets pet = Pets.GetInstance();
      if (pet == null)
      {
        return RedirectToAction("New");
      }
      return View(pet);
    }


    [HttpPost("/pet/food")]
    public ActionResult FeedPet()
    {
      Pets petFood = Pets.GetInstance();
      if (petFood != null)
      {
        petFood.FeedPet();
        return RedirectToAction("Index");
      }
      else
      {
        return RedirectToAction("NoPet");
      }
    }
    [HttpGet("/pet/food")]
    public ActionResult Food()
    {
      Pets petFood = Pets.GetInstance();
      if (petFood == null)
      {
        return RedirectToAction("Explanation");
      }
      return View("Food", petFood);
    }
  }
}
