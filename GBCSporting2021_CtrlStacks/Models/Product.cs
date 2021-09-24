using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_CtrlStacks.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter a valid code"), StringLength(10)]
        public string Code { get; set; }

        [Required(ErrorMessage = "Please enter a product name"), StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a valid year price"), DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public double? YearlyPrice { get; set; }

        [Required(ErrorMessage = "Please enter a valid release date"),DataType(DataType.Date), Display(Name = "Release Date")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? ReleaseDate { get; set; }
    }
}
