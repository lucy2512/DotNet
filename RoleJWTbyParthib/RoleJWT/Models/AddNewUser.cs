using System.ComponentModel.DataAnnotations;

namespace RoleJWT.Models
{
    public class AddNewUser
    {
        public string UserName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
    }
}
