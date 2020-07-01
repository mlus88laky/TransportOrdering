using System;
using System.Collections.Generic;
using System.Text;

namespace TransportOrdering.Business
{
    public interface IOrderManager
    {
        string Add(OrderDTO vehicle);
        List<OrderDTO> GetOrderList();
        List<VehicleTypeDTO> GetVehicleTypeList();
    }
}
