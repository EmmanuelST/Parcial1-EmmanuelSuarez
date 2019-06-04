using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_EmmanuelSuarez.Entidades
{
    class ValorTotalInventarios
    {
        [Key]
        public int ValorInventarioId { get; set; }
        public decimal ValorTotal { get; set; }

        public ValorTotalInventarios()
        {
            ValorInventarioId = 0;
            ValorTotal = 0;
        }

    }
}
