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
    class ValorTotalInventarioBLL
    {
        

        public static ValorTotalInventario Buscar()
        {
           
            Contexto db = new Contexto();
            ValorTotalInventario valor = new ValorTotalInventario();

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

        public static bool Guardar(ValorTotalInventario valor)
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
            
            ValorTotalInventario valor = new ValorTotalInventario()
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
        public static List<ValorTotalInventario> GetList(Expression<Func<ValorTotalInventario, bool>> valor)
        {
            List<ValorTotalInventario> Lista = new List<ValorTotalInventario>();
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
                lista = ProductoBLL.GetList(p => true);
                decimal total = 0;

                foreach (var obj in lista)
                {
                    total += obj.ValorInventario;
                }

                ValorTotalInventarioBLL.ModificarValor(total);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
