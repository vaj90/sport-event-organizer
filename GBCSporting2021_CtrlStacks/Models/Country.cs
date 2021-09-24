using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_CtrlStacks.Models
{
    public class Country
    {
        public int CountryId { get; set; }

        [Required(ErrorMessage = "Please enter a valid code"), StringLength(2), ]
        public string Code { get; set; }

        [Required(ErrorMessage = "Please enter a country name"), StringLength(100)]
        public string Name { get; set; }
    }
}
