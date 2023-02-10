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

        public void deleteMember(int memberId)
        {
            var m = _members.Where(x => x.Id == memberId).FirstOrDefault();
            _members.Remove(m);
        }

        public void editMember(Member member)
        {
            var m = _members.Where(x =>x.Id == member.Id).FirstOrDefault();
            m.Name = member.Name;
            m.LastName = member.LastName;
            m.BirthDay = member.BirthDay;
            m.CityId = member.CityId;
            m.AllowNewsletter = member.AllowNewsletter;
            
        }

        public Member getMember(int memberId)
        {
            var m = _members.Where(x => x.Id == memberId).FirstOrDefault();
            return m;
        }

        public List<Member> GetMembers()
        {


            return _members;
        }
    }
}
