using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Torok_Erika.Models;

namespace Proiect_Torok_Erika.Data
{
    public class Proiect_Torok_ErikaContext : DbContext
    {
        public Proiect_Torok_ErikaContext (DbContextOptions<Proiect_Torok_ErikaContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Torok_Erika.Models.Client> Client { get; set; } = default!;

        public DbSet<Proiect_Torok_Erika.Models.Material> Material { get; set; }
    }
}
