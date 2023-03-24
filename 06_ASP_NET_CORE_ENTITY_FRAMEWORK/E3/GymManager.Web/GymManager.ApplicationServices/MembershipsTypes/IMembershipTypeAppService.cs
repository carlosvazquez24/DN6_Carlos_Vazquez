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


        Task<List<MembershipType>> getMembershipsTypesAsync();

        Task<int> addMembershipTypeAsync(MembershipType membership);

        Task deleteMembershipTypeAsync(int membershipTypeId);

        Task editMembershipTypeAsync(MembershipType membership);

        Task<MembershipType> getMembershipTypeAsync(int membershipId);



    }
}
