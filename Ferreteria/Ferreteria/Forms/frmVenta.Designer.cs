namespace Ferreteria.Forms
{
    partial class frmVenta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxFactura = new System.Windows.Forms.GroupBox();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.gboxCliente = new System.Windows.Forms.GroupBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.cboCodigoCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gboxProducto = new System.Windows.Forms.GroupBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.cboCuit = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gboxNuevoCliente = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gboxFactura.SuspendLayout();
            this.gboxCliente.SuspendLayout();
            this.gboxProducto.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.gboxNuevoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Factura";
            // 
            // gboxFactura
            // 
            this.gboxFactura.Controls.Add(this.lblFechaFactura);
            this.gboxFactura.Controls.Add(this.txtFecha);
            this.gboxFactura.Controls.Add(this.cboVendedor);
            this.gboxFactura.Controls.Add(this.lblVendedor);
            this.gboxFactura.Controls.Add(this.cboTipoFactura);
            this.gboxFactura.Controls.Add(this.label2);
            this.gboxFactura.Location = new System.Drawing.Point(13, 12);
            this.gboxFactura.Name = "gboxFactura";
            this.gboxFactura.Size = new System.Drawing.Size(605, 70);
            this.gboxFactura.TabIndex = 5;
            this.gboxFactura.TabStop = false;
            this.gboxFactura.Text = "Factura";
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.AutoSize = true;
            this.lblFechaFactura.Location = new System.Drawing.Point(14, 27);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(37, 13);
            this.lblFechaFactura.TabIndex = 15;
            this.lblFechaFactura.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(57, 24);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // cboVendedor
            // 
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(237, 24);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(195, 21);
            this.cboVendedor.TabIndex = 2;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(175, 27);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 14;
            this.lblVendedor.Text = "Vendedor";
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Location = new System.Drawing.Point(538, 24);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(61, 21);
            this.cboTipoFactura.TabIndex = 4;
            // 
            // gboxCliente
            // 
            this.gboxCliente.Controls.Add(this.cboCuit);
            this.gboxCliente.Controls.Add(this.lblCuitCliente);
            this.gboxCliente.Controls.Add(this.cboCodigoCliente);
            this.gboxCliente.Controls.Add(this.label3);
            this.gboxCliente.Location = new System.Drawing.Point(12, 88);
            this.gboxCliente.Name = "gboxCliente";
            this.gboxCliente.Size = new System.Drawing.Size(457, 65);
            this.gboxCliente.TabIndex = 6;
            this.gboxCliente.TabStop = false;
            this.gboxCliente.Text = "Cliente";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(9, 19);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(126, 26);
            this.btnAgregarCliente.TabIndex = 10;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // cboCodigoCliente
            // 
            this.cboCodigoCliente.FormattingEnabled = true;
            this.cboCodigoCliente.Location = new System.Drawing.Point(59, 23);
            this.cboCodigoCliente.Name = "cboCodigoCliente";
            this.cboCodigoCliente.Size = new System.Drawing.Size(239, 21);
            this.cboCodigoCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente";
            // 
            // gboxProducto
            // 
            this.gboxProducto.Controls.Add(this.btnAgregarProducto);
            this.gboxProducto.Controls.Add(this.cboProducto);
            this.gboxProducto.Controls.Add(this.txtCantidadProducto);
            this.gboxProducto.Controls.Add(this.lblCantidad);
            this.gboxProducto.Controls.Add(this.label5);
            this.gboxProducto.Location = new System.Drawing.Point(13, 159);
            this.gboxProducto.Name = "gboxProducto";
            this.gboxProducto.Size = new System.Drawing.Size(457, 65);
            this.gboxProducto.TabIndex = 9;
            this.gboxProducto.TabStop = false;
            this.gboxProducto.Text = "Producto";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(384, 20);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(61, 23);
            this.btnAgregarProducto.TabIndex = 8;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(70, 22);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(196, 21);
            this.cboProducto.TabIndex = 6;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(329, 22);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(46, 20);
            this.txtCantidadProducto.TabIndex = 7;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(272, 25);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Producto";
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Location = new System.Drawing.Point(521, 287);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(97, 50);
            this.btnQuitarProducto.TabIndex = 10;
            this.btnQuitarProducto.Text = "Quitar Producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.Location = new System.Drawing.Point(451, 501);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(167, 48);
            this.btnConfirmarVenta.TabIndex = 11;
            this.btnConfirmarVenta.Text = "Confirmar venta";
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(521, 231);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(97, 50);
            this.btnModificarProducto.TabIndex = 9;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 501);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 48);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(6, 16);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(77, 13);
            this.lblPrecioUnitario.TabIndex = 9;
            this.lblPrecioUnitario.Text = "Precio unitario:";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(6, 38);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(63, 13);
            this.lblPrecioTotal.TabIndex = 10;
            this.lblPrecioTotal.Text = "Precio total:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPrecioUnitario);
            this.groupBox4.Controls.Add(this.lblPrecioTotal);
            this.groupBox4.Location = new System.Drawing.Point(477, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 65);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Subtotal";
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Location = new System.Drawing.Point(304, 26);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(35, 13);
            this.lblCuitCliente.TabIndex = 12;
            this.lblCuitCliente.Text = "CUIT:";
            // 
            // cboCuit
            // 
            this.cboCuit.FormattingEnabled = true;
            this.cboCuit.Location = new System.Drawing.Point(345, 23);
            this.cboCuit.Name = "cboCuit";
            this.cboCuit.Size = new System.Drawing.Size(98, 21);
            this.cboCuit.TabIndex = 13;
            // 
            // gboxNuevoCliente
            // 
            this.gboxNuevoCliente.Controls.Add(this.btnAgregarCliente);
            this.gboxNuevoCliente.Location = new System.Drawing.Point(477, 88);
            this.gboxNuevoCliente.Name = "gboxNuevoCliente";
            this.gboxNuevoCliente.Size = new System.Drawing.Size(141, 65);
            this.gboxNuevoCliente.TabIndex = 14;
            this.gboxNuevoCliente.TabStop = false;
            this.gboxNuevoCliente.Text = "Nuevo cliente";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 555);
            this.Controls.Add(this.gboxNuevoCliente);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.gboxProducto);
            this.Controls.Add(this.gboxCliente);
            this.Controls.Add(this.gboxFactura);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gboxFactura.ResumeLayout(false);
            this.gboxFactura.PerformLayout();
            this.gboxCliente.ResumeLayout(false);
            this.gboxCliente.PerformLayout();
            this.gboxProducto.ResumeLayout(false);
            this.gboxProducto.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.gboxNuevoCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxFactura;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.GroupBox gboxCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.ComboBox cboCodigoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gboxProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblFechaFactura;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboCuit;
        private System.Windows.Forms.Label lblCuitCliente;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox gboxNuevoCliente;
    }
}