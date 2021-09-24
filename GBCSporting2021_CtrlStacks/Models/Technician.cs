using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_CtrlStacks.Models
{
    public class Technician
    {
        public int TechnicianId { get; set; }

        [Required(ErrorMessage = "Please enter a name"), StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a valid email"), StringLength(100), DataType(DataType.EmailAddress),
        RegularExpression(@"^\b[a-zA-Z0-9.%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}\b$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a valid phone"), StringLength(30)]
        public string Phone { get; set; }

    }
}
