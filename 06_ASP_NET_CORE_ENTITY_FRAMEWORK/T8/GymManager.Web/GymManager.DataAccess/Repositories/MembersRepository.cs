using GymManager.Core.Member;
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
            entity.City = null;
            await Context.Members.AddAsync(entity); //agregar entidad
            city.Members.Add(entity);    //A city, agregar el miembro

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
            var city = await Context.Cities.FindAsync(entity.City.Id);
            entity.City = city;

            Context.Members.Update(entity);

            await Context.SaveChangesAsync();

            return entity;
        }





    }
    
}
