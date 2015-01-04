using System.ComponentModel.DataAnnotations;

namespace SimpleBlog.ViewModels
{
    public class AuthLogin
    {
        // data annotation for required
        [Required]
        public string Username { get; set; }

        // data annotation - how they appear in views and how they are validated
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

    }
}