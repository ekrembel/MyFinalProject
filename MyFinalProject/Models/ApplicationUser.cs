﻿using System;
using Microsoft.AspNetCore.Identity;

namespace MyFinalProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public double Fund { get; set; }


        public ApplicationUser()
        {
        }
    }
}
