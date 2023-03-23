using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManager.Core.MeasureTypes;
using GymManager.Core.Inventories;

namespace GymManager.Core.ProductTypes
{
    public class ProductType
    {


        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        [Required]
        [StringLength(45)]
        public string Brand { get; set; }

        [Required]
        [Range(0, 100000)]
        public decimal Cost { get; set; }

        [Required]
        [Range(0, 100000)]
        public decimal Price { get; set; }



        public List<Inventory> Inventories { get; set; }


        public MeasureType MeasureType { get; set; }


        public ProductType()
        {
            Inventories = new List<Inventory>();
        }

    }
}
