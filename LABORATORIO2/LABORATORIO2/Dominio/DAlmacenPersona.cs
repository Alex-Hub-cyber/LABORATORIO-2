using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO2.Dominio
{
    public class AlmacenPersona
    {

        //KEY PARA LA BD USADO PARA LLAVE PRIMARIA
        //DATABASEGENERATED INCREMENTA ID 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public  int IdPersona { get; set; }
        [Required]
        [StringLength(50)]
        public string NombrePersona { get; set; }
        [Required]
        public int EdadPersona { get; set; }

        [Required]
        [StringLength(50)]
        public string DescripcionPersona { get; set; }





        

    }
}
