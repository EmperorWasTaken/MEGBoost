using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MEG_Boosting_Site.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MEG_Boosting_Site.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MEG_Boosting_Site.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
    }
}