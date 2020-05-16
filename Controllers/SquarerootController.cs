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
//No commenting please. I had an abusive relationship with this piece of program so no chitchat.

        [HttpPost]
        public IActionResult GetSqrt(double FirstNumber, double SecondNumber)
        {
            double firstNumber =  FirstNumber;
            double secondNumber = SecondNumber;

            double SqrtFirstNumber = Math.Sqrt(FirstNumber);
            double SqrtSecondNumber = Math.Sqrt(SecondNumber);

            ViewBag.FirstNumber =  FirstNumber;
            ViewBag.SecondNumber = SecondNumber;                   
            ViewBag.SqrtFirstNumber = SqrtFirstNumber;
            ViewBag.SqrtSecondNumber = SqrtSecondNumber;


     

            return View();
        }
    }
}