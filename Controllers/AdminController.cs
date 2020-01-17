using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using testWebRoles.Models;

namespace testWebRoles.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult GetStatistics()
        {
            var statisticsModel = new ViewStatisticsModel(_userManager.Users.Count());

            return View(statisticsModel);
        }

        [HttpGet]

        public IActionResult GetUserByName()
        {
            return View();
        }
    }
}




