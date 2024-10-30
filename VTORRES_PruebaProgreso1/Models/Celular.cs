using System.ComponentModel.DataAnnotations;

namespace VTORRES_PruebaProgreso1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Modelo { get; set; }
        [MaxLength (200)]
        [Required(ErrorMessage = "necesitas el modelo")]
        public int year { get; set;}
        [Required(ErrorMessage = "cual es el año?")]
 

        [Range(100, 1000, ErrorMessage = "El precio no pueda bajar de los 100")] 
        public decimal Precio { get; set; }
       
    }
}
