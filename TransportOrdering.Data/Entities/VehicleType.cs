using System;
using System.Collections.Generic;
using System.Text;

namespace TransportOrdering.Data
{
    public class VehicleType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
