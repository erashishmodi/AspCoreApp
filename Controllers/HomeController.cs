using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace testapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserName="Ashish Modi";
            return View();
        }
        public IActionResult ListUser()
        {
            ViewBag.UserName="Ashish Modi";
            List<testapp.Models.UserModel> list=new List<testapp.Models.UserModel>();
            list.Add(new testapp.Models.UserModel{UserId=1,UserName="Ashish Modi"});
            list.Add(new testapp.Models.UserModel{UserId=2,UserName="Tejas Modi"});
            list.Add(new testapp.Models.UserModel{UserId=3,UserName="Amit"});
            list.Add(new testapp.Models.UserModel{UserId=4,UserName="Hitesh"});

            return View(list);
        }
    }
}
