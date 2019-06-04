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
        List<Ubicaciones> ubicaciones;

        public rProductos()
        {
            InitializeComponent();
            LlenarUbicaciones();
        }

        private void LlenarUbicaciones()
        {
            try
            {
                ubicaciones = new List<Ubicaciones>();
                ubicaciones = UbicacionesBLL.GetList(p => true);

                UbicacioncomboBox.DataSource = ubicaciones;
                UbicacioncomboBox.ValueMember = "UbicacionId";
                UbicacioncomboBox.DisplayMember = "Descripcion";
  
            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un erro obteniendo las ubicaciones");
            }
            
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
               
                    ProductoModificacionBLL.Guardar(new ProductoModificaciones()
                    { ProductoId = producto.ProductoId,Descripcion = producto.Descripcion, FechaModificacion = DateTime.Now });

                    MessageBox.Show("Modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    if(IdnumericUpDown.Value == 0)
                    {
                        ProductoBLL.Guardar(producto);
                        MessageBox.Show("Guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        errorProvider.Clear();
                        errorProvider.SetError(IdnumericUpDown,"Este campo debe ser cero para poder guardar un nuevo producto");
                    }
                    
                }
            }
            catch(Exception)
            {
               
                MessageBox.Show("Hubo un error al intentar guardar el producto","Fallo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();

            if(string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox,"Este campo no puede estar vacio");
                paso = false;
            }

            if((int)CostonumericUpDown.Value <= 0)
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
            DescripciontextBox.Text = DescripciontextBox.Text.Trim();
            producto.ProductoId = (int)IdnumericUpDown.Value;
            producto.Descripcion = DescripciontextBox.Text;
            producto.Existencia = (int)ExistencianumericUpDown.Value;
            producto.Costo = CostonumericUpDown.Value;
            producto.ValorInventario = Convert.ToDecimal(ValorInventariotextBox.Text);

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

        private void AgregarUbicacionbutton_Click(object sender, EventArgs e)
        {
            rUbicaciones rUbicacion = new rUbicaciones();
            rUbicacion.ShowDialog();
            LlenarUbicaciones();
        }
    }
}
