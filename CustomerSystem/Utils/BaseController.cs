using CustomerSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSystem.Utils
{
    public class BaseController : Controller
    {
        public readonly UserManager<User> _manager;
        private readonly HttpContextAccessor httpContextAccessor;

        public async Task<User> GetCurrentUser()
        {
            return await _manager.GetUserAsync(httpContextAccessor.HttpContext.User);
        }
    }
}
