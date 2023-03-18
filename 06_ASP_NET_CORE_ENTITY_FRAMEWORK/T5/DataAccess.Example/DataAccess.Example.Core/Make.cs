using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.Core
{
    public class Make
    {
        //The order of the code MATTERS, we have to write this code first


        //Then this, The requeridelenght affects the list

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string MakeName { get; set; }

        [Required]
        [StringLength(100)]
        public string Country { get; set; }


        public List<Vehicle> Vehicles { get; set; }

        public Make()
        {
            Vehicles = new List<Vehicle>();
        }




    }
}
