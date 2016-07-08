using System;
using Nancy;

namespace WordFrequency
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/result"] = _ => {
        string searchTerm = Request.Form["searchTerm"];
        string sentence = Request.Form["sentence"];
        int count = RepeatCounter.CountRepeats(searchTerm, sentence);
        string[] info = {searchTerm, sentence, count.ToString()};
        return View["result.cshtml", info];
      };
    }
  }
}
