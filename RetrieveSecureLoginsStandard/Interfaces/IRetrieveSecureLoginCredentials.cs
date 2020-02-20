using RetrieveSecureLoginsStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieveSecureLoginsStandard
{
    interface IRetrieveSecureLoginCredentials : IRetrieveSecureCredentials<LoginCredentials>
    {
    }
}
