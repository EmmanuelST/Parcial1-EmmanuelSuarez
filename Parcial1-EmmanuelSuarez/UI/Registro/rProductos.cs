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

            if (!Validar())
                return;
            Productos producto = new Productos();
            producto = LlenarClase();

            try
            {
                if (ProductoBLL.Exist((int)IdnumericUpDown.Value))
                {
                    ProductoBLL.Modificar(producto);
                    MessageBox.Show("Modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(IdnumericUpDown.Value == 0)
                    {
                        ProductoBLL.Guardar(producto);
                        MessageBox.Show("Guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un error al intentar guardar el producto","Fallo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            Limpiar();
        }

        private bool Validar()
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

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductoBLL.Exist((int)IdnumericUpDown.Value))
                {
                    LlenarFormulario(ProductoBLL.Buscar((int)IdnumericUpDown.Value));
                }else
                {
                    MessageBox.Show("No se encontro el producto", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception i)
            {
               
               MessageBox.Show("Hubo un Problema restaurando"+i.ToString(),"Fallo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if(IdnumericUpDown.Value > 0)
                {
                    ProductoBLL.Eliminar((int)IdnumericUpDown.Value);
                    MessageBox.Show("Eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    errorProvider.Clear();
                    errorProvider.SetError(IdnumericUpDown,"Este campo no puede ser 0");
                }
                Limpiar();
            }
            catch(Exception)
            {
                MessageBox.Show("algo falló al intentar eliminar ", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExistencianumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValorInventariotextBox.Text = ValorInventario().ToString();
        }

        private decimal ValorInventario()
        {

            return CostonumericUpDown.Value * ExistencianumericUpDown.Value;
        }

        private void CostonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValorInventariotextBox.Text = ValorInventario().ToString();
        }
    }
}
