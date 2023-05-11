using M153_Project_Olma_Moiz_Jamalia.Data;
using M153_Project_Olma_Moiz_Jamalia.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace M153_Project_Olma_Moiz_Jamalia.Controllers
{
    public class HomeScreenController : Controller
    {
        private readonly IWebHostEnvironment env;
        private readonly AppDbContext context;
        public HomeScreenController(IWebHostEnvironment env, AppDbContext context)
        {
            this.env = env;
            this.context = context;
        }

        public IActionResult Home()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}