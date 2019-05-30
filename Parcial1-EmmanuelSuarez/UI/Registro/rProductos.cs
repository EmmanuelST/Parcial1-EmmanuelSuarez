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

namespace Parcial1_EmmanuelSuarez.UI.Registro
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            errorProvider.SetError(IdnumericUpDown,"Este campo no es valido");
            errorProvider.SetError(DescripciontextBox, "Este campo no es valido");
            errorProvider.SetError(CostonumericUpDown, "Este campo no es valido");
            errorProvider.SetError(ExistencianumericUpDown, "Este campo no es valido");
        }

        private bool validar()
        {
            bool paso = true;
            errorProvider.Clear();

            if(string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox,"Este campo no puede estar vacio");
                paso = false;
            }

            if((int)CostonumericUpDown.Value < 0)
            {
                errorProvider.SetError(CostonumericUpDown,"Este valor no puede estar en 0");
                paso = false;
            }

            if (ExistencianumericUpDown.Value == null)
            {
                errorProvider.SetError(ExistencianumericUpDown,"Este valor no puede estar vacio");
                paso = false;
            }

            return paso;
        }

        private Productos LlenarClase()
        {
            Productos producto = new Productos();

            producto.ProductoId = (int)IdnumericUpDown.Value;
            producto.Descripcion = DescripciontextBox.Text;
            producto.Existencia = (int)ExistencianumericUpDown.Value;
            producto.Costo = CostonumericUpDown.Value;

            return producto;
        }

        private void LlenarFormulario(Productos producto)
        {
            IdnumericUpDown.Value = producto.ProductoId;
            DescripciontextBox.Text = producto.Descripcion;
            ExistencianumericUpDown.Value = producto.Existencia;
            CostonumericUpDown.Value = producto.Costo;
        }
        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            ExistencianumericUpDown.Value = 0;
            CostonumericUpDown.Value =0;
        }
    }
}
