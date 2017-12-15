//using System;
using System.Collections.Generic;
using System.Linq;
//using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;


namespace warehouseWeb.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [NoDirectAccess]
        public ActionResult authenticate(User user = null)
        {
            if (sql.authenticate(user)) return RedirectToAction("Dashboard", "Dashboard");//successfully login user... direct to dashboard
            else
            {
                TempData["Message"] = Constants.INVALID_CREDENTIALS_MESSAGE;
                return RedirectToAction("Login", "Login");
            }
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [NoDirectAccess]
        public ActionResult CompleteRegistration(User user)
        {
            if (user.LoginPass == null ||  //// set the required field here (for registration).....
                user.LoginUser == null || 
                user.fname == null     ||
                user.lname == null      

                )
            {
                TempData["Message"] = Constants.MISSING_FIELDS_MESSAGE;
                return RedirectToAction("Register", "Login");
            }
            else if ( user.LoginPass.Length > 6 && user.LoginPass.Length > 6) // put length requirements etc...FOR REQUIRED FIELDS.....
            {
                int aff = sql.Insert("Users", new object []{
                    user.Id,
                    user.LoginUser,
                    user.LoginPass, 
                    user.address1, 
                    user.address2,
                    user.city,
                    user.state,
                    user.zip,
                    user.phone,
                    user.email,
                    user.fname,
                    user.lname, 
                    user.companyName
                } );
                if (aff == 1)
                {
                    TempData["Message"] = Constants.ACCOUNT_SUCCESSFULLY_CREATED;
                    return RedirectToAction("Login", "Login");
                }
                else
                {
                    TempData["Message"] = Constants.UNKNOWN_ERROR;
                    return View();

                }
            }

            else {
                TempData["Message"] = Constants.INCORRECT_INFORMATION_MESSAGE;
                return RedirectToAction("Register", "Login");


            }
            
        }



        [NoDirectAccess]
        public ActionResult InvalidError()
        {
            return RedirectToAction("InvalidError", "Login");
        }
    }
}