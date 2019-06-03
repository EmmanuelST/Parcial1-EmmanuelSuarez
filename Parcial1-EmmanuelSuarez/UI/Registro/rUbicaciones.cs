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
    public partial class rUbicaciones : Form
    {
        public rUbicaciones()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            
            if (!validar())
                return;

            Ubicaciones ubicacion = new Ubicaciones();
            ubicacion = LlenarClase();

            try
            {
                if (UbicacionesBLL.Buscar((int)IdnumericUpDown.Value) != null)
                {
                    UbicacionesBLL.Modificar(ubicacion);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    if ((int)IdnumericUpDown.Value == 0)
                    {
                        UbicacionesBLL.Guardar(ubicacion);
                        MessageBox.Show("Guardaro exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar");
                    }
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un error en la operacion");
            }
        }

        private Ubicaciones LlenarClase()
        {
            Ubicaciones ubicacion = new Ubicaciones();

            DescripciontextBox.Text = DescripciontextBox.Text.Trim();

            ubicacion.UbicacionId = (int)IdnumericUpDown.Value;
            ubicacion.Descripcion = DescripciontextBox.Text;

            return ubicacion;
        }

        private void LlenarCampos(Ubicaciones ubicacion)
        {
            IdnumericUpDown.Value = ubicacion.UbicacionId;
            DescripciontextBox.Text = ubicacion.Descripcion;

        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text =string.Empty;
        }
        
        private bool validar()
        {
            bool paso = true;

            if(string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox,"Este campo no puede estar vacio");
                paso = false;
            }

            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdnumericUpDown.Value > 0)
                {
                    UbicacionesBLL.Eliminar((int)IdnumericUpDown.Value);
                    MessageBox.Show("Eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider.Clear();
                    errorProvider.SetError(IdnumericUpDown, "Este campo no puede ser 0");
                }
                Limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("algo falló al intentar eliminar ", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UbicacionesBLL.Buscar((int)IdnumericUpDown.Value) != null)
                {
                    LlenarCampos(UbicacionesBLL.Buscar((int)IdnumericUpDown.Value));
                }
                else
                {
                    MessageBox.Show("No se encontro la ubicacion", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception i)
            {

                MessageBox.Show("Hubo un Problema restaurando" + i.ToString(), "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
