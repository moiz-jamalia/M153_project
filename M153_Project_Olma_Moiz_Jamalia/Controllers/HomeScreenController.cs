using M153_Project_Olma_Moiz_Jamalia.Data;
using M153_Project_Olma_Moiz_Jamalia.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;


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

        [BindProperty]
        public UserStore UserStore { get; set; }

        public void OnGet() { }

        public IActionResult Home()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        private byte[] ImgaeToByteArray(Image image)
        {
            using (var stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }
    }
}