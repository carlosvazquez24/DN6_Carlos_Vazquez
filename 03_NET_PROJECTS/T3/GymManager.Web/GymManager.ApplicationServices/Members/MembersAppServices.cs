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
        private static List<Member> _members = new List<Member>();

        public int addMember(Member member)
        {
            member.Id = new Random().Next();
            _members.Add(member);
            return member.Id;
        }

        public List<Member> GetMembers()
        {


            return _members;
        }
    }
}
