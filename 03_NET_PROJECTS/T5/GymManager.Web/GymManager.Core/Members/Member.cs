using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Member
{
    public class Member
    {

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }



        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }


        [EmailAddress]
        [Required]
        public string Email { get; set; }


        [Range(1, 100)]
        [Required]
        public int CityId { get; set; }

        public Boolean AllowNewsletter { get; set; }
    }
}
