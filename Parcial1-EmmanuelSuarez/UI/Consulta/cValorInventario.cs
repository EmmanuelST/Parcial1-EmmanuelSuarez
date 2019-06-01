using Parcial1_EmmanuelSuarez.BLL;
using Parcial1_EmmanuelSuarez.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_EmmanuelSuarez.UI.Consulta
{
    public partial class cValorInventario : Form
    {
        public cValorInventario()
        {
            InitializeComponent();
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            /* ValorTotalInventario valor = new ValorTotalInventario()
             { ValorInventarioId = 0,ValorTotal = 0 };

             try
             {
                 ValorTotalInventarioBLL.Guardar(valor);

             }catch(Exception)
             {
                 throw;
             }*/

            List<Productos> lista = new List<Productos>();

            try
            {
                lista = ProductoBLL.GetList(p=> true);
            }catch(Exception)
            {
                throw;
            }

            decimal total = 0;

            foreach(var obj in lista)
            {
                total += obj.ValorInventario;
            }

            ValorTotalInventarioBLL.ModificarValor(total);

            ValorTotaltextBox.Text =  ValorTotalInventarioBLL.Buscar().ValorTotal.ToString();

        }
    }
}
