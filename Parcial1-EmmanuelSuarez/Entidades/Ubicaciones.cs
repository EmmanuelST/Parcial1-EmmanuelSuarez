﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_EmmanuelSuarez.Entidades
{
    
    class Ubicaciones
    {
        [Key]
        public int UbicacionId { get; set; }
        public string Descripcion { get; set; }

        Ubicaciones()
        {
            UbicacionId = 0;
            Descripcion = string.Empty;
        }

    }
}