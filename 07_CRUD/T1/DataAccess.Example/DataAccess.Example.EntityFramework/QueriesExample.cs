using DataAccess.Example.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public class QueriesExample : IQueriesExample
    {

        private readonly VehiclesDataContext _vehiclesDatContext;
        public QueriesExample(VehiclesDataContext vehiclesDataContext) {
            _vehiclesDatContext= vehiclesDataContext;
        }

        public List<Make> GetMakes()
        {
            List<Make> makes = _vehiclesDatContext.Makes.Include(x => x.Vehicles).OrderBy(x => x.Country).ToList();

            return makes;
        }

        public List<Vehicle> GetVehiclesByPrice(decimal from_, decimal to)
        {

            //List<Vehicle> vehiclesInInventory = _vehiclesDatContext.Inventories.Where(x => x.Price >= from && x.Price <= to).Select(x => x.Vehicle).ToList();
            var vehicles = from inv in _vehiclesDatContext.Inventories
                           join v in _vehiclesDatContext.Vehicles on inv.Vehicle.Id equals v.Id
                           where inv.Price >= from_ && inv.Price <= to
                           select v;
            
            return vehicles.ToList();
        }

    }
}
