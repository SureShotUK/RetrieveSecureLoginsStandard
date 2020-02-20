using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieveSecureLoginsStandard
{
    public interface IRetrieveSecureCredentials <T> where T : class
    {
        bool CheckAllPropertiesAreValid();
    }
}
