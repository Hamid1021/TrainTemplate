﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TrainWeb.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3, ErrorMessage = "حداقل طول نام، 3 کاراکتر است")]
        [MaxLength(100, ErrorMessage = "حداکثر طول نام، 100 کاراکتر است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل صحیح نیست")]
        public string Email { get; set; }

        public int Service { get; set; }
        public string Message { get; set; }
        public SelectList Services { get; set; }
    }
}