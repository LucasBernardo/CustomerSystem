using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CustomerSystem.Models;
using CustomerSystem.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using CustomerSystem.Utils;
using System.Security.Claims;

namespace CustomerSystem.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IContext _db;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(IContext db, IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            var userLogged = _db.GetUserLogged();

            if (userLogged == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                List<Customer> customerList;
                customerList = _db.GetCustomersList(userLogged.Email);

                CustomerListUserVM model = new CustomerListUserVM();
                model.customers = customerList;
                model.user = _db.getUser(userLogged.Email);

                return View(model);
            }
        }
    }
}
