﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RegistroDeOrdenes.Entidades
{
    public class Rol
    {
        [Key]
        public int RolId { get; set; }
        public string Descripcion { get; set; }
        public bool esActivo { get; set; }

        [ForeignKey("RolId")]

        public virtual List<RolDetalle> RolDetalle { get; set; }

        public Rol()
        {
            RolId = 0;
            Descripcion = "";

            RolDetalle = new List<RolDetalle>();
        }

    }
}
