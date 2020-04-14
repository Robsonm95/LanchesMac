using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LanchesMac.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        //[Display(Name = "Senha")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
