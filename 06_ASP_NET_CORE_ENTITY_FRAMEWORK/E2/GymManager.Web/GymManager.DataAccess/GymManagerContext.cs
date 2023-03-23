using GymManager.Core.EquipmentType;
using GymManager.Core.Inventories;
using GymManager.Core.MeasureTypes;
using GymManager.Core.Member;
using GymManager.Core.ProductTypes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class GymManagerContext : IdentityDbContext
    {

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Member> Members { get; set; }

        public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }

        public virtual DbSet<Inventory> Inventories { get; set; }

        public virtual DbSet<MeasureType> MeasureTypes { get; set; }

        public virtual DbSet<ProductType> ProductTypes { get; set; }

        public GymManagerContext(DbContextOptions<GymManagerContext>  options )  : base( options )
        {
        
        }
    }
}
