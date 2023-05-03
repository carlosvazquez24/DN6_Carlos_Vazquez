using GymManager.Core.MembershipsTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.MembershipsTypes
{
    public class MembershipTypeAppService : IMembershipTypeAppService

    {

        private static List<MembershipType> _memberships = new List<MembershipType>();

        public List<MembershipType> GetMemberships()
        {
            return _memberships; 
        }

        public MembershipType getMembership(int id) {

            var m = _memberships.Where(x => x.Id == id).FirstOrDefault();
            return m;
        
        }

        public int addMembership(MembershipType membership)
        {
            membership.Id = new Random().Next();
            membership.CreatedOn = DateTime.Now;
            _memberships.Add(membership);
            return membership.Id;
        }

        public void editMembership(MembershipType membership)
        {
            var m = _memberships.Where(x => x.Id == membership.Id).FirstOrDefault();
            m.Cost = membership.Cost;
            m.Duration = membership.Duration;
            m.Name= membership.Name;
        }

        public void removeMembership(int id)
        {
            _memberships.Remove(getMembership(id));
        }

    }
}
