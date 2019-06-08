using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticationWebApi.Models
{
    public class NationalityBindingViewModels
    {
        public class AddNationalityBindingModel
        {
            [Required]
            [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 1)]
            [Display(Name = "Name")]
            public string Name { get; set; }
        }
    }
}