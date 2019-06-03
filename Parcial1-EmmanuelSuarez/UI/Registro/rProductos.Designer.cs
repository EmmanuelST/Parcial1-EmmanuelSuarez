namespace Parcial1_EmmanuelSuarez.UI.Registro
{
    partial class rProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.ExistencianumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CostonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ValorInventariotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.UbicacioncomboBox = new System.Windows.Forms.ComboBox();
            this.AgregarUbicacionbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistencianumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(115, 20);
            this.IdnumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(156, 20);
            this.IdnumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(115, 49);
            this.DescripciontextBox.MaxLength = 100;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(237, 20);
            this.DescripciontextBox.TabIndex = 3;
            // 
            // ExistencianumericUpDown
            // 
            this.ExistencianumericUpDown.Location = new System.Drawing.Point(115, 113);
            this.ExistencianumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ExistencianumericUpDown.Name = "ExistencianumericUpDown";
            this.ExistencianumericUpDown.Size = new System.Drawing.Size(156, 20);
            this.ExistencianumericUpDown.TabIndex = 4;
            this.ExistencianumericUpDown.ValueChanged += new System.EventHandler(this.ExistencianumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Existencia:";
            // 
            // CostonumericUpDown
            // 
            this.CostonumericUpDown.DecimalPlaces = 2;
            this.CostonumericUpDown.Location = new System.Drawing.Point(115, 150);
            this.CostonumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.CostonumericUpDown.Name = "CostonumericUpDown";
            this.CostonumericUpDown.Size = new System.Drawing.Size(156, 20);
            this.CostonumericUpDown.TabIndex = 5;
            this.CostonumericUpDown.ValueChanged += new System.EventHandler(this.CostonumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Costo:";
            // 
            // ValorInventariotextBox
            // 
            this.ValorInventariotextBox.Location = new System.Drawing.Point(115, 187);
            this.ValorInventariotextBox.Name = "ValorInventariotextBox";
            this.ValorInventariotextBox.ReadOnly = true;
            this.ValorInventariotextBox.Size = new System.Drawing.Size(156, 20);
            this.ValorInventariotextBox.TabIndex = 13;
            this.ValorInventariotextBox.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor en inventario:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ubicacion:";
            // 
            // UbicacioncomboBox
            // 
            this.UbicacioncomboBox.FormattingEnabled = true;
            this.UbicacioncomboBox.Location = new System.Drawing.Point(115, 82);
            this.UbicacioncomboBox.Name = "UbicacioncomboBox";
            this.UbicacioncomboBox.Size = new System.Drawing.Size(156, 21);
            this.UbicacioncomboBox.TabIndex = 15;
            // 
            // AgregarUbicacionbutton
            // 
            this.AgregarUbicacionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarUbicacionbutton.Image = global::Parcial1_EmmanuelSuarez.Properties.Resources.agregar2;
            this.AgregarUbicacionbutton.Location = new System.Drawing.Point(277, 73);
            this.AgregarUbicacionbutton.Name = "AgregarUbicacionbutton";
            this.AgregarUbicacionbutton.Size = new System.Drawing.Size(39, 36);
            this.AgregarUbicacionbutton.TabIndex = 16;
            this.AgregarUbicacionbutton.UseVisualStyleBackColor = true;
            this.AgregarUbicacionbutton.Click += new System.EventHandler(this.AgregarUbicacionbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Parcial1_EmmanuelSuarez.Properties.Resources.busqueda_pequeña;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(277, 14);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 31);
            this.Buscarbutton.TabIndex = 2;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Parcial1_EmmanuelSuarez.Properties.Resources.borrar_img;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(277, 236);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 55);
            this.Eliminarbutton.TabIndex = 8;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Parcial1_EmmanuelSuarez.Properties.Resources.nuevo_img;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(147, 236);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 55);
            this.Nuevobutton.TabIndex = 7;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Parcial1_EmmanuelSuarez.Properties.Resources.guardar_img__1_;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(15, 236);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 55);
            this.Guardarbutton.TabIndex = 6;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 311);
            this.Controls.Add(this.AgregarUbicacionbutton);
            this.Controls.Add(this.UbicacioncomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.ValorInventariotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CostonumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExistencianumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rProductos";
            this.Text = "Registro de Producto";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistencianumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.NumericUpDown ExistencianumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown CostonumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ValorInventariotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button AgregarUbicacionbutton;
        private System.Windows.Forms.ComboBox UbicacioncomboBox;
        private System.Windows.Forms.Label label6;
    }
}