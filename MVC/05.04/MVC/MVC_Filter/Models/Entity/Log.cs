using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Filter.Models.Entity
{
    //[Table("Arsiv")]
    public class Log
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Kullanıcı adı zorunludur.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Action adı zorunludur.")]
        [MaxLength(50,ErrorMessage ="15 karakterden fazla olamaz")]
        public string ActionName { get; set; }
        [Required(ErrorMessage = "Controller adı zorunludur.")]
        public string ControllerName { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }

    }
}