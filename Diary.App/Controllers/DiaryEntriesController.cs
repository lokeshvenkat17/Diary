using Microsoft.AspNetCore.Mvc;

namespace Diary.App.Controllers
{
    public class DiaryEntriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
