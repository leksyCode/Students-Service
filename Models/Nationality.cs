using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AuthenticationWebApi.Models
{
    public class Nationality
    {
        public int NationalityId { get; set; }
        public string Name { get; set; }
    }
}