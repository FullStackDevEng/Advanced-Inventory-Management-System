using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace warehouseWeb.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        [NoDirectAccess]
        public ActionResult Dashboard()
        {
            return View();
        }
        [NoDirectAccess]
        public ActionResult Users()
        {
            return View(new hmastaffEntities().Users.ToList());
        }
        [NoDirectAccess]
        public ActionResult Transactions()
        {
            return View(new hmastaffEntities().Transactions.ToList());
        }
        [NoDirectAccess]
        public ActionResult Inventory()
        {
            return View(new hmastaffEntities().Items.ToList());
        }

    }
}