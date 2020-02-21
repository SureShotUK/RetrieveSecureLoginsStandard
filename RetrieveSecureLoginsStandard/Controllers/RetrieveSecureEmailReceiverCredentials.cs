﻿using Microsoft.Extensions.Configuration;
using RetrieveSecureLoginsStandard.Models;
using System;

namespace RetrieveSecureLoginsStandard.Controller
{
    public class RetrieveSecureEmailReceiverCredentials
    {
        /// <summary>
        /// Returns the secure login details for Email
        /// </summary>
        public EmailReceiver EmailReceiver { get; set; }
        public RetrieveSecureEmailReceiverCredentials()
        {
            var configs = GetConfiguration.GetConfigs;
            EmailReceiver = configs.Configuration.GetSection("EmailReceiver")
                .Get<EmailReceiver>();
        }
        public bool CheckAllPropertiesAreValid()
        {
            return (!String.IsNullOrWhiteSpace(EmailReceiver.UserName) &&
                !String.IsNullOrWhiteSpace(EmailReceiver.Password));
        }
    }
}
