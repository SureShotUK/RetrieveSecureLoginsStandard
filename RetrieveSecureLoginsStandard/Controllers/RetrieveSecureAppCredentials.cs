using Microsoft.Extensions.Configuration;
using RetrieveSecureLoginsStandard.Models;
using System;

namespace RetrieveSecureLoginsStandard.Controller
{
    public class RetrieveSecureAppCredentials : IRetrieveSecureDatabaseCredentials
    {
        public AppCredentials AppCredentials { get; set; }

        public RetrieveSecureAppCredentials()
        {
            var configs = GetConfiguration.GetConfigs;
            AppCredentials = configs.Configuration.GetSection("AppCredentials")
                .Get<AppCredentials>();
        }
        public bool CheckAllPropertiesAreValid()
        {
            return (!String.IsNullOrWhiteSpace(AppCredentials.ClientId) &&
                !String.IsNullOrWhiteSpace(AppCredentials.TenantId) &&
                !String.IsNullOrWhiteSpace(AppCredentials.ClientSecret) &&
                !String.IsNullOrWhiteSpace(AppCredentials.AzureCloudInstance) &&
                !String.IsNullOrWhiteSpace(AppCredentials.AadAuthorityAudience) &&
                !String.IsNullOrWhiteSpace(AppCredentials.MicrosoftGraphBaseEndpoint) &&
                !String.IsNullOrWhiteSpace(AppCredentials.Scopes)
                );
        }
    }
}
