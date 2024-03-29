﻿using GymManager.Core.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Member;

public class City
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Required]
    public string Name { get; set; }


    public List<Member> Members { get; set; }

    public City () {
        Members = new List<Member> ();
    }

}
