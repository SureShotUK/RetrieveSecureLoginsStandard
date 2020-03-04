using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieveSecureLoginsStandard.Models
{
    public class AppCredentials
    {
        public string ClientId { get; set; }
        public string TenantId { get; set; }
        public string ClientSecret { get; set; }
        public string AzureCloudInstance { get; set; }
        public string AadAuthorityAudience { get; set; }
        public string MicrosoftGraphBaseEndpoint { get; set; }
        public string Scopes { get; set; }

    }
}
