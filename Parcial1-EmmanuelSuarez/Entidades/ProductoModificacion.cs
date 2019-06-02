using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_EmmanuelSuarez.Entidades
{
    class ProductoModificacion
    {
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaModificacion { get; set; }

        ProductoModificacion()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            FechaModificacion = DateTime.Now;
        }
    }
}
