using la_mia_pizzeria.Models;
using la_mia_pizzeria.Utils;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Pizza> pizzaList = PizzaData.GetPizze();
            return View("LeNostrePizze", pizzaList);
        }
        [HttpGet]
        public IActionResult DettaglioPizza(int id)
        {
            Pizza pizzaTrovata = null;
            foreach(Pizza pizza in PizzaData.GetPizze())
            {
                if(pizza.Id == id)
                {
                    pizzaTrovata = pizza;
                    break;
                }
            }

            if (pizzaTrovata == null)
            {
                return View("Error");
            }
            return View(pizzaTrovata);
        }
    }
}
