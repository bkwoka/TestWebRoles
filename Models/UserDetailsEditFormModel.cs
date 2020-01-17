using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testWebRoles.Models
{
    public class UserDetailsEditFormModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string UserRole { get; set; }
        public IList<string> Roles { get; set; }
    }
}
