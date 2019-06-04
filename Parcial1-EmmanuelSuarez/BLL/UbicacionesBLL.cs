using Parcial1_EmmanuelSuarez.DAL;
using Parcial1_EmmanuelSuarez.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_EmmanuelSuarez.BLL
{
    class UbicacionesBLL
    {
        public static bool Guardar(Ubicaciones ubicacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if(db.Ubicacion.Add(ubicacion) != null)
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

        public static bool Modificar(Ubicaciones ubicacion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(ubicacion).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

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

        public static Ubicaciones Buscar(int id)
        {
            Ubicaciones ubicacion = new Ubicaciones();
            Contexto db = new Contexto();

            try
            {
                ubicacion = db.Ubicacion.Find(id);

            }catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return ubicacion;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Ubicaciones ubicacion = new Ubicaciones();

            try
            {
                ubicacion = db.Ubicacion.Find(id);
                db.Entry(ubicacion).State = EntityState.Deleted;

                paso = db.SaveChanges() > 0;
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

        public static List<Ubicaciones> GetList(Expression<Func<Ubicaciones, bool>> ubicacion)
        {
            List<Ubicaciones> lista = new List<Ubicaciones>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Ubicacion.Where(ubicacion).ToList();

            }catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return lista;
        }
        
        public static bool Duplicado(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if(db.Ubicacion.Any(p=> p.Descripcion.Equals(descripcion)))
                {
                    paso = true;
                }
            }catch(Exception)
            {
                throw;
            }



            return paso;
        }
    }
}
