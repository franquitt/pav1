namespace Ferreteria.Forms
{
    partial class frmLote
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gboxProducto = new System.Windows.Forms.GroupBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.txtBusquedaProducto = new System.Windows.Forms.TextBox();
            this.gboxProveedor = new System.Windows.Forms.GroupBox();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.txtBusquedaProveedor = new System.Windows.Forms.TextBox();
            this.lblStockInicial = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.btnSaveLote = new System.Windows.Forms.Button();
            this.gboxProducto.SuspendLayout();
            this.gboxProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxProducto
            // 
            this.gboxProducto.Controls.Add(this.cboProducto);
            this.gboxProducto.Controls.Add(this.txtBusquedaProducto);
            this.gboxProducto.Location = new System.Drawing.Point(12, 13);
            this.gboxProducto.Name = "gboxProducto";
            this.gboxProducto.Size = new System.Drawing.Size(394, 50);
            this.gboxProducto.TabIndex = 0;
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
            this.txtBusquedaProducto.TextChanged += new System.EventHandler(this.txtBusquedaProducto_TextChanged);
            // 
            // gboxProveedor
            // 
            this.gboxProveedor.Controls.Add(this.cboProveedor);
            this.gboxProveedor.Controls.Add(this.txtBusquedaProveedor);
            this.gboxProveedor.Location = new System.Drawing.Point(12, 69);
            this.gboxProveedor.Name = "gboxProveedor";
            this.gboxProveedor.Size = new System.Drawing.Size(394, 51);
            this.gboxProveedor.TabIndex = 1;
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
            // txtBusquedaProveedor
            // 
            this.txtBusquedaProveedor.Location = new System.Drawing.Point(7, 19);
            this.txtBusquedaProveedor.Name = "txtBusquedaProveedor";
            this.txtBusquedaProveedor.Size = new System.Drawing.Size(115, 20);
            this.txtBusquedaProveedor.TabIndex = 2;
            this.txtBusquedaProveedor.TextChanged += new System.EventHandler(this.txtBusquedaProveedor_TextChanged);
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AutoSize = true;
            this.lblStockInicial.Location = new System.Drawing.Point(16, 130);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(98, 13);
            this.lblStockInicial.TabIndex = 3;
            this.lblStockInicial.Text = "Cantidad ingresada";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(120, 128);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(108, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(234, 130);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(89, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha de ingreso";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(329, 127);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(77, 20);
            this.txtFecha.TabIndex = 6;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // btnSaveLote
            // 
            this.btnSaveLote.Location = new System.Drawing.Point(329, 163);
            this.btnSaveLote.Name = "btnSaveLote";
            this.btnSaveLote.Size = new System.Drawing.Size(75, 41);
            this.btnSaveLote.TabIndex = 7;
            this.btnSaveLote.Text = "Guardar";
            this.btnSaveLote.UseVisualStyleBackColor = true;
            this.btnSaveLote.Click += new System.EventHandler(this.btnSaveLote_Click);
            // 
            // frmLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 216);
            this.Controls.Add(this.btnSaveLote);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblStockInicial);
            this.Controls.Add(this.gboxProveedor);
            this.Controls.Add(this.gboxProducto);
            this.Name = "frmLote";
            this.Text = "Lote";
            this.Load += new System.EventHandler(this.frmLote_Load);
            this.gboxProducto.ResumeLayout(false);
            this.gboxProducto.PerformLayout();
            this.gboxProveedor.ResumeLayout(false);
            this.gboxProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gboxProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.TextBox txtBusquedaProducto;
        private System.Windows.Forms.GroupBox gboxProveedor;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.TextBox txtBusquedaProveedor;
        private System.Windows.Forms.Label lblStockInicial;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Button btnSaveLote;
    }
}