using ClassLibraryCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI.Controllers;
using WebAppCalc1YoussefNAFAA.Models;


namespace WebAppCalc1YoussefNAFAA.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View(new Calculator());
        }

        [HttpPost]
        public ActionResult Index(Calculator calc, string calculate)
        {
            SimpleCalc simpleCalc = new SimpleCalc();

            if (calculate == "add" )
            {

                calc.total = simpleCalc.AddNumbers(calc.number1, calc.number2);
            }
            if (calculate == "substract")
            {

                calc.total = simpleCalc.SubstractNumbers(calc.number1, calc.number2);
            }
            if (calculate == "multiply")
            {
                calc.total = simpleCalc.MultiplyNumbers(calc.number1, calc.number2);
            }
            if (calculate == "divide")
            {
                if (calc.number2 == 0)
                {
                    calc.message = "Division By ZERO!!!!";
                }
                else
                {
                    calc.total = simpleCalc.DivideNumbers(calc.number1, calc.number2);

                }
            }

            return View(calc);
        }

    }
}