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
        Leet loadLeet = new Leet();
        return View["index.cshtml", loadLeet];
      };
    }
  }
}
