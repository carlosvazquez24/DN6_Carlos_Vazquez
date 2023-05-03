using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public  class VehiclesDataManager : IVehiclesDataManager
    {

        private readonly VehiclesDataContext _vehiclesDataContext;
        public VehiclesDataManager(VehiclesDataContext vehiclesDataContext)
        {
            _vehiclesDataContext = vehiclesDataContext;
        }


        public void Insert(Vehicle vehicle)
        {
            //Se obtienen los objetos a los que hace referencia con las llaves

            var make = _vehiclesDataContext.Makes.Find(vehicle.Make.Id);
            var model = _vehiclesDataContext.Models.Find(vehicle.Model.Id);

            //A los atributos del objeto de tipo model y make del nuevo vehiculo que se está ingresando,
            // se le asigna null para que no se tengan que poner los demás atributos manualmente

            vehicle.Model = null;
            vehicle.Make = null;

            _vehiclesDataContext.Vehicles.Add(vehicle);

            //Se agrega el nuevo vehiculo en las listas de los vehciulos de cada tabla referenciada

            model.Vehicles.Add(vehicle);
            make.Vehicles.Add(vehicle);


            _vehiclesDataContext.SaveChanges();

        }

        public void Update(Vehicle vehicle)
        {
            var make = _vehiclesDataContext.Makes.Find(vehicle.Make.Id);
            var model = _vehiclesDataContext.Models.Find(vehicle.Model.Id);

            var entity = _vehiclesDataContext.Vehicles.Find(vehicle.Id);

            entity.Model = model;
            entity.Make = make;
            entity.Year = vehicle.Year;
            _vehiclesDataContext.SaveChanges();

        }

        public Vehicle GetVehicle(int id)
        {
            var entity = _vehiclesDataContext.Vehicles.Find(id);
            return entity;

        }

        public void Delete(int id)
        {
            var entity = _vehiclesDataContext.Vehicles.Find(id);
            _vehiclesDataContext.Vehicles.Remove(entity);
            _vehiclesDataContext.SaveChanges();

        }


        public IList<Vehicle> GetAll()
        {
            return _vehiclesDataContext.Vehicles.ToList();


        }


    }
}
