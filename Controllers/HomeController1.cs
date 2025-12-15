using Microsoft.AspNetCore.Mvc;

namespace Asandului_Oana_Maria_Lab1.Controllers
{
    public class HomeController1 : Controller
    {
        public string Index()
        {
            return "Bun venit";
        }

        public string Salut()
        {
            return "Salut!";
        }

        public string Index(string nume, int varsta)
        {

            return "Salut " + nume + ", ai varsta de " + varsta + " ani.";
        }
    }
}
