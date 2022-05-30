using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("API")]
    public class operaciones : ControllerBase
    {
        DbClients dbo = new DbClients();

        [HttpGet("~/getAllClients")]
        public List<Client> leerTexto() => dbo.getAllClients();

        [HttpGet("~/getAllClients2")]        
        public IActionResult SelectCAllCustomers() => Ok(dbo.getAllClients());

        [HttpGet("~/getClient")]
        public Client getClient(int id) => dbo.getClient(id);

        //[HttpGet("~/getClientJson")]
        //public string getClientJson(int id) =>   JsonSerializer.Serialize(dbo.getClient(id));
        
        [HttpPost("~/postClient")]
        public void postClient(int id, string name) => dbo.newClient(id,name);

    }
}



