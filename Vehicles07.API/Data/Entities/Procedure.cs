using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles07.API.Data.Entities
{
    public class Procedure
    {
        public int Id { get; set; }


        [Display(Name = "Tipo de vehiculo")]
        [MaxLength(50, ErrorMessage = "el campo no puede tener mas de {1} caractres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }


        [Display(Name = "Precio")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal Price { get; set; }

        public ICollection<Detail> Details { get; set; }
    }
}
