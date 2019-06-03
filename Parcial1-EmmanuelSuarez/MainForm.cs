using Parcial1_EmmanuelSuarez.Entidades;
using Parcial1_EmmanuelSuarez.UI.Consulta;
using Parcial1_EmmanuelSuarez.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_EmmanuelSuarez
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos rProductos = new rProductos();
            rProductos.MdiParent = this;
            rProductos.Show();
        }

        private void ValorTotalDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cValorInventario valor = new cValorInventario();
            valor.MdiParent = this;
            valor.Show();
        }

        private void ModificaciónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cModificacionProducto modificacionProducto = new cModificacionProducto();
            modificacionProducto.MdiParent = this;
            modificacionProducto.Show();
        }

        private void UbicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUbicaciones rUbicacion = new rUbicaciones();
            rUbicacion.MdiParent = this;
            rUbicacion.Show();
        }
    }
}
