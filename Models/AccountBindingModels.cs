﻿using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace AuthenticationWebApi.Models
{
    // Модели, используемые в качестве параметров действий AccountController.

    public class AddExternalLoginBindingModel
    {
        [Required]
        [Display(Name = "Внешний маркер доступа")]
        public string ExternalAccessToken { get; set; }
    }

    public class ChangePasswordBindingModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Текущий пароль")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Новый пароль")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение нового пароля")]
        [Compare("NewPassword", ErrorMessage = "Новый пароль и его подтверждение не совпадают.")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterBindingModel
    {
        [Required]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароль и его подтверждение не совпадают.")]
        public string ConfirmPassword { get; set; }

        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string Nationality { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        
        [StringLength(500, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Comment")]
        public string Comment { get; set; }

        [StringLength(200, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Faculty name")]
        public string FacultyName { get; set; }

        [StringLength(200, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Faculty city")]
        public string FacultyCity { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Faculty adress")]
        public string FacultyAdress { get; set; }
    }

    public class RegisterExternalBindingModel
    {
        [Required]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }
    }

    public class RemoveLoginBindingModel
    {
        [Required]
        [Display(Name = "Поставщик входа")]
        public string LoginProvider { get; set; }

        [Required]
        [Display(Name = "Ключ поставщика")]
        public string ProviderKey { get; set; }
    }

    public class SetPasswordBindingModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Новый пароль")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение нового пароля")]
        [Compare("NewPassword", ErrorMessage = "Новый пароль и его подтверждение не совпадают.")]
        public string ConfirmPassword { get; set; }
    }
}
