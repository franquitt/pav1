namespace Ferreteria.Forms
{
    partial class frmConsultarVenta
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
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusquedaCliente = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCuit = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(53, 53);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(149, 21);
            this.cmbCliente.TabIndex = 0;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCuit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCUIT);
            this.groupBox1.Controls.Add(this.txtBusquedaCliente);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtFechaHasta);
            this.groupBox1.Controls.Add(this.lblFechaHasta);
            this.groupBox1.Controls.Add(this.txtFechaDesde);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // txtBusquedaCliente
            // 
            this.txtBusquedaCliente.Location = new System.Drawing.Point(53, 27);
            this.txtBusquedaCliente.Name = "txtBusquedaCliente";
            this.txtBusquedaCliente.Size = new System.Drawing.Size(149, 20);
            this.txtBusquedaCliente.TabIndex = 9;
            this.txtBusquedaCliente.TextChanged += new System.EventHandler(this.txtBusquedaCliente_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(489, 79);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(71, 34);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(490, 53);
            this.txtFechaHasta.Mask = "0000/00/00";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(71, 20);
            this.txtFechaHasta.TabIndex = 7;
            this.txtFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(418, 56);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(66, 13);
            this.lblFechaHasta.TabIndex = 6;
            this.lblFechaHasta.Text = "Fecha hasta";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(490, 27);
            this.txtFechaDesde.Mask = "0000/00/00";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(72, 20);
            this.txtFechaDesde.TabIndex = 5;
            this.txtFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(415, 30);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(69, 13);
            this.lblFechaDesde.TabIndex = 4;
            this.lblFechaDesde.Text = "Fecha desde";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(4, 140);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(578, 255);
            this.dgvVentas.TabIndex = 4;
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(248, 27);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(131, 20);
            this.txtCUIT.TabIndex = 10;
            this.txtCUIT.TextChanged += new System.EventHandler(this.txtCUIT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "CUIT";
            // 
            // cmbCuit
            // 
            this.cmbCuit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuit.FormattingEnabled = true;
            this.cmbCuit.Location = new System.Drawing.Point(248, 53);
            this.cmbCuit.Name = "cmbCuit";
            this.cmbCuit.Size = new System.Drawing.Size(131, 21);
            this.cmbCuit.TabIndex = 12;
            this.cmbCuit.SelectedIndexChanged += new System.EventHandler(this.cmbCuit_SelectedIndexChanged);
            // 
            // frmConsultarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 407);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultarVenta";
            this.Text = "Consultar ventas";
            this.Load += new System.EventHandler(this.frmConsultarVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.MaskedTextBox txtFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtBusquedaCliente;
        private System.Windows.Forms.ComboBox cmbCuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCUIT;
    }
}