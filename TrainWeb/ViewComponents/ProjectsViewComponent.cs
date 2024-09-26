using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TrainWeb.Models;

namespace TrainWeb.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View("_Projects", ProjectData.ProjectsData.GetAllProject());
		}
	}
}
