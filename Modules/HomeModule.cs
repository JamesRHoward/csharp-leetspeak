using Nancy;
using LeetConverter.Objects;
using System.Collections.Generic;

namespace LeetConverter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        string loadLeet = "L33T 1S T3 R0XX0R :-(";
        return View["index.cshtml", loadLeet];
      };
      Post["/g3tL33t"] = _ => {
        string TheLeetOutput = new Leet().T0L33t(Request.Form["userPhrase"]);
        return View["index.cshtml", TheLeetOutput];
      };
    }
  }
}
