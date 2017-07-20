using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CSRF_AJAX.Models
{
    public class Account
    {
        [Required]
        [Display(Name = "帳號")]
        public string account { get; set; }
        [Required]
        [Display(Name = "名稱")]
        public string name { get; set; }
    }
}