using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class Comentario
    {

        public int Id { get; set; }
        public string contenido { get; set; }
        public DateTime fecha { get; set; }

        [ForeignKey("IdPersona")]
        public int IdPersona { get; set; }
        public Persona persona { get; set; }

        [ForeignKey("IdMedia")]
        public int IdMedia { get; set; }
        public Media media { get; set; }


    }
}
