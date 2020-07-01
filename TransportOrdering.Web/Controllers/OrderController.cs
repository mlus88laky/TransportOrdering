using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransportOrdering.Business;

namespace TransportOrdering.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        IOrderManager orderManager = new OrderManager();

        // GET: api/Order
        [HttpGet]
        [Route("GetOrderList")]
        public List<OrderDTO> GetOrderList()
        {
            return orderManager.GetOrderList();
        }


       // POST: api/Order
       [HttpPost]
       [Route("AddOrder")]
        public string AddOrder(OrderDTO order)
        {
            return orderManager.Add(order);
        }

        // GET: api/Order
        [HttpGet]
        [Route("GetVehicleTypeList")]
        public List<VehicleTypeDTO> GetVehicleTypeList()
        {


            return orderManager.GetVehicleTypeList();
        } 

    }
}
