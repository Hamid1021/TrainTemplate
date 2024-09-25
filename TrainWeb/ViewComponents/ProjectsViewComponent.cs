using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TrainWeb.Models;

namespace TrainWeb.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = new List<Project>
			{
				new Project(1, "تاکسی", "Atriya", "درخواست آنلاین تاکسی برای سفر های درون شهری", "project-1.jpg"),
				new Project(2, "زودفود","ZoodFood", "درخواست آنلاین غذا برای سراسر کشور", "project-2.jpg"),
				new Project(3, "مدارس","MONOP", "سیستم مدیریت یکپارچه مدارس", "project-3.jpg"),
				new Project(4, "فضاپیما", "NASA", "برنامه مدیریت فضاپیما های ناسا","project-4.jpg"),
			};
			return View("_Projects", projects);

		}
	}
}
