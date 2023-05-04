using DataAccess.StoredProcedures.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.StoredProcedures
{
    public interface IStoredProcedure
    {

        public ProductInStock ConsultInventory(int id);

        public List<LastMembersRegistered> GetLastMembersRegistered();

        public RecordSaleResult RecordSale(int idProduct, int idUser);



    }
}
