using System.Web.Mvc;
using System.Web.Security;
using TASK1_ASP.Models.EntityManager;
using TASK1_ASP.Models.ViewModel;

namespace TASK1_ASP.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(UserSignUpView USV)
        {
            if (ModelState.IsValid)
            {
                UserManager UM = new UserManager();
                if (!UM.IsLoginNameExist(USV.LoginName))
                {
                    UM.AddUserAccount(USV);
                    FormsAuthentication.SetAuthCookie(USV.FirstName, false);
                    return RedirectToAction("Welcome", "Home");
                }
                else
                    ModelState.AddModelError("", "Login Name already taken.");
            }
            return View();
        }
    }
}