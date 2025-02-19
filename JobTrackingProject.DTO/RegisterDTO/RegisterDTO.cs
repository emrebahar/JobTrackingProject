﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTrackingProject.DTO.RegisterDTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Kullanıcı adı alanı gereklidir.")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Ad alanı gereklidir.")]
        [Display(Name = "Ad")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad alanı gereklidir.")]
        [Display(Name = "Soyad")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "E-Posta alanı gereklidir.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon alanı gereklidir.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifreniz minimum 6 karakterli olmalıdır!")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrar alanı gereklidir.")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre tekrar")]
        [Compare(nameof(Password), ErrorMessage = "Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
