using Microsoft.Extensions.Configuration;
using RetrieveSecureLoginsStandard.Controller;
using RetrieveSecureLoginsStandard.Models;
using System;

namespace RetrieveSecureLoginsStandard.Controllers
{
    public class RetrieveSecureEmailReceierCredentials
    {
        /// <summary>
        /// Returns the secure login details for Email
        /// </summary>
        public EmailReceiver EmailReceiver { get; set; }
        public RetrieveSecureEmailReceierCredentials()
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
