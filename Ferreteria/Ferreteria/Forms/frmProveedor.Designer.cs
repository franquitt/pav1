namespace Ferreteria.Forms
{
    partial class frmProveedor
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
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.lblApellidoProveedor = new System.Windows.Forms.Label();
            this.lblDireccionProveedor = new System.Windows.Forms.Label();
            this.lblTelefonoProveedor = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtApellidoProveedor = new System.Windows.Forms.TextBox();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.btnDeleteProveedor = new System.Windows.Forms.Button();
            this.btnSaveProveedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(12, 9);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProveedor.TabIndex = 0;
            this.lblNombreProveedor.Text = "Nombre";
            // 
            // lblApellidoProveedor
            // 
            this.lblApellidoProveedor.AutoSize = true;
            this.lblApellidoProveedor.Location = new System.Drawing.Point(12, 35);
            this.lblApellidoProveedor.Name = "lblApellidoProveedor";
            this.lblApellidoProveedor.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoProveedor.TabIndex = 1;
            this.lblApellidoProveedor.Text = "Apellido";
            // 
            // lblDireccionProveedor
            // 
            this.lblDireccionProveedor.AutoSize = true;
            this.lblDireccionProveedor.Location = new System.Drawing.Point(12, 61);
            this.lblDireccionProveedor.Name = "lblDireccionProveedor";
            this.lblDireccionProveedor.Size = new System.Drawing.Size(52, 13);
            this.lblDireccionProveedor.TabIndex = 2;
            this.lblDireccionProveedor.Text = "Direccion";
            // 
            // lblTelefonoProveedor
            // 
            this.lblTelefonoProveedor.AutoSize = true;
            this.lblTelefonoProveedor.Location = new System.Drawing.Point(12, 87);
            this.lblTelefonoProveedor.Name = "lblTelefonoProveedor";
            this.lblTelefonoProveedor.Size = new System.Drawing.Size(49, 13);
            this.lblTelefonoProveedor.TabIndex = 3;
            this.lblTelefonoProveedor.Text = "Teléfono";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(68, 6);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(191, 20);
            this.txtNombreProveedor.TabIndex = 4;
            // 
            // txtApellidoProveedor
            // 
            this.txtApellidoProveedor.Location = new System.Drawing.Point(68, 32);
            this.txtApellidoProveedor.Name = "txtApellidoProveedor";
            this.txtApellidoProveedor.Size = new System.Drawing.Size(191, 20);
            this.txtApellidoProveedor.TabIndex = 5;
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(68, 58);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(191, 20);
            this.txtDireccionProveedor.TabIndex = 6;
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(68, 84);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(191, 20);
            this.txtTelefonoProveedor.TabIndex = 7;
            // 
            // btnDeleteProveedor
            // 
            this.btnDeleteProveedor.Location = new System.Drawing.Point(68, 110);
            this.btnDeleteProveedor.Name = "btnDeleteProveedor";
            this.btnDeleteProveedor.Size = new System.Drawing.Size(92, 45);
            this.btnDeleteProveedor.TabIndex = 13;
            this.btnDeleteProveedor.Text = "Dar de baja";
            this.btnDeleteProveedor.UseVisualStyleBackColor = true;
            this.btnDeleteProveedor.Click += new System.EventHandler(this.btnDeleteProveedor_Click);
            // 
            // btnSaveProveedor
            // 
            this.btnSaveProveedor.Location = new System.Drawing.Point(167, 110);
            this.btnSaveProveedor.Name = "btnSaveProveedor";
            this.btnSaveProveedor.Size = new System.Drawing.Size(92, 45);
            this.btnSaveProveedor.TabIndex = 14;
            this.btnSaveProveedor.Text = "Guardar";
            this.btnSaveProveedor.UseVisualStyleBackColor = true;
            this.btnSaveProveedor.Click += new System.EventHandler(this.btnSaveProveedor_Click);
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 165);
            this.Controls.Add(this.btnSaveProveedor);
            this.Controls.Add(this.btnDeleteProveedor);
            this.Controls.Add(this.txtTelefonoProveedor);
            this.Controls.Add(this.txtDireccionProveedor);
            this.Controls.Add(this.txtApellidoProveedor);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.lblTelefonoProveedor);
            this.Controls.Add(this.lblDireccionProveedor);
            this.Controls.Add(this.lblApellidoProveedor);
            this.Controls.Add(this.lblNombreProveedor);
            this.Name = "frmProveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.Label lblApellidoProveedor;
        private System.Windows.Forms.Label lblDireccionProveedor;
        private System.Windows.Forms.Label lblTelefonoProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtApellidoProveedor;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Button btnDeleteProveedor;
        private System.Windows.Forms.Button btnSaveProveedor;
    }
}