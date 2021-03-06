﻿using Parcial1_EmmanuelSuarez.BLL;
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
            ObtenerTotal();
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {

            ObtenerTotal();
            
        }

        private void ObtenerTotal()
        {
            ValorTotalInventarios valor = new ValorTotalInventarios();

            try
            {
                if(ValorTotalInventariosBLL.Buscar() != null)
                {
                    ValorTotalInventariosBLL.Actualizar();
                    valor = ValorTotalInventariosBLL.Buscar();
                }
                else
                {
                    valor = new ValorTotalInventarios() { ValorTotal = 0};
                    ValorTotalInventariosBLL.Guardar(valor);
                    ValorTotalInventariosBLL.Actualizar();
                    valor = ValorTotalInventariosBLL.Buscar();
                }
                
            }
            catch(Exception)
            {
                MessageBox.Show("Hobo un error obteniendo la información");
            }

            ValorTotaltextBox.Text = valor.ValorTotal.ToString();

        }
    }
}
