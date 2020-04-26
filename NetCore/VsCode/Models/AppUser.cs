using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace VsCode{
    public class AppUser{

        public static List<AppUser> appUsers=new List<AppUser>(){
            new AppUser{ID=1,UserName="Admin",Password="1234"}
        };
        public int ID { get; set; }
        [Required(ErrorMessage="Kullanıcı adı boş geçilemez.")]
        [Display(Name="Kullanıcı Adı")]
        public string UserName { get; set; }


        [Required(ErrorMessage="Email boş geçilemez.")]
        [Display(Name="Email")]
        public string Email { get; set; }

        [Required(ErrorMessage="Şifre boş geçilemez.")]
        [Display(Name="Şifre")]
        public string Password { get; set; }
        // [Required(ErrorMessage="Lütfen tekrar şifrenizi yazın.")]
        // [Display(Name="Şifre Tekrar")]
        // [Compare("Password",ErrorMessage="Şifreler aynı değil.")]
        // public string ConfirmPassword { get; set; }
    }
}