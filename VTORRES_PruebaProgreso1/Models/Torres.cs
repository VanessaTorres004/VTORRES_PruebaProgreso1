using System.ComponentModel.DataAnnotations;

namespace VTORRES_PruebaProgreso1.Models
{
    public class Torres
    {
        [Key]
        public int Cedula { get; set; }
        [Required]
        [StringLength(10)]
        public decimal Salario { get; set; }
        [Range(100, 10000, ErrorMessage = "El salario debe ser mensual, no anual")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nombre es necesario")]
       public bool Soltero { get; set; } 
        [Display(Name = "dia de compra")]
        public Celular Celular { get; set; }
        public DateTime Nacimiento{ get; set; } 
       
       
        
       
    }
}
