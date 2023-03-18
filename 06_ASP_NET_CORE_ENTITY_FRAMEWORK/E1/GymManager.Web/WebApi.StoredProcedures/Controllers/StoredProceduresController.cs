using Microsoft.AspNetCore.Mvc;
using DataAccess.StoredProcedures.Entities;
using DataAccess.StoredProcedures;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.StoredProcedures.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class StoredProceduresController : ControllerBase
    {

        private readonly IStoredProcedure _storedProcedure;
        public StoredProceduresController(IStoredProcedure storedProcedure)
        {
            _storedProcedure = storedProcedure;
        }

        // GET: api/StoredProcedures/consultInventory
        [HttpGet(nameof(consultInventory))]
        public ProductInStock consultInventory(int id)

        {
            return _storedProcedure.ConsultInventory(id);
        }


        // GET: api/StoredProcedures/getNewMembers
        [HttpGet(nameof(getNewMembers))]
        public List<LastMembersRegistered> getNewMembers()
        {
            return _storedProcedure.GetLastMembersRegistered();
        }

        // GET: api/StoredProcedures/recordSale
        [HttpGet(nameof(recordSale))]
        public RecordSaleResult recordSale(int idProduct, int idUser)
        {
            return _storedProcedure.RecordSale(idProduct, idUser);
        }

    }
}