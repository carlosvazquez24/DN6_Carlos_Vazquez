using DataAccess.Example.Core;
using DataAccess.Example.EntityFramework;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataAccess.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {

        private readonly IColorsDataManager _colorsDataManager;
        public ColorsController(IColorsDataManager colorsDataManager) {
            _colorsDataManager = colorsDataManager;
        }


        // GET: api/<ColorsController>
        [HttpGet]
        public IEnumerable<Color> Get()
        {
            return _colorsDataManager.GetAll();
        }

        // GET api/<ColorsController>/5
        [HttpGet("{id}")]
        public Color Get(int id)
        {
            Color entity = _colorsDataManager.GetColor(id);

            return entity;
        }

        // POST api/<ColorsController>
        [HttpPost]
        public void Post([FromBody] Color color)
        {

            _colorsDataManager.Insert(color);
        }

        // PUT api/<ColorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Color color)
        {
            color.Id = id;
            _colorsDataManager.Update(color);


        }

        // DELETE api/<ColorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _colorsDataManager.Delete(id);
        }
    }
}
