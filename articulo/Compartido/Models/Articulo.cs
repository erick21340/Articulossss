﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Models
{
    public class Articulo
    {

        [Key]
        public int ArticuloId { get; set; }

        [Required(ErrorMessage = "Descripcion obligatorio")]
        public string? Descripcion { get; set; }

        [Range(0.01, 1000000, ErrorMessage = "Ingrese un valor mayor a 0.01 y menor o igual a 1000000")]
        [Required(ErrorMessage = "Costo obligatorio")]
        public decimal Costo { get; set; }

        [Range(0, 100, ErrorMessage = "Solo se permite de 0 a 100")]
        [Required(ErrorMessage = "Ganancia obligatoria")]
        public decimal Ganancia { get; set; }

        [Range(0.01, 1000000, ErrorMessage = "Ingrese un valor mayor a 0.01 y menor o igual a 1000000")]
        [Required(ErrorMessage = "Precio obligatorio")]
        public decimal Precio { get; set; }

        public decimal Existencia { get; set; }
    }
}
