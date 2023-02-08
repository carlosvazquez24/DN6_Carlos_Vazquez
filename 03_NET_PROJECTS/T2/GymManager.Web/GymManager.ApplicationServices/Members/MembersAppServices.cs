using GymManager.Core.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public class MembersAppServices : IMembersAppServices
    {
        public List<Member> GetMembers()
        {
            List<Member> members = new List<Member>();
            members.Add(new Member(){
                Name = "Juan",
                LastName= "Sanchez",
                BirthDay= new DateTime(1996,2,22),
                AllowNewsletter= false,
                CityId= 3,
                Email = "bart@prueba.com"
            });

            members.Add(new Member()
            {
                Name = "Diana",
                LastName = "Vázquez",
                BirthDay = new DateTime(1990, 12, 02),
                AllowNewsletter = true,
                CityId = 3,
                Email = "homer@prueba.com"
            });

            members.Add(new Member()
            {
                Name = "Israel",
                LastName = "Perez",
                BirthDay = new DateTime(1980, 4, 12),
                AllowNewsletter = true,
                CityId = 1,
                Email = "isra@prueba.com"
            });

            members.Add(new Member()
            {
                Name = "Adrian",
                LastName = "Torres",
                BirthDay = new DateTime(2001, 1, 29),
                AllowNewsletter = true,
                CityId = 1,
                Email = "ariGameplays@prueba.com"
            });

            return members;
        }
    }
}
