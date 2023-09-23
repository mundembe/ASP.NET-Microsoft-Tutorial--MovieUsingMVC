using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller 
{
    //GET: /HelloWorld/
    public IActionResult Index(){
        return View();
    }

    // GET: /HelloWorld/Welcome
    public String Welcome(){
        return "this is the welcome page.";
    }

    public IActionResult Greeting(String name, int numTimes=1){
        @ViewData["Message"] = "Greeting " + name;
        @ViewData["NumTimes"] = numTimes;
        return View();
    }

    public String GetFreinds(Boolean hasFreinds, int ID){
        if (!hasFreinds)
        {
            ID = -1;
        }
        return HtmlEncoder.Default.Encode($"Your Number of freinds is: {ID}");
    }

}