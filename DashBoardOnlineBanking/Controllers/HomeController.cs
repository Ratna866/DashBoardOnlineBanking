using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DashBoardOnlineBanking.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet, Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost, Authorize,ValidateAntiForgeryToken]
        public ActionResult ChangePassword(ChangePasswordModel changePasswordModel)
        {
            if (changePasswordModel is null)
            {
                throw new ArgumentNullException(nameof(changePasswordModel));
            }

            return View();
        }

    }
}