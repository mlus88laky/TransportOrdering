using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransportOrdering.Data;

namespace TransportOrdering.Business
{
    public class AdminManager : IAdminManager
    {
        public UserDTO ValidatePassword(string userName, string password)
        {
            using (var context = new DatabaseContext())
            {
                if (context.User.Where(s => s.UserName.Equals(userName) && s.Password.Equals(password) && s.IsActive).Count() > 0)
                {
                    return context.User.Select(s => new UserDTO
                    {                        
                        UserName = s.UserName,
                        IsValid = true
                    }).FirstOrDefault();
                }
                else {
                    return new UserDTO { IsValid = false };
                }
            }
        }
    }
}
