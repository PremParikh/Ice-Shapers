using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ice_Shapers.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

       // public string Index()
        //{
          //  return "This is my default action...";
        //}

        // 
        // GET: /HelloWorld/Welcome/ 

       // public string Welcome()
        //{
          //  return "Welcome to the ICE_Shapers...";
        //}

        public IActionResult Index()
        {
            return View();
        }
        //public string Welcome(string name, int numTimes = 1)
        //{
        //  return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}

        //public string Welcome(string name, int ID = 1)
        //{
        //  return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}