﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieveSecureLoginsStandard.Models
{
    /// <summary>
    /// Returns the secure credentials for Email
    /// </summary>
    public class EmailCredentials
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
