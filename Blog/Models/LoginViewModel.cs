using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class LoginViewModel
    {
        [Required]
        public string LoginName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
