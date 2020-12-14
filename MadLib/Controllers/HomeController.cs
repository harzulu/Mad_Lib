using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")] // homepage
    public ActionResult Start() { return View(); }

    [Route("/xmas-form")]
    public ActionResult XmasForm() { return View(); }

    [Route("/xmas-final")] // must match form action in .cshtml
    public ActionResult XmasFinal(string animal, string holiday, string name, string pastVerb, string clothing, string season, string noise, string objects, string number, string noun, string fast)
    {
      WordVariable myWordVariable = new WordVariable();
      myWordVariable.Animal = animal;
      myWordVariable.Holiday = holiday;
      myWordVariable.Name = name;
      myWordVariable.PastVerb = pastVerb;
      myWordVariable.Clothing = clothing;
      myWordVariable.Season = season;
      myWordVariable.Noise = noise;
      myWordVariable.Objects = objects;
      myWordVariable.Number = number;
      myWordVariable.Noun = noun;
      myWordVariable.Fast = fast;
      return View(myWordVariable);
    }
  }
}