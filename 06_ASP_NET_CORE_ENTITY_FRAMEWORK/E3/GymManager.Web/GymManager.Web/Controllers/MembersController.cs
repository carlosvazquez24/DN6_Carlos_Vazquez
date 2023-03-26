using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.MembershipsTypes;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GymManager.Web.Controllers
{

    [Authorize]

    public class MembersController : Controller
    {
        private readonly IMembersAppServices _membersAppServices;
        private readonly IMembershipTypeAppService _membershipTypeAppService;
        private readonly ILogger<MembersController> _logger;

        public MembersController(IMembersAppServices membersAppServices, ILogger<MembersController> logger1, IMembershipTypeAppService membershipTypeAppService) {
            _membershipTypeAppService = membershipTypeAppService;
            _membersAppServices = membersAppServices;
            _logger = logger1;
        }
        public async Task<IActionResult> Index(string buscar)
        {
            _logger.LogInformation("-----------------------------------------------------------");
            _logger.LogInformation("***********  Now you are in the Members Index   ***********");
            _logger.LogInformation("-----------------------------------------------------------");


            //Obtener los miembros de la base de datos
            var members = await _membersAppServices.GetAllMembersAsync();

            //Hacer la busqueda de miembros si se le ingreso un string a buscar
            if (!String.IsNullOrEmpty(buscar))
            {
                buscar = buscar.ToLower();
                buscar = buscar.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u");

                members = members.Where(x => x.Name!.ToLower().Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u").Contains(buscar) ||
                x.LastName!.ToLower().Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u").Contains(buscar)).ToList();
            }



            //Crear objeto de tipo lista de mimebros para la vista
            MemberListViewModel viewModel = new MemberListViewModel();

            //Se obtiene el número de miembros
            viewModel.NewMembersCount = members.Count;

            //Se le asigna la lista de miembros de la bdd a la lista del objeto viewModel
            viewModel.Members = members;
            return View(viewModel);

        }

        public async Task<IActionResult> Edit(int memberId)
        {
            Member member = await _membersAppServices.GetMemberAsync(memberId);

            MemberViewModel miembroTransformado = new MemberViewModel
            {
                Id = member.Id,
                Name = member.Name,
                LastName = member.LastName,
                BirthDay = member.BirthDay,
                Email = member.Email,
                CityId = member.City.Id
            };
    
            return View(miembroTransformado);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Delete(int memberId)
        {
            await _membersAppServices.DeleteMemberAsync(memberId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Create(MemberViewModel model)
        {
            Member member = new Member
            {
                //Id = model.Id,
                Name = model.Name,
                LastName = model.LastName,
                BirthDay = model.BirthDay,
                Email = model.Email,
                AllowNewsletter = model.AllowNewsletter,
                City = new City
                {
                    Id = model.CityId
                },
                MembershipType = await _membershipTypeAppService.GetMembershipTypeAsync(1)
            };
            await _membersAppServices.AddMemberAsync(member);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> Edit(MemberViewModel model)
        {
            Member member = new Member
            {
                Id = model.Id,
                Name = model.Name,
                LastName = model.LastName,
                BirthDay = model.BirthDay,
                Email = model.Email,
                AllowNewsletter = model.AllowNewsletter,
                City = new City
                {
                    Id = model.CityId
                }
            };
            await _membersAppServices.EditMemberAsync(member);
            return RedirectToAction("Index");
        }


        public IActionResult Test()
        {
            return View();
        }
    }
}
