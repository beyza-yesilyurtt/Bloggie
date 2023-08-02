using System.ComponentModel.DataAnnotations;

namespace LoginPage.Models.ViewModels
{
    public class Login
    {
        [Required(ErrorMessage = "This Field Is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This Field Is Required")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "This Field Is Required")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "This Field Is Required")]
        public string Password { get; set; }
    }
}
