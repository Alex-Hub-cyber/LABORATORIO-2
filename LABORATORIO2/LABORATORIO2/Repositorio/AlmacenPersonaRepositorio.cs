using LABORATORIO2.Data;
using LABORATORIO2.Dominio;
using LABORATORIO2.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LABORATORIO2.Repositorio.AlmacenPersonaRepositorio;

namespace LABORATORIO2.Repositorio
{
    public class AlmacenPersonaRepositorio : IAlmacenPersona
    {
        private ApplicationDbContext app;
        public AlmacenPersonaRepositorio(ApplicationDbContext app)
        {

            this.app = app;
        }

      

        public void Insertar(AlmacenPersona c)
        {
            app.Update(c);
            app.Add(c);
            app.SaveChanges();
        }

      

        List<AlmacenPersona> IAlmacenPersona.ListarPersonas()
        {
            return app.almacenPersonas.ToList();
        }

      
    }
}