using System.Xml.Xsl.Runtime;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System;
using Microsoft.AspNetCore.Mvc;

namespace squarerootWebApp.Controllers
{
    public class SquarerootController : Controller
    {
        [HttpGet]
        public IActionResult Squareroot()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Squareroot(string FirstNumber, string SecondNumber)
        {
            double NumberOne = Math.Sqrt(double.Parse(FirstNumber));
            double NumberTwo = Math.Sqrt(double.Parse(SecondNumber));
            


            ViewBag.First =  double.Parse(FirstNumber);
            ViewBag.Second = double.Parse(SecondNumber);                   
            //ViewBag.One = NumberOne;
            //ViewBag.Two = NumberTwo;    
            

        /*    if (NumberOne < 0)
            {
                
                       
                            Input positive numbers only.
            }
             break;

    
            if (NumberTwo < 0)
            {
               
                            Input positive numbers only.
                       
            }
            break;

    }*/

            return View();
        }
    }
}