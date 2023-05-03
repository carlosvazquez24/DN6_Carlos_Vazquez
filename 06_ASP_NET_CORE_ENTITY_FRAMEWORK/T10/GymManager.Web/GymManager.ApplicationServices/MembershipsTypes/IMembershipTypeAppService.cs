using GymManager.Core.MembershipsTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.MembershipsTypes
{
    public interface IMembershipTypeAppService
    {

        List<MembershipType> GetMemberships();

        MembershipType getMembership(int id);

        int addMembership(MembershipType membership);

        void removeMembership(int membershipId);

        void editMembership(MembershipType membership);

    }
}
