using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticationWebApi.Models
{
    public class Faculty
    {
        public int FacultyId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
    }
}