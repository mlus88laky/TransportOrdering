using System;
using System.Collections.Generic;
using System.Text;

namespace TransportOrdering.Business
{
    public interface IAdminManager
    {
        UserDTO ValidatePassword(string userName, string password);
    }
}
