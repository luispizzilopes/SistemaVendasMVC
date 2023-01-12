using Microsoft.AspNetCore.Mvc;
using Sistema_Vendas.Models;

namespace Sistema_Vendas.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento{Id = 1, Nome = "Eletronicos"});
            list.Add(new Departamento { Id = 2, Nome = "Moda" }); 

            return View(list);
        }
    }
}
