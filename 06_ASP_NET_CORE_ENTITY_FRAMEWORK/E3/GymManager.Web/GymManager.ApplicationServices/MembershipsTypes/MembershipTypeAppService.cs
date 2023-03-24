using GymManager.Core.MembershipsTypes;
using GymManager.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.MembershipsTypes
{
    public class MembershipTypeAppService : IMembershipTypeAppService
    {



        private readonly IRepository<int, MembershipType> _repository;

        public MembershipTypeAppService(IRepository<int, MembershipType> repository)
        {

            _repository = repository;

        }

        public async Task<int> addMembershipTypeAsync(MembershipType membership)
        {
            await _repository.AddAsync(membership);
            return membership.Id;
        }

        public async Task deleteMembershipTypeAsync(int membershipTypeId)
        {
            await _repository.DeleteAsync(membershipTypeId);
        }

        public async Task editMembershipTypeAsync(MembershipType membership)
        {
            await _repository.UpdateAsync(membership);
        }

        public async Task<List<MembershipType>> getMembershipsTypesAsync()
        {
            return await _repository.GetAllAsync().ToListAsync();
        }

        public async Task<MembershipType> getMembershipTypeAsync(int membershipId)
        {
            return await _repository.GetAsync(membershipId);
        }

    }
}
