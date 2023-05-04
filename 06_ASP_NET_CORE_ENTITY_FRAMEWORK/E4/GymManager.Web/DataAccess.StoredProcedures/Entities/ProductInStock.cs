using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.StoredProcedures.Entities
{
    public class ProductInStock
    {

        public int Existence { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }
    }
}
