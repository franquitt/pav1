namespace Ferreteria.Forms
{
    partial class frmProvProd
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
            this.txtTiempo = new System.Windows.Forms.NumericUpDown();
            this.gboxProveedor = new System.Windows.Forms.GroupBox();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.gboxProducto = new System.Windows.Forms.GroupBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.txtBusquedaProducto = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtBusquedaProveedor = new System.Windows.Forms.TextBox();
            this.btnSaveAsociacion = new System.Windows.Forms.Button();
            this.btnDeleteAsociacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).BeginInit();
            this.gboxProveedor.SuspendLayout();
            this.gboxProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(140, 124);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(68, 20);
            this.txtTiempo.TabIndex = 2;
            // 
            // gboxProveedor
            // 
            this.gboxProveedor.Controls.Add(this.txtBusquedaProveedor);
            this.gboxProveedor.Controls.Add(this.cboProveedor);
            this.gboxProveedor.Location = new System.Drawing.Point(12, 68);
            this.gboxProveedor.Name = "gboxProveedor";
            this.gboxProveedor.Size = new System.Drawing.Size(394, 51);
            this.gboxProveedor.TabIndex = 5;
            this.gboxProveedor.TabStop = false;
            this.gboxProveedor.Text = "Proveedor";
            // 
            // cboProveedor
            // 
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(128, 18);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(260, 21);
            this.cboProveedor.TabIndex = 2;
            // 
            // gboxProducto
            // 
            this.gboxProducto.Controls.Add(this.cboProducto);
            this.gboxProducto.Controls.Add(this.txtBusquedaProducto);
            this.gboxProducto.Location = new System.Drawing.Point(12, 12);
            this.gboxProducto.Name = "gboxProducto";
            this.gboxProducto.Size = new System.Drawing.Size(394, 50);
            this.gboxProducto.TabIndex = 4;
            this.gboxProducto.TabStop = false;
            this.gboxProducto.Text = "Productos";
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(128, 20);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(260, 21);
            this.cboProducto.TabIndex = 1;
            // 
            // txtBusquedaProducto
            // 
            this.txtBusquedaProducto.Location = new System.Drawing.Point(7, 20);
            this.txtBusquedaProducto.Name = "txtBusquedaProducto";
            this.txtBusquedaProducto.Size = new System.Drawing.Size(115, 20);
            this.txtBusquedaProducto.TabIndex = 0;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(12, 126);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(127, 13);
            this.lblTiempo.TabIndex = 6;
            this.lblTiempo.Text = "Tiempo de entrega (dias):";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(214, 126);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(77, 13);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio unitario:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(297, 123);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(109, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // txtBusquedaProveedor
            // 
            this.txtBusquedaProveedor.Location = new System.Drawing.Point(7, 18);
            this.txtBusquedaProveedor.Name = "txtBusquedaProveedor";
            this.txtBusquedaProveedor.Size = new System.Drawing.Size(115, 20);
            this.txtBusquedaProveedor.TabIndex = 2;
            // 
            // btnSaveAsociacion
            // 
            this.btnSaveAsociacion.Location = new System.Drawing.Point(310, 149);
            this.btnSaveAsociacion.Name = "btnSaveAsociacion";
            this.btnSaveAsociacion.Size = new System.Drawing.Size(96, 40);
            this.btnSaveAsociacion.TabIndex = 9;
            this.btnSaveAsociacion.Text = "Guardar";
            this.btnSaveAsociacion.UseVisualStyleBackColor = true;
            this.btnSaveAsociacion.Click += new System.EventHandler(this.btnSaveAsociacion_Click);
            // 
            // btnDeleteAsociacion
            // 
            this.btnDeleteAsociacion.Location = new System.Drawing.Point(208, 149);
            this.btnDeleteAsociacion.Name = "btnDeleteAsociacion";
            this.btnDeleteAsociacion.Size = new System.Drawing.Size(96, 40);
            this.btnDeleteAsociacion.TabIndex = 10;
            this.btnDeleteAsociacion.Text = "Borrar";
            this.btnDeleteAsociacion.UseVisualStyleBackColor = true;
            this.btnDeleteAsociacion.Click += new System.EventHandler(this.btnDeleteAsociacion_Click);
            // 
            // frmProvProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 201);
            this.Controls.Add(this.btnDeleteAsociacion);
            this.Controls.Add(this.btnSaveAsociacion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.gboxProveedor);
            this.Controls.Add(this.gboxProducto);
            this.Controls.Add(this.txtTiempo);
            this.Name = "frmProvProd";
            this.Text = "Asociacion Proveedor - Producto";
            this.Load += new System.EventHandler(this.frmProvProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).EndInit();
            this.gboxProveedor.ResumeLayout(false);
            this.gboxProveedor.PerformLayout();
            this.gboxProducto.ResumeLayout(false);
            this.gboxProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown txtTiempo;
        private System.Windows.Forms.GroupBox gboxProveedor;
        private System.Windows.Forms.TextBox txtBusquedaProveedor;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.GroupBox gboxProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.TextBox txtBusquedaProducto;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnSaveAsociacion;
        private System.Windows.Forms.Button btnDeleteAsociacion;
    }
}