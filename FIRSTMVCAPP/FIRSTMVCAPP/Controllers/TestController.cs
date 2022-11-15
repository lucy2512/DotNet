using Microsoft.AspNetCore.Mvc;

namespace FIRSTMVCAPP.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Message()
        {
            return View("Message");
        }
    }
}
