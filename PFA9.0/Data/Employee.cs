﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFA9._0.Models
{
    
        public class Employee : IdentityUser
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Photo { get; set; }
            public string TaxId { get; set; }
            public DateTime DateOfBirth { get; set; }
            public DateTime DateJoined { get; set; }
        }
    
}
