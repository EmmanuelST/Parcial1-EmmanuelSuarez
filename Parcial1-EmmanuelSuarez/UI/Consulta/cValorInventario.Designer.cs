﻿namespace Parcial1_EmmanuelSuarez.UI.Consulta
{
    partial class cValorInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cValorInventario));
            this.label1 = new System.Windows.Forms.Label();
            this.ValorTotaltextBox = new System.Windows.Forms.TextBox();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Total de Inventario:";
            // 
            // ValorTotaltextBox
            // 
            this.ValorTotaltextBox.Location = new System.Drawing.Point(12, 44);
            this.ValorTotaltextBox.Name = "ValorTotaltextBox";
            this.ValorTotaltextBox.ReadOnly = true;
            this.ValorTotaltextBox.Size = new System.Drawing.Size(164, 20);
            this.ValorTotaltextBox.TabIndex = 1;
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Image = global::Parcial1_EmmanuelSuarez.Properties.Resources.recargar;
            this.Refreshbutton.Location = new System.Drawing.Point(182, 36);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(45, 34);
            this.Refreshbutton.TabIndex = 2;
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // cValorInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 80);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.ValorTotaltextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(255, 119);
            this.MinimumSize = new System.Drawing.Size(255, 119);
            this.Name = "cValorInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Valor total de inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValorTotaltextBox;
        private System.Windows.Forms.Button Refreshbutton;
    }
}