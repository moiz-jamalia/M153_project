using M153_Project_Olma_Moiz_Jamalia.Data;
using Microsoft.AspNetCore.Mvc;

namespace M153_Project_Olma_Moiz_Jamalia.Controllers
{
    public class AdminLoginController : Controller
    {
        private readonly AppDbContext context;
        public AdminLoginController(AppDbContext context) 
        {
            this.context = context;
        }
        public IActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ValidateUser(string username, string password)
        {
            var user = context.AdminStores.FirstOrDefault(u => u.usernameAdmin == username);
            if (user != null && VerifyPassword(password, user.Password))
            {
                Console.WriteLine("success");
                return RedirectToAction("AdminUserOverview");
            }
            else
            {
                Console.WriteLine("Fail nigga");
                return RedirectToAction("AdminLogin");
            }
        }

        private bool VerifyPassword(string password, string storedpassword)
        {
            return password == storedpassword;
        }

        public IActionResult AdminUserOverview()
        {
            var users = context.UserStores.ToList();
            return View(users);
        }
    }
}
