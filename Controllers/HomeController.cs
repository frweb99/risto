using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RCommerce.Models.InputModels;
using RCommerce.Models.Services.Application;
using RCommerce.Models.ViewModels;

namespace RCommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeServices services;

        public HomeController(IHomeServices services)
        {
            this.services = services;

        }

        //Recupero una lista di prodotti da poter mostrare nella vista
        public async Task<IActionResult> Index()
        {
            List<ProductViewModel> products = await services.getProductsAsync();
            return View(products);
        }

        //Recupero il singolo prodotto da mostrare nella vista Products
        public async Task<IActionResult> Product(int id)
        {

            ProductViewModel product = await services.getProductAsync(id);
            return View(product);

        }

        //Mostro la view di Login all'utentes
        public IActionResult Login(){
            return View();
        }
        //Catturo l'evento POST scatenato dall'utente e prelevo le informazioni del client
        [HttpPost]
        public IActionResult Login(LoginInputModel login){
            return Content($"Ho ricevuto i seguenti dati: Username:{login.Username} e Password: {login.Password}");
        }

    }
}