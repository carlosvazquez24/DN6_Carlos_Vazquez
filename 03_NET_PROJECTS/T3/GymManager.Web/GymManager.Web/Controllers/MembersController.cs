using GymManager.ApplicationServices.Members;
using GymManager.Core.Member;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    public class MembersController : Controller
    {
        private readonly IMembersAppServices _membersAppServices;
        public MembersController(IMembersAppServices membersAppServices) {

            _membersAppServices = membersAppServices;

        }
        public IActionResult Index()
        {
            List<Member> members = _membersAppServices.GetMembers();
            MemberListViewModel viewModel = new MemberListViewModel();
            viewModel.Members = members;
            viewModel.NewMembersCount = 3;
            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Member member)
        {
            _membersAppServices.addMember(member);

            return RedirectToAction("Index");
        }



        public IActionResult Test()
        {
            return View();
        }
    }
}
