using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.Entities
{
    internal class User
    {

        public int ID { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public int CompanyID { get; set; }
    }
}
