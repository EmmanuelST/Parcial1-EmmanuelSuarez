﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_EmmanuelSuarez.Entidades
{
    class ValorTotalInventario
    {
        [Key]
        public int IdValorInventario { get; set; }
        public decimal ValorTotal { get; set; }

        public ValorTotalInventario()
        {
            IdValorInventario = 0;
            ValorTotal = 0;
        }

    }
}
