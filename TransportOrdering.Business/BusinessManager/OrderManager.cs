using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransportOrdering.Data;

namespace TransportOrdering.Business
{
    public class OrderManager : IOrderManager
    {
        public string Add(OrderDTO orderDTO)
        {
            using (var context = new DatabaseContext())
            {
                Random random = new Random();
                string referenceNo = $"{random.Next(100000):00000}{random.Next(100000):00000}";
                Order addOrder = new Order
                {
                    Date = Convert.ToDateTime (orderDTO.Date),
                    StartTime = Convert.ToDateTime(orderDTO.StartTime),
                    VehicleTypeId = orderDTO.VehicleTypeId,
                    VehicleCapacity = orderDTO.VehicleCapacity,
                    StartAddress = orderDTO.StartAddress,
                    EndAddress = orderDTO.EndAddress,
                    FullName = orderDTO.FullName,
                    Email = orderDTO.Email,
                    MobileNumber = orderDTO.MobileNumber,
                    ReferenceNumber = referenceNo
                };
                context.Order.Add(addOrder);
               context.SaveChanges();
                return referenceNo;
            }
        }

        public List<OrderDTO> GetOrderList()
        {

            using (var context = new DatabaseContext())
            {
                return context.Order.Select(s => new OrderDTO
                {
                    FullName = s.FullName,
                    EndAddress=s.EndAddress,
                    Email=s.Email,
                    Date=s.Date.ToString(),
                    MobileNumber=s.MobileNumber,                 
                    ReferenceNumber=s.ReferenceNumber,
                    StartAddress=s.StartAddress,
                    StartTime=s.StartTime.ToString(),
                    VehicleCapacity=s.VehicleCapacity,
                    VehicleTypeId=s.VehicleTypeId,
                    VehicleType = s.VehicleTypes.Description
                }).ToList();
            }

        }  

       public List<VehicleTypeDTO> GetVehicleTypeList()
        {
            using (var context = new DatabaseContext())
            {
                return context.VehicleType.Select(x => new VehicleTypeDTO {Id= x.Id, Description=x.Description })
                .ToList();
            }
        }
    }
}
