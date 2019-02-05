using MVC_Examples.BLL;
using MVC_Examples.DAL.MyEntities;
using MVC_Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Examples.Controllers
{
    public class UserController : Controller
    {
        UserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(UserViewModel model)
        {
            _userService.AddUser(new User {
                FirstName=model.FirstName,
                LastName=model.LastName,
                EMail=model.EMail,
                Gender=model.Gender,
                Password=model.Password
            });
            return View();
        }

    }
}