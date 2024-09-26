using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TrainWeb.Models;

namespace TrainWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1, "نقره ای"),
            new Service(2, "طلایی"),
            new Service(3, "پلاتین"),
            new Service(4, "الماس"),
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "ارسال فرم با خطا مواجه شد. لطفا مجددا تلاش فرمایید.";
                return View(model);
            }

            ModelState.Clear();
            model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            ViewBag.success = "ارسال فرم با موفقیت انجام شد!";
	        return View(model);
        }
	}
}
