using System;
using System.Collections.Generic;
using System.Text;

namespace TransportOrdering.Business

{
    public class UserDTO
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsValid { get; set; }
    }
}
