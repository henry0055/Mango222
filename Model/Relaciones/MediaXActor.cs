using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Relaciones
{
    public class MediaXActor

    {
        public int Id { get; set; }
        [ForeignKey("IdMedia")]
        public int IdMedia { get; set; }
        public Media media { get; set; }

        [ForeignKey("IdActor")]
        public int IdActor { get; set; }
        public Actor actor { get; set; }

    }
}
