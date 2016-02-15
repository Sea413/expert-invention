using Nancy;
using System.Collections.Generic;
using PingPongGen;

namespace PingPongGen
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      Get["/results"] = _ =>
      {
        return View["results.cshtml"];
      };
    }
  }
}
