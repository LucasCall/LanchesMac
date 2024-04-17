using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
	public class ContatoController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}

		//Forma de limitar o acesso a usuarios logados, se não estiver logado
		//redireciona para outra tela

		//public IActionResult Index()
		//{
		//	if (User.Identity.IsAuthenticated)
		//	{
		//		return View();
		//	}
		//	return RedirectToAction("Login", "Account");
		//}
	}
}
