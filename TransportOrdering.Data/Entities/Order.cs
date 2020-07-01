using System;
using System.Collections.Generic;
using System.Text;

namespace TransportOrdering.Data
{
    public class Order 
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public int VehicleTypeId { get; set; }
        public string VehicleCapacity  { get; set; }
        public string StartAddress { get; set; }
        public string EndAddress { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string ReferenceNumber { get; set; }

        public virtual VehicleType VehicleTypes { get; set; }
        
    }
}
