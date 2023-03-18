using DataAccess.Example.Core;
using DataAccess.Example.EntityFramework;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataAccess.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehiclesDataManager _vehiclesDataManager;
        public VehiclesController(IVehiclesDataManager vehiclesDataManager) {
            _vehiclesDataManager = vehiclesDataManager;
        }

        // GET: api/<VehiclesController>
        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return _vehiclesDataManager.GetAll();
        }

        // GET api/<VehiclesController>/5
        [HttpGet("{id}")]
        public Vehicle Get(int id)
        {
            return _vehiclesDataManager.GetVehicle(id);
        }

        // POST api/<VehiclesController>
        [HttpPost]
        public void Post([FromBody] Vehicle vehicle)
        {
            _vehiclesDataManager.Insert(vehicle);

        }

        // PUT api/<VehiclesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Vehicle vehicle)
        {
            vehicle.Id = id;
            _vehiclesDataManager.Update(vehicle);
        }

        // DELETE api/<VehiclesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _vehiclesDataManager.Delete(id);

        }
    }
}
