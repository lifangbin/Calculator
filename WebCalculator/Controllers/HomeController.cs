using System.Web.Mvc;
using Calculator;
using System;

namespace WebCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string expression)
        {
            if (!string.IsNullOrEmpty(expression))
            {
                Calculator.Calculator cal = new Calculator.Calculator(expression)
                {
                    Mode = CalculatorMode.Mathematics
                };
                ViewBag.Expression = expression;
                try
                {
                    ViewBag.Expression = cal.Calculate().ToString();

                }
                catch (Exception ex)
                {
                    ViewBag.Expression = ex.Message;
                }
            }
            return this.View();
        }

    }
}