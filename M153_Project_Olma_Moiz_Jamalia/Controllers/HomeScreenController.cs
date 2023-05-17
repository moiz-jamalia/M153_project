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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CaptureImage(UserStore userStore)
        {
            if (!ModelState.IsValid)
            {
                return View(userStore);
            }

            //var imageData = Convert.FromBase64String(userStore.Image.Split(',')[1]);

            var user = new UserStore
            {
                FirstName = userStore.FirstName,
                LastName = userStore.LastName,
                BirthDate = userStore.BirthDate,
                EMail = userStore.EMail,
                PhoneNr = userStore.PhoneNr,
                PostCode = userStore.PostCode,
                City = userStore.City,
                Street = userStore.Street,
                StreetNr = userStore.StreetNr,
               // Image = imageData,
                CorrectAnswer = userStore.CorrectAnswer,
            };

            context.UserStores.Add(user);
            context.SaveChanges();

            return RedirectToAction("Home", "HOmeScreen");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}