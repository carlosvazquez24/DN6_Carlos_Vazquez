using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public interface IVehiclesDataManager
    {


        public void Insert(Vehicle vehicle);

        public void Update(Vehicle vehicle);

        public Vehicle GetVehicle(int id);

        public void Delete(int id);

        public IList<Vehicle> GetAll();



    }
}
