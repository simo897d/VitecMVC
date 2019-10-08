using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VitecMVC.Models
{

    public class User
    {
        public int UserID { get; set; }
        public string Firstname {get; set;}
        public string Lastname { get; set; }
        public int Phonenumber { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }

    }
}
