using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StefanJativa_EvaluacionP1.Models;

namespace StefanJativa_EvaluacionP1.Data
{
    public class StefanJativa_EvaluacionP1Context : DbContext
    {
        public StefanJativa_EvaluacionP1Context (DbContextOptions<StefanJativa_EvaluacionP1Context> options)
            : base(options)
        {
        }

        public DbSet<StefanJativa_EvaluacionP1.Models.Persona> Persona { get; set; } = default!;
        public DbSet<StefanJativa_EvaluacionP1.Models.Telefono> Telefono { get; set; } = default!;
    }
}
