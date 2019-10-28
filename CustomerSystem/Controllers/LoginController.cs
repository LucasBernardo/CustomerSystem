using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerSystem.Infrastructure;
using CustomerSystem.Models;
using CustomerSystem.Utils;
using Microsoft.AspNetCore.Mvc;

namespace CustomerSystem.Controllers
{
    public class LoginController : BaseController
    {
        private readonly IContext _db;

        public LoginController(IContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var user = _db.GetUserLogged();

            if (user == null)
            {
                return View(new User());
            }
            else
            {
                return RedirectToAction("Index", "Home", user);
            }
        }

        [HttpPost]
        public IActionResult Index(User model)
        {
            if (ModelState.IsValid)
            {
                if(_db.Login(model.Email, model.Password))
                {
                    //adicionar o usuario do login pra sessao
                    _db.SetUserLogged(model);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View(model);
                }
            }
            return View(model);
        }

    }
}