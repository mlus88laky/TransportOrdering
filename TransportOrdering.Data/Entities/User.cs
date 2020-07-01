using System;
using System.Collections.Generic;
using System.Text;

namespace TransportOrdering.Data
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
