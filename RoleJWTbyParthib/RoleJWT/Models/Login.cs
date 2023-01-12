using Microsoft.Build.Framework;
using System.ComponentModel;

namespace RoleJWT.Models
{
    public class Login
    {
        [Required]
        public string UserName { get; set; }
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}
