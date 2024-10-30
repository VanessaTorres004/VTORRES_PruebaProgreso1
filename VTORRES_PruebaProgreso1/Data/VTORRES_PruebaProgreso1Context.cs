using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VTORRES_PruebaProgreso1.Models;

namespace VTORRES_PruebaProgreso1.Data
{
    public class VTORRES_PruebaProgreso1Context : DbContext
    {
        public VTORRES_PruebaProgreso1Context (DbContextOptions<VTORRES_PruebaProgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<VTORRES_PruebaProgreso1.Models.Celular> Celular { get; set; } = default!;
        public DbSet<VTORRES_PruebaProgreso1.Models.Torres> Torres { get; set; } = default!;
       
    }
}
    

