using GymManager.Core.Memberships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Memberships
{
    public class MembershipAppService : IMembershipAppService

    {

        private static List<Membership> _memberships = new List<Membership>();

        public List<Membership> GetMemberships()
        {
            return _memberships; 
        }

        public Membership getMembership(int id) {

            var m = _memberships.Where(x => x.Id == id).FirstOrDefault();
            return m;
        
        }

        public int addMembership(Membership membership)
        {
            membership.Id = new Random().Next();
            membership.CreatedOn = DateTime.Now;
            _memberships.Add(membership);
            return membership.Id;
        }

        public void editMembership(Membership membership)
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
