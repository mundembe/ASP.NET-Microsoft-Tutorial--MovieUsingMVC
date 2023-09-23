using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller 
{
    //GET: /HelloWorld/
    public String Index(){
        return "this is my default action.";
    }

    // GET: /HelloWorld/Welcome
    public String Welcome(){
        return "this is the welcome page.";
    }

    public String Greeting(String name="Stranger", int age=18){
        return HtmlEncoder.Default.Encode($"Hello {name}, your age is: {age}");
    }

    public String GetFreinds(Boolean hasFreinds, int ID){
        if (!hasFreinds)
        {
            ID = -1;
        }
        return HtmlEncoder.Default.Encode($"Your Number of freinds is: {ID}");
    }

}