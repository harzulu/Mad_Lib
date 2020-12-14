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
      WordVariable myXmasWordVariable = new WordVariable();
      myXmasWordVariable.Animal = animal;
      myXmasWordVariable.Holiday = holiday;
      myXmasWordVariable.Name = name;
      myXmasWordVariable.PastVerb = pastVerb;
      myXmasWordVariable.Clothing = clothing;
      myXmasWordVariable.Season = season;
      myXmasWordVariable.Noise = noise;
      myXmasWordVariable.Objects = objects;
      myXmasWordVariable.Number = number;
      myXmasWordVariable.Noun = noun;
      myXmasWordVariable.Fast = fast;
      return View(myXmasWordVariable);
    }

    [Route("/gett-form")]
    public ActionResult GettForm() { return View(); }

    [Route("/gett-final")]
    public ActionResult GettFinal(string number) 
    {
    WordVariable myGettWordVariable = new WordVariable();
    myGettWordVariable.Number = number;
    return View(myGettWordVariable);
    }

  }
}