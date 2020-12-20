using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RegController : ControllerBase
  {
    // POST api/<RegController>
    [HttpPost]
    public int Post([FromBody] AuthData auth_data)
    {
      int int_token = Program.Sessions.registration(auth_data);
      return int_token;
    }
  }
}
