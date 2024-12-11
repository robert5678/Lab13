using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Lab13.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            Log.Debug("Це повідомлення рівня Debug");
            Log.Information("Користувач зайшов на сторінку {Page}", "Index");
            Log.Warning("Попередження: можливі проблеми на сторінці {Page}", "Index");
            Log.Error("Сталася помилка на сторінці {Page}", "Index");
            Log.Fatal("Критична помилка на сторінці {Page}", "Index");

            
            var user = new { Name = "Олександр", Email = "test@example.com" };
            Log.Information("Дані про користувача: {@User}", user);

            return View();
        }
    }
}
