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
    public partial class cModificacionProducto : Form
    {
        public cModificacionProducto()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var lista = new List<ProductoModificaciones>();

            if(CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Todo
                     
                        lista = ProductoModificacionBLL.GetList(p => true);
                        break;

                    case 1://ID
                       
                        int id = Convert.ToInt32(CriteriotextBox.Text.Trim());
                        lista = ProductoModificacionBLL.GetList(p => p.ProductoId == id);
                        break;

                    case 2://Descripcion
                        
                        lista = ProductoModificacionBLL.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                        break;
                }

                lista = lista.Where(c => c.FechaModificacion >= DesdedateTimePicker.Value.Date && c.FechaModificacion <= HastadateTimePicker.Value.Date).ToList();

            }
            else
            {
                lista = ProductoModificacionBLL.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = lista;
        }
    }
}
