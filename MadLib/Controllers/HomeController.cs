using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/finalMadLib")] // must match form action
    public ActionResult Final(string animal)
    {
      WordVariable myWordVariable = new WordVariable();
      myWordVariable.Animal = animal;
      return View(myWordVariable);
    }
  }
}