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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUser(User user, string imageData, string answer)
        {
            if (!ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(imageData))
                    user.Image = Convert.FromBase64String(imageData.Split(",")[1]);

                // Save the answer in the user object
                bool isCorrectAnswer = (answer == "true");
                user.CorrectAnswer = isCorrectAnswer;

                // Save the user to the database
                context.UserStores.Add(user);
                context.SaveChanges();

                Console.WriteLine("Success");
                return RedirectToAction("Home");
            }

            Console.WriteLine("Failed");
            return View("Home", user);
        }

        public CompetionQuiz GetRandomQuiz()
        {
            Random random = new Random();
            int quizID = random.Next(1, 4);
            var quiz = (from q in context.QuizStores
                        join wa in context.WrongAnswersStores on q.QuizID equals wa.FK_QuestionID
                        where q.QuizID == quizID
                        select new CompetionQuiz
                        {
                            Question = q.Question,
                            CorrectAnswer = q.CorrectAnswer,
                            WrongAnswer1 = wa.WrongAnswer1,
                            WrongAnswer2 = wa.WrongAnswer2,
                            WrongAnswer3 = wa.WrongAnswer3
                        }).FirstOrDefault();
            Console.WriteLine(quiz); // Add this line to check the retrieved quiz
            return quiz;
        }
    }
}
