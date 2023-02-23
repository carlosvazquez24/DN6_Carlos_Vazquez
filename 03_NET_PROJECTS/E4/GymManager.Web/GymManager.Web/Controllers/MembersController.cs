using GymManager.ApplicationServices.Members;
using GymManager.Core.Member;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{

    [Authorize]

    public class MembersController : Controller
    {
        private readonly IMembersAppServices _membersAppServices;
        private readonly ILogger<MembersController> _logger;

        public MembersController(IMembersAppServices membersAppServices, ILogger<MembersController> logger1) {

            _membersAppServices = membersAppServices;
            _logger = logger1;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("Now you are in the Members Index");
            List<Member> members = _membersAppServices.GetMembers();
            MemberListViewModel viewModel = new MemberListViewModel();
            viewModel.Members = members;
            viewModel.NewMembersCount = 3;
            return View(viewModel);
        }

        public IActionResult Edit(int memberId)
        {
            Member member = _membersAppServices.getMember(memberId);
            return View(member);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int memberId)
        {
            _membersAppServices.deleteMember(memberId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(Member member)
        {
            _membersAppServices.addMember(member);

            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Edit(Member member)
        {
            _membersAppServices.editMember(member);

            return RedirectToAction("Index");
        }


        public IActionResult Test()
        {
            return View();
        }
    }
}
