using System.ComponentModel.DataAnnotations;

namespace AppParte02.Models
{
    public class LoginViewModel
    {
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; internal set; }
        public string Role { get; set; }
    }
}