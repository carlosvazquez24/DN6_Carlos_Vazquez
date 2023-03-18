using DataAccess.Example.Core;
using DataAccess.Example.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace DataAccess.Example.WebApi.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]

    public class MakesController : Controller
    {
        private readonly IQueriesExample _queriesExample;
        public MakesController(IQueriesExample queriesExample) {
            _queriesExample = queriesExample;
        }


        [HttpGet]
        public IEnumerable<Make> Get()
        {
            return _queriesExample.GetMakes();
        }


        [HttpGet(nameof(GetByPrice))]
        public IEnumerable<Vehicle> GetByPrice()
        {
            return _queriesExample.GetVehiclesByPrice(80000,150000);
        }


    }
}
