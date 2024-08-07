using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.AboutVieComponents
{
	public class _BecomeADriverComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
