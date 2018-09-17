namespace Ferreteria.Forms
{
    partial class frmNuevoTipoFactura
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
            this.txtNameTipoFactura = new System.Windows.Forms.TextBox();
            this.txtIdTipoFactura = new System.Windows.Forms.TextBox();
            this.lblNombreTipoFactura = new System.Windows.Forms.Label();
            this.lblIdTipoFactura = new System.Windows.Forms.Label();
            this.btnSaveTipoFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNameTipoFactura
            // 
            this.txtNameTipoFactura.Location = new System.Drawing.Point(73, 42);
            this.txtNameTipoFactura.Name = "txtNameTipoFactura";
            this.txtNameTipoFactura.Size = new System.Drawing.Size(206, 20);
            this.txtNameTipoFactura.TabIndex = 9;
            // 
            // txtIdTipoFactura
            // 
            this.txtIdTipoFactura.Enabled = false;
            this.txtIdTipoFactura.Location = new System.Drawing.Point(73, 6);
            this.txtIdTipoFactura.Name = "txtIdTipoFactura";
            this.txtIdTipoFactura.Size = new System.Drawing.Size(206, 20);
            this.txtIdTipoFactura.TabIndex = 8;
            // 
            // lblNombreTipoFactura
            // 
            this.lblNombreTipoFactura.AutoSize = true;
            this.lblNombreTipoFactura.Location = new System.Drawing.Point(12, 45);
            this.lblNombreTipoFactura.Name = "lblNombreTipoFactura";
            this.lblNombreTipoFactura.Size = new System.Drawing.Size(44, 13);
            this.lblNombreTipoFactura.TabIndex = 7;
            this.lblNombreTipoFactura.Text = "Nombre";
            // 
            // lblIdTipoFactura
            // 
            this.lblIdTipoFactura.AutoSize = true;
            this.lblIdTipoFactura.Location = new System.Drawing.Point(12, 9);
            this.lblIdTipoFactura.Name = "lblIdTipoFactura";
            this.lblIdTipoFactura.Size = new System.Drawing.Size(16, 13);
            this.lblIdTipoFactura.TabIndex = 6;
            this.lblIdTipoFactura.Text = "Id";
            // 
            // btnSaveTipoFactura
            // 
            this.btnSaveTipoFactura.Location = new System.Drawing.Point(12, 68);
            this.btnSaveTipoFactura.Name = "btnSaveTipoFactura";
            this.btnSaveTipoFactura.Size = new System.Drawing.Size(267, 33);
            this.btnSaveTipoFactura.TabIndex = 5;
            this.btnSaveTipoFactura.Text = "Guardar";
            this.btnSaveTipoFactura.UseVisualStyleBackColor = true;
            this.btnSaveTipoFactura.Click += new System.EventHandler(this.btnSaveTipoFactura_Click);
            // 
            // frmNuevoTipoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 109);
            this.Controls.Add(this.txtNameTipoFactura);
            this.Controls.Add(this.txtIdTipoFactura);
            this.Controls.Add(this.lblNombreTipoFactura);
            this.Controls.Add(this.lblIdTipoFactura);
            this.Controls.Add(this.btnSaveTipoFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNuevoTipoFactura";
            this.Text = "Tipo de factura";
            this.Load += new System.EventHandler(this.frmNuevoTipoFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameTipoFactura;
        private System.Windows.Forms.TextBox txtIdTipoFactura;
        private System.Windows.Forms.Label lblNombreTipoFactura;
        private System.Windows.Forms.Label lblIdTipoFactura;
        private System.Windows.Forms.Button btnSaveTipoFactura;
    }
}