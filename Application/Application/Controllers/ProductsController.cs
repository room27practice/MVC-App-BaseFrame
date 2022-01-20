using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Controllers
{
    public class ProductsController : BaseController
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

    }
}
