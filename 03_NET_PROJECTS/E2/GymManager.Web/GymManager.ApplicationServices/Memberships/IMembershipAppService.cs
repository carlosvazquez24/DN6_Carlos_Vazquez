using GymManager.Core.Memberships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Memberships
{
    public interface IMembershipAppService
    {

        List<Membership> GetMemberships();

        Membership getMembership(int id);

        int addMembership(Membership membership);

        void removeMembership(int membershipId);

        void editMembership(Membership membership);

    }
}
