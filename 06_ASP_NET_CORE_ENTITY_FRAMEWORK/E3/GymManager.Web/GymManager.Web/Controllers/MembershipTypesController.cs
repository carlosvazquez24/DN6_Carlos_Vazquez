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


        public async Task<IActionResult> Index()
        {

            var memberships = await _membershipAppService.getMembershipsTypesAsync();
            MembershipTypeListModel model = new MembershipTypeListModel();
            model.Memberships = memberships;

            return View(model);
        }

        public IActionResult Create() {
            return View();
        }

        public async Task<IActionResult> Edit(int membershipId)
        {
            MembershipType membership = await  _membershipAppService.getMembershipTypeAsync(membershipId);
            return View(membership);
        }


        public async Task <IActionResult> Delete(int membershipId)
        {
            await _membershipAppService.deleteMembershipTypeAsync(membershipId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async  Task<IActionResult> Create(MembershipType membership)
        {
            await _membershipAppService.addMembershipTypeAsync(membership);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async  Task<IActionResult> Edit (MembershipType membership)
        {
            await _membershipAppService.editMembershipTypeAsync(membership);
            return RedirectToAction("Index");
        }
        
    }
}
