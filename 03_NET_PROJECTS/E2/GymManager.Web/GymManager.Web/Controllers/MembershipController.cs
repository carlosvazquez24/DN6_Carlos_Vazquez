using GymManager.ApplicationServices.Memberships;
using GymManager.Core.Memberships;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    public class MembershipController : Controller
    {
        private readonly IMembershipAppService _membershipAppService;
        public MembershipController(IMembershipAppService membershipAppService) {
            _membershipAppService= membershipAppService;
        }


        public IActionResult Index()
        {
            List<Membership> memberships = _membershipAppService.GetMemberships();
            MembershipListModel viewModel= new MembershipListModel();
            viewModel.Memberships = memberships;
            return View(viewModel);
        }

        public IActionResult Create() {
            return View();
        }

        public IActionResult Edit(int membershipId)
        {
            Membership membership = _membershipAppService.getMembership(membershipId);
            return View(membership);
        }


        public IActionResult Delete(int membershipId)
        {
            _membershipAppService.removeMembership(membershipId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(Membership membership)
        {
            _membershipAppService.addMembership(membership);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Edit (Membership membership)
        {
            _membershipAppService.editMembership(membership);
            return RedirectToAction("Index");
        }
        
    }
}
