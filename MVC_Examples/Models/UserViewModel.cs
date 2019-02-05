using MVC_Examples.DAL.MyEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Examples.Models
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="İsim alanını boş geçmeyiniz")]
        [MaxLength(20,ErrorMessage ="İsim alanı maksimum 20 karakter olabilir")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim alanını boş geçmeyiniz")]
        [MaxLength(20,ErrorMessage = "Soyisim alanı maksimum 20 karakter olabilir")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "EMail alanını boş geçmeyiniz")]
        [MaxLength(50, ErrorMessage = "EMail alanı maksimum 50 karakter olabilir")]
        [EmailAddress(ErrorMessage ="EMail formatında giriş yapımız")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Şifre alanını boş geçmeyiniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Cinsiyet alanını boş geçmeyiniz")]
        public bool Gender { get; set; }
    }
}