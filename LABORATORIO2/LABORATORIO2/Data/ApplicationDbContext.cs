using LABORATORIO2.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO2.Data
{
    public class ApplicationDbContext :DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {


        }
        public DbSet<AlmacenPersona>almacenPersonas{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        internal void Add(Func<Task<IActionResult>> guardarInformacion)
        {
            throw new NotImplementedException();
        }
    }
}
