using Calander.Viewmodels;
using Microsoft.AspNetCore.Mvc;

namespace Calander.Controllers
{
 
    public class HomeController : Controller
    {
        static List<task> tasks = new List<task>();
		public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult process(string taskname,int timespan, int end)
        {
            task task = new task() { taskname=taskname,timespan=timespan,finishtime=end};
            if(!tasks.Where( t => t.finishtime- t.timespan == end-timespan).Any())
            {

                tasks.Add(task);

                return RedirectToAction("Calander");
            }
            else
            {
                return Content("There is another task in this timeframe!");
            }


        }
		public IActionResult Calander()
		{
			return View(tasks.ToArray());
		}
	}
}
