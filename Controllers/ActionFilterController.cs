using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coremvcapp.Models;

namespace coremvcapp.Controllers
{
    public class ActionFilterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
