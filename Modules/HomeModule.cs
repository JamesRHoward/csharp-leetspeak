using Nancy;
using Leet.Objects;
using System.Collections.Generic;

namespace Leet
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
