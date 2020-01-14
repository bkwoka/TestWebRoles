using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace testWebRoles.Areas.Identity.Pages.Account
{
    public class RolesModel : PageModel
    {
        [ViewData]
        public IList<IdentityRole> IdentityRolesList { get;}
        public RolesModel(RoleManager<IdentityRole> roleManager)
        {
            IdentityRolesList = roleManager.Roles.ToList();
        }
        
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {

            return OnGet();
        }
    }
}
