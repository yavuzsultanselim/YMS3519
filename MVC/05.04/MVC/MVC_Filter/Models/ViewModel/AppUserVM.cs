using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Filter.Models.ViewModel
{
    public class AppUserVM
    {
        [Required(ErrorMessage ="kullanıcı adı boş geçilemez")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "şifre boş geçilemez")]
        public string Password { get; set; }

    }
}