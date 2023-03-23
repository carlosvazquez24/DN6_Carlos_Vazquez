using GymManager.ApplicationServices.MembershipsTypes;
using GymManager.Core.MembershipsTypes;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    public class MembershipTypesController : Controller
    {
        private readonly IMembershipTypeAppService _membershipAppService;
        public MembershipTypesController(IMembershipTypeAppService membershipAppService) {
            _membershipAppService= membershipAppService;
        }


        public IActionResult Index()
        {
            List<MembershipType> memberships = _membershipAppService.GetMemberships();
            MembershipTypeListModel viewModel= new MembershipTypeListModel();
            viewModel.Memberships = memberships;
            return View(viewModel);
        }

        public IActionResult Create() {
            return View();
        }

        public IActionResult Edit(int membershipId)
        {
            MembershipType membership = _membershipAppService.getMembership(membershipId);
            return View(membership);
        }


        public IActionResult Delete(int membershipId)
        {
            _membershipAppService.removeMembership(membershipId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(MembershipType membership)
        {
            _membershipAppService.addMembership(membership);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Edit (MembershipType membership)
        {
            _membershipAppService.editMembership(membership);
            return RedirectToAction("Index");
        }
        
    }
}
