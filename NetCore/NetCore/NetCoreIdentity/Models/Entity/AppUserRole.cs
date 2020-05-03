﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIdentity.Models.Entity
{
    public class AppUserRole:IdentityRole
    {
        public string Description { get; set; }
    }
}
