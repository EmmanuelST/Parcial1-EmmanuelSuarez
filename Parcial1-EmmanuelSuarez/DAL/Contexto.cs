using Parcial1_EmmanuelSuarez.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_EmmanuelSuarez.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Productos> Producto { get; set; }

        public Contexto():base("Constr")
        {

        }
    }
}
