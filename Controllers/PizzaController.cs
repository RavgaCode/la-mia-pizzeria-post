using la_mia_pizzeria.Data;
using la_mia_pizzeria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace la_mia_pizzeria.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            PizzaDbContext db = new PizzaDbContext();

           List<Pizza> pizzaList = db.Pizzas.ToList();

            return View(pizzaList);
        }
        public IActionResult Details(int id)
        {

            PizzaDbContext db = new PizzaDbContext();

            Pizza singlePizza = db.Pizzas.Where(p => p.Id == id).FirstOrDefault();

            return View(singlePizza);
        }
    }
}
