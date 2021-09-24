using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_CtrlStacks.Models
{
    public class Registration
    {
        public int RegistrationId { get; set; }

        [Required, ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [Required, ForeignKey("Product")]
        public int ProductId { get; set; }

        //table connected
        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
