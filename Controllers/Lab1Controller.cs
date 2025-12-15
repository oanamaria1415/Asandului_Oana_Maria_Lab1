using Microsoft.AspNetCore.Mvc;

namespace Asandului_Oana_Maria_Lab1.Controllers
{
    public class Lab1Controller : Controller
    {
        
        public string Index()
        {
            return "Bun venit";
        }

        public string Salut()
        {
            return "Salut!";
        }

        public string Index1(string nume, int varsta)
        {

            return $"Salut {nume}, ai varsta de {varsta} ani.";
        }
    }
}
