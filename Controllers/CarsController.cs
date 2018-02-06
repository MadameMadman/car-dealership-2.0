using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Cars.Models;

namespace Project.Controllers
{
    public class CarsController : Controller
    {

        [Route("/")]
        public ActionResult Form()
        {
          System.Console.WriteLine("here");
            return View();
        }

        [HttpPost("/list/clear")]
        public ActionResult Clear()
        {
            Car.Clear();
            return View();
        }

        [Route("/list")]
        public ActionResult List()
        {
        Car newCar = new Car(
            Request.Form["description"],
            Request.Form["model"],
            Convert.ToInt32(Request.Form["cost"]),
            Convert.ToInt32(Request.Form["miles"])

        );
        newCar.Save();
        List<Car> allCars = Car.GetAll();
            return View(allCars);
          }

        // [Route("/greeting_card")]
        // public ActionResult GreetingCard()
        // {
        //     LetterVariable myLetterVariable = new LetterVariable();
        //     myLetterVariable.SetRecipient(Request.Query["recipient"]);
        //     myLetterVariable.SetSender(Request.Query["sender"]);
        //     return View("Letter", myLetterVariable);
        // }
    }
}
