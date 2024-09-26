using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TrainWeb.Models;

namespace TrainWeb.ViewComponents
{
	public class ArticlesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View("_Articles", ArticleData.ArticlesData.GetAllArticle());
		}
	}
}
