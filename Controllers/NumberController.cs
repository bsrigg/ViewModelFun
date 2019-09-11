using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class NumberController : Controller
    {

        public static List<Number> mn = new List<Number>(){
            new Number(1),
            new Number(500),
            new Number(4567),
            new Number(6),
            new Number(8000),
            new Number(90000),
            new Number(1000000)
        };

        [Route("number")]
        [HttpGet]
        public IActionResult Number()
        {
            return View(mn);
        }

    }
}
