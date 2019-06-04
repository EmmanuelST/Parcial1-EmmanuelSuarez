using Parcial1_EmmanuelSuarez.DAL;
using Parcial1_EmmanuelSuarez.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_EmmanuelSuarez.BLL
{
    class ValorTotalInventariosBLL
    {
        

        public static ValorTotalInventarios Buscar()
        {
           
            Contexto db = new Contexto();
            ValorTotalInventarios valor = new ValorTotalInventarios();

            try
            {
                valor = db.ValorTotalInventario.Find(1);
            }catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return valor;
        }

        public static bool Guardar(ValorTotalInventarios valor)
        {
            Contexto db = new Contexto();
            bool paso = false;
            try
            {
                if(db.ValorTotalInventario.Add(valor) != null)
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

        public static void ModificarValor(decimal total)
        {
            
            ValorTotalInventarios valor = new ValorTotalInventarios()
            { ValorInventarioId = 1,ValorTotal = total };

            Contexto db = new Contexto();

            try
            {
                db.Entry(valor).State = EntityState.Modified;
                db.SaveChanges();

            }catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

        }
        public static List<ValorTotalInventarios> GetList(Expression<Func<ValorTotalInventarios, bool>> valor)
        {
            List<ValorTotalInventarios> Lista = new List<ValorTotalInventarios>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.ValorTotalInventario.Where(valor).ToList();
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

        public static void Actualizar()
        {
            List<Productos> lista = new List<Productos>();

            try
            {
                lista = ProductosBLL.GetList(p => true);
                decimal total = 0;

                foreach (var obj in lista)
                {
                    total += obj.ValorInventario;
                }

                ValorTotalInventariosBLL.ModificarValor(total);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
