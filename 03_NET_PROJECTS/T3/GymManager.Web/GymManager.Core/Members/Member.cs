using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Member
{
    public class Member
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public string Email { get; set; }

        public int CityId { get; set; }

        public Boolean AllowNewsletter { get; set; }
    }
}
