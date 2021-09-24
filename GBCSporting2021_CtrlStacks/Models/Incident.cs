using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_CtrlStacks.Models
{
    public class Incident
    {
        public int IncidentId { get; set; }

        [Required(ErrorMessage = "Please select a customer"), ForeignKey("Customer")]
        public int? CustomerId { get; set; }

        [Required(ErrorMessage = "Please enter a product"), ForeignKey("Product")]
        public int? ProductId { get; set; }

        [Required(ErrorMessage = "Please enter a valid title"), StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a valid description"), StringLength(500)]
        public string Description { get; set; }

        [ForeignKey("Technician")]
        public int? TechnicianId { get; set; }

        [Required(ErrorMessage = "Please enter a valid date opened"),DataType(DataType.Date),Display(Name = "Date Opened")]
        public DateTime? DateOpened { get; set; }

        [DataType(DataType.Date), Display(Name = "Date Closed")]
        public DateTime? DateClosed { get; set; }

        //table connected
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Technician Technician { get; set; }
    }
}
