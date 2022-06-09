using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employee : ControllerBase
    {
        Employee db = new Employee();
        public IEnumerable<employee> Get()

        {
            return db.employeenew;
        }
    }

    
}
