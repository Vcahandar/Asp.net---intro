using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Principal;
using System;

namespace HomeWorks.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
            //3) Account controllerin index action-dan onun view-na userlerin list sekilinde adlarini
            //gonderib ekranda li- taglarinda gostermek.
        {
            List<string> users = new List<string>()
            {
                "Cahandar","Ismayil","Ceyhun","Nurlan"
            };
            return View(users);
        }
    }
}
