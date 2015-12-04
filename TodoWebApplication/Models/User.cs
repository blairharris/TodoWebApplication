using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoWebApplication.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [EmailAddress(ErrorMessage ="Invalid email adress numpty")]
        public string Email { get; set; }
    }
}