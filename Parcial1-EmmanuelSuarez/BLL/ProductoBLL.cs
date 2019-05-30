using Parcial1_EmmanuelSuarez.DAL;
using Parcial1_EmmanuelSuarez.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_EmmanuelSuarez.BLL
{
    public class ProductoBLL
    {

        public static bool Guardar(Productos producto)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if(db.Producto.Add(producto) != null)
                {
                    paso = (db.SaveChanges() > 0);
                }

            }catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }


    }
}
