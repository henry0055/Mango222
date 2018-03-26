using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Relaciones
{
    public class MediaXCategoria
    {
        public int Id { get; set; }

        [ForeignKey("IdMedia")]
        public int IdMedia { get; set; }
        public Media media { get; set; }

        [ForeignKey("IdCategoria")]
        public int IdCategoria { get; set; }
        public Categoria categoria { get; set; }

    }
}
