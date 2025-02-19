﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTrackingProject.DTO.RegisterDTO
{
    public class UserProfileDTO
    {
        [Required(ErrorMessage = "Ad alanı gereklidir.")]
        [Display(Name = "Ad")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı gereklidir.")]
        [Display(Name = "Soyad")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "E-posta alanı gereklidir.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon alanı gereklidir.")]
        [Display(Name = "Telefon")]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
    }
}
