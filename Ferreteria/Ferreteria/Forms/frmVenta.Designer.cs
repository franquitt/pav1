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
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxFactura = new System.Windows.Forms.GroupBox();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.gboxCliente = new System.Windows.Forms.GroupBox();
            this.txtBusquedaCliente = new System.Windows.Forms.TextBox();
            this.cboCuit = new System.Windows.Forms.ComboBox();
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.gboxProducto = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtCantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.txtBusquedaProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gboxNuevoCliente = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gBoxImporte = new System.Windows.Forms.GroupBox();
            this.lblTotalNeto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBusquedaCuit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.gboxFactura.SuspendLayout();
            this.gboxCliente.SuspendLayout();
            this.gboxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadProducto)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.gboxNuevoCliente.SuspendLayout();
            this.gBoxImporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.cantidad,
            this.precioUnitario,
            this.subtotal});
            this.gridProductos.Location = new System.Drawing.Point(12, 286);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.Size = new System.Drawing.Size(502, 264);
            this.gridProductos.TabIndex = 0;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "Id";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Producto";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precioUnitario
            // 
            this.precioUnitario.HeaderText = "Precio Unitario";
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
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
            this.lblFechaFactura.Location = new System.Drawing.Point(7, 27);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(37, 13);
            this.lblFechaFactura.TabIndex = 15;
            this.lblFechaFactura.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(50, 24);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(67, 20);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // cboVendedor
            // 
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(182, 24);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(273, 21);
            this.cboVendedor.TabIndex = 2;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(123, 27);
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
            this.gboxCliente.Controls.Add(this.txtBusquedaCuit);
            this.gboxCliente.Controls.Add(this.txtBusquedaCliente);
            this.gboxCliente.Controls.Add(this.cboCuit);
            this.gboxCliente.Controls.Add(this.lblCuitCliente);
            this.gboxCliente.Controls.Add(this.cboCliente);
            this.gboxCliente.Controls.Add(this.label3);
            this.gboxCliente.Location = new System.Drawing.Point(12, 88);
            this.gboxCliente.Name = "gboxCliente";
            this.gboxCliente.Size = new System.Drawing.Size(457, 79);
            this.gboxCliente.TabIndex = 6;
            this.gboxCliente.TabStop = false;
            this.gboxCliente.Text = "Cliente";
            // 
            // txtBusquedaCliente
            // 
            this.txtBusquedaCliente.Location = new System.Drawing.Point(51, 23);
            this.txtBusquedaCliente.Name = "txtBusquedaCliente";
            this.txtBusquedaCliente.Size = new System.Drawing.Size(256, 20);
            this.txtBusquedaCliente.TabIndex = 14;
            this.txtBusquedaCliente.TextChanged += new System.EventHandler(this.txtBusquedaCliente_TextChanged);
            // 
            // cboCuit
            // 
            this.cboCuit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuit.FormattingEnabled = true;
            this.cboCuit.Location = new System.Drawing.Point(353, 49);
            this.cboCuit.Name = "cboCuit";
            this.cboCuit.Size = new System.Drawing.Size(98, 21);
            this.cboCuit.TabIndex = 13;
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Location = new System.Drawing.Point(313, 26);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(35, 13);
            this.lblCuitCliente.TabIndex = 12;
            this.lblCuitCliente.Text = "CUIT:";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(51, 49);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(256, 21);
            this.cboCliente.TabIndex = 5;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(6, 26);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(126, 26);
            this.btnAgregarCliente.TabIndex = 10;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // gboxProducto
            // 
            this.gboxProducto.Controls.Add(this.lblStock);
            this.gboxProducto.Controls.Add(this.txtCantidadProducto);
            this.gboxProducto.Controls.Add(this.txtBusquedaProducto);
            this.gboxProducto.Controls.Add(this.btnAgregarProducto);
            this.gboxProducto.Controls.Add(this.cboProducto);
            this.gboxProducto.Controls.Add(this.lblCantidad);
            this.gboxProducto.Controls.Add(this.label5);
            this.gboxProducto.Location = new System.Drawing.Point(13, 173);
            this.gboxProducto.Name = "gboxProducto";
            this.gboxProducto.Size = new System.Drawing.Size(457, 79);
            this.gboxProducto.TabIndex = 9;
            this.gboxProducto.TabStop = false;
            this.gboxProducto.Text = "Producto";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(275, 48);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 13);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "Stock: ";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(327, 22);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(57, 20);
            this.txtCantidadProducto.TabIndex = 10;
            this.txtCantidadProducto.ValueChanged += new System.EventHandler(this.txtCantidadProducto_TextChanged);
            // 
            // txtBusquedaProducto
            // 
            this.txtBusquedaProducto.Location = new System.Drawing.Point(62, 22);
            this.txtBusquedaProducto.Name = "txtBusquedaProducto";
            this.txtBusquedaProducto.Size = new System.Drawing.Size(204, 20);
            this.txtBusquedaProducto.TabIndex = 9;
            this.txtBusquedaProducto.TextChanged += new System.EventHandler(this.txtBusquedaProducto_TextChanged);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(390, 19);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(61, 23);
            this.btnAgregarProducto.TabIndex = 8;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(62, 48);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(204, 21);
            this.cboProducto.TabIndex = 6;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
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
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Producto";
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Location = new System.Drawing.Point(521, 286);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(97, 50);
            this.btnQuitarProducto.TabIndex = 10;
            this.btnQuitarProducto.Text = "Quitar Producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.Location = new System.Drawing.Point(457, 556);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(167, 48);
            this.btnConfirmarVenta.TabIndex = 11;
            this.btnConfirmarVenta.Text = "Confirmar venta";
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 556);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 48);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(6, 25);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(77, 13);
            this.lblPrecioUnitario.TabIndex = 9;
            this.lblPrecioUnitario.Text = "Precio unitario:";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(6, 51);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(63, 13);
            this.lblPrecioTotal.TabIndex = 10;
            this.lblPrecioTotal.Text = "Precio total:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPrecioUnitario);
            this.groupBox4.Controls.Add(this.lblPrecioTotal);
            this.groupBox4.Location = new System.Drawing.Point(477, 173);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 79);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Subtotal";
            // 
            // gboxNuevoCliente
            // 
            this.gboxNuevoCliente.Controls.Add(this.btnAgregarCliente);
            this.gboxNuevoCliente.Location = new System.Drawing.Point(477, 88);
            this.gboxNuevoCliente.Name = "gboxNuevoCliente";
            this.gboxNuevoCliente.Size = new System.Drawing.Size(141, 79);
            this.gboxNuevoCliente.TabIndex = 14;
            this.gboxNuevoCliente.TabStop = false;
            this.gboxNuevoCliente.Text = "Nuevo cliente";
            // 
            // gBoxImporte
            // 
            this.gBoxImporte.Controls.Add(this.lblTotalNeto);
            this.gBoxImporte.Controls.Add(this.lblTotal);
            this.gBoxImporte.Location = new System.Drawing.Point(521, 367);
            this.gBoxImporte.Name = "gBoxImporte";
            this.gBoxImporte.Size = new System.Drawing.Size(97, 86);
            this.gBoxImporte.TabIndex = 15;
            this.gBoxImporte.TabStop = false;
            this.gBoxImporte.Text = "Importe";
            // 
            // lblTotalNeto
            // 
            this.lblTotalNeto.AutoSize = true;
            this.lblTotalNeto.Location = new System.Drawing.Point(43, 40);
            this.lblTotalNeto.Name = "lblTotalNeto";
            this.lblTotalNeto.Size = new System.Drawing.Size(13, 13);
            this.lblTotalNeto.TabIndex = 16;
            this.lblTotalNeto.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total";
            // 
            // txtBusquedaCuit
            // 
            this.txtBusquedaCuit.Location = new System.Drawing.Point(353, 23);
            this.txtBusquedaCuit.Name = "txtBusquedaCuit";
            this.txtBusquedaCuit.Size = new System.Drawing.Size(98, 20);
            this.txtBusquedaCuit.TabIndex = 15;
            this.txtBusquedaCuit.TextChanged += new System.EventHandler(this.txtBusquedaCuit_TextChanged);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 611);
            this.Controls.Add(this.gBoxImporte);
            this.Controls.Add(this.gboxNuevoCliente);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.gboxProducto);
            this.Controls.Add(this.gboxCliente);
            this.Controls.Add(this.gboxFactura);
            this.Controls.Add(this.gridProductos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.gboxFactura.ResumeLayout(false);
            this.gboxFactura.PerformLayout();
            this.gboxCliente.ResumeLayout(false);
            this.gboxCliente.PerformLayout();
            this.gboxProducto.ResumeLayout(false);
            this.gboxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadProducto)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.gboxNuevoCliente.ResumeLayout(false);
            this.gBoxImporte.ResumeLayout(false);
            this.gBoxImporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxFactura;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.GroupBox gboxCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gboxProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblFechaFactura;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboCuit;
        private System.Windows.Forms.Label lblCuitCliente;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox gboxNuevoCliente;
        private System.Windows.Forms.TextBox txtBusquedaProducto;
        private System.Windows.Forms.NumericUpDown txtCantidadProducto;
        private System.Windows.Forms.TextBox txtBusquedaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gBoxImporte;
        private System.Windows.Forms.Label lblTotalNeto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtBusquedaCuit;
    }
}