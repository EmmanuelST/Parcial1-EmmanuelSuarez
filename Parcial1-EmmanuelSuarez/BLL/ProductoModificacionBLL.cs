using Parcial1_EmmanuelSuarez.DAL;
using Parcial1_EmmanuelSuarez.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_EmmanuelSuarez.BLL
{
    class ProductoModificacionBLL
    {

        public static bool Guardar(ProductoModificaciones producto)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
               if(db.ProductoModificacion.Add(producto) != null)
                {
                    paso = db.SaveChanges() > 0;
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

        public static List<ProductoModificaciones> GetList(Expression<Func<ProductoModificaciones, bool>> producto)
        {
            List<ProductoModificaciones> Lista = new List<ProductoModificaciones>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.ProductoModificacion.Where(producto).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }


    }
}
