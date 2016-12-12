using System.Web.Mvc;
using Core.Interfaces;

namespace CleanGuestbookMvc5.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGuestbookRepository _guestbookRepository;

        public HomeController(IGuestbookRepository guestbookRepository)
        {
            _guestbookRepository = guestbookRepository;
        }

        public ActionResult Index()
        {
            var model = _guestbookRepository.GetById(1);

            ViewBag.Message = model.Name;

            return View();
        }
    }
}