using GymManager.Core.Member;

namespace GymManager.Web.Models
{
    public class MemberListViewModel
    {
        public int NewMembersCount {get; set;}

        public List<Member> Members { get; set;}
    }
}
