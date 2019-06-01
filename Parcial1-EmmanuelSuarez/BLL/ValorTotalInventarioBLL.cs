using Parcial1_EmmanuelSuarez.DAL;
using Parcial1_EmmanuelSuarez.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_EmmanuelSuarez.BLL
{
    class ValorTotalInventarioBLL
    {
        

        public static void Modificar()
        {
            SqlConnection sn = new SqlConnection(@"Data Source =.\SQLEXPRESS; user = sa; password =  Initial Catalog = Parcial1_db; Integrated Security = True");

            string query = @"update ValorTotalInventario set ValorTotal =(select SUM(ValorTotal) from Parcial1_db.Productos)
                            where ValorTotalId = 1;";

            SqlCommand sc = new SqlCommand(query,sn);

            sc.ExecuteNonQuery();
            sn.Close();

        }

        public static decimal Buscar()
        {
            SqlConnection sn = new SqlConnection(@"Data Source =.\SQLEXPRESS; user = sa; password =  Initial Catalog = Parcial1_db; Integrated Security = True");
            decimal valor = 0;
            string query = @"SELECT ValorTotal FROM Parcial1.ValorTotalInventario"
                            +"Where ValorTotalId = 1";

            SqlCommand sc = new SqlCommand(query, sn);

            valor = Convert.ToDecimal(sc.ExecuteScalar());
            sn.Close();

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
    }
}
