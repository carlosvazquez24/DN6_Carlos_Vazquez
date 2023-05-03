using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public interface IColorsDataManager
    {

        public void Insert(Color color);

        public void Update(Color color);

        public Color GetColor(int id);

        public void Delete(int id);

        public IList<Color> GetAll();


    }
}
