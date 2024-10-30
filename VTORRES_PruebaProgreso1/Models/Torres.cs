using System.ComponentModel.DataAnnotations;

namespace VTORRES_PruebaProgreso1.Models
{
    public class Torres
    {
        [Key]
        public int Cedula { get; set; }
        [Required]
        [StringLength(10)]
        public decimal PrecioApagar { get; set; }
        [Range(100, 1000, ErrorMessage = "El precio no pueda bajar de los 100")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nombre es necesario")]
       public bool esChino { get; set; } = true;
        [Display(Name = "dia de compra")]
        public Celular celular { get; set; }
        public DateTime Diadecompra { get; set; } = DateTime.Now;
       
       
        
       
    }
}
