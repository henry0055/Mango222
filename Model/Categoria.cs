using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public string NombreCategoria { get; set; }

    }
}
