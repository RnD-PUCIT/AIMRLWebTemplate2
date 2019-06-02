﻿using System;
using System.Collections.Generic;

namespace PUCIT.AIMRL.WebAppName.Entities.Security
{
    public class SecUserDTO
    {
        
        public String UserFullName { get; set; }
        public int UserId { get; set; }
        public String Login { get; set; }
        public String Email { get; set; }
        public Boolean IsActive { get; set; }
        public List<String> Permissions { get; set; }
        public List<String> Roles { get; set; }
    }
}
