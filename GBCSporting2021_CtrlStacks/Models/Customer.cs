using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_CtrlStacks.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please enter a valid first name"), StringLength(100)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a valid last name"), StringLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a valid address"), StringLength(200)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a valid city"), StringLength(50)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a valid state"), StringLength(50)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a valid postal code"), StringLength(20)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Please select a country"), ForeignKey("Country")]
        public int? CountryId { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }


        public Country Country { get; set; }

    }
}
