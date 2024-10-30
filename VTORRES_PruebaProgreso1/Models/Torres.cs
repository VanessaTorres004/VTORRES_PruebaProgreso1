using System.ComponentModel.DataAnnotations;

namespace VTORRES_PruebaProgreso1.Models
{
    public class Torres
    {
        [Key]
        public int Cedula { get; set; }
        [Required]
        [StringLength(10)]
        decimal PrecioApagar { get; set; }
        [Range(100, 1000, ErrorMessage = "El precio no pueda bajar de los 100")]

        string Nombre { get; set; }
        [Required(ErrorMessage = "El nombre es necesario")]
        bool esChino { get; set; } = true;
        [Display(Name = "dia de compra")]
        public DateTime Diadecompra { get; set; } = DateTime.Now;
        
       
        
       
    }
}
