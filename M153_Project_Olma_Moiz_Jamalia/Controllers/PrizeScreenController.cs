using M153_Project_Olma_Moiz_Jamalia.Data;
using Microsoft.AspNetCore.Mvc;

namespace M153_Project_Olma_Moiz_Jamalia.Controllers
{
    public class PrizeScreenController : Controller
    {
        private readonly AppDbContext context;

        public PrizeScreenController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult PrizeScreen()
        {
            return View();
        }

        public IActionResult PrizeScreenOverview()
        {
            var prizes = context.PrizeStores.ToList();
            return View(prizes);
        }
    }
}
