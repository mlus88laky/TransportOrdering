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
    public class AdminController : ControllerBase
    {
        IAdminManager adminManager = new AdminManager();

        // GET: api/Admin
        [HttpGet]
        [Route("ValidatePassword")]
        public UserDTO ValidatePassword(string userName,string password)
        {
            return adminManager.ValidatePassword(userName, password);
        }       
        
    }
}
