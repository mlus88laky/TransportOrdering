using System;
using System.Collections.Generic;
using System.Text;

namespace TransportOrdering.Business
{
   public class OrderDTO
    {      
        public string Date { get; set; }
        public string StartTime { get; set; }
        public int VehicleTypeId { get; set; }
        public string VehicleCapacity { get; set; }
        public string StartAddress { get; set; }
        public string EndAddress { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public string VehicleType { get;  set; }
    }
}
