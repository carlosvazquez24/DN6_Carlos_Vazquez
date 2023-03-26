using GymManager.Core.Members;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess.Repositories
{


    public class MembersRepository : Repository<int, Member>
    {

        // private readonly GymManagerContext _context;

        // protected GymManagerContext Context { get => _context; }

        public MembersRepository(GymManagerContext _gymManagerContext) : base(_gymManagerContext)
        {

        }

        public override async Task<Member> AddAsync(Member entity)
        {
            //Obtener la ciudad del contexto
            var city = await Context.Cities.FindAsync(entity.City.Id);

            //Obtener la membresia del contexto (en este caso es 1, indicando que no tiene membresia y su duración es de 0)
            var membership = await Context.MembershipTypes.FindAsync(1);

            //Una vez obtenidos los objetos mediante su id, se vuelven nulos los objetos
            entity.City = null;
            entity.MembershipType = null;

            //Se agrega la entidad a su lista
            await Context.Members.AddAsync(entity); //agregar entidad

            city.Members.Add(entity);    //A city, agregar el miembro
            membership.Members.Add(entity); //A la membresia agregarle el miembro a la lista de members

            await Context.SaveChangesAsync();

            return entity;
        }

        public override async Task<Member> GetAsync(int id)
        {
            var member = await Context.Members.Include(x => x.City).FirstOrDefaultAsync(x => x.Id == id);
            return member;
        }

        public override async Task<Member> UpdateAsync(Member entity)
        {
            //Obtener los objetos de las llaves foráneas
            var city = await Context.Cities.FindAsync(entity.City.Id);
            var membership = await Context.MembershipTypes.FindAsync(entity.Id);

            //Asignarle null
            entity.City = city;
            entity.MembershipType = membership;

            Context.Members.Update(entity);

            await Context.SaveChangesAsync();

            return entity;
        }





    }
    
}
