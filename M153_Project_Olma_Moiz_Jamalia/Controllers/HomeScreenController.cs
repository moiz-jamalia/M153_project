using M153_Project_Olma_Moiz_Jamalia.Data;
using M153_Project_Olma_Moiz_Jamalia.Models;
using Microsoft.AspNetCore.Mvc;


namespace M153_Project_Olma_Moiz_Jamalia.Controllers
{
   public class HomeScreenController : Controller
    {
        private readonly AppDbContext context;
        public HomeScreenController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Home()
        {
            return View();
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUser(User user, string imageData)
        {
            if (!ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(imageData)) user.Image = Convert.FromBase64String(imageData.Split(",")[1]);
                
                context.UserStores.Add(user);
                context.SaveChanges();

                Console.WriteLine("Success");
                return RedirectToAction("Home");
            }

            Console.WriteLine("Failed");
            return View("Home", user);
        }
    }
}