using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class UserController : Controller
    {

        public static List<User> users = new List<User>(){
            new User("Barry", "Rigg"),
            new User("Laurie", "Beth"),
            new User("George","Washington"),
            new User("Abe", "Lincoln"),
            new User("Herbert", "Humphrey"),
            new User("Duffus","Trump"),
            new User("Willy", "Wonka")
        };

        [Route("user")]
        [HttpGet]
        public IActionResult User()
        {
            return View(users);
        }
        [Route("user/{n}")]
        [HttpGet]
        public IActionResult SingleUser(int n)
        {
    
            return View(users[n]);
        }
    }
}
