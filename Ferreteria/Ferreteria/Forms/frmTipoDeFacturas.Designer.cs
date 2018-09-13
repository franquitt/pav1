namespace Ferreteria.Forms
{
    partial class frmTipoFacturas
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
            this.btnRemoveTipoFactura = new System.Windows.Forms.Button();
            this.btnEditTipoFactura = new System.Windows.Forms.Button();
            this.btnAddTipoFactura = new System.Windows.Forms.Button();
            this.gridTipoFacturas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveTipoFactura
            // 
            this.btnRemoveTipoFactura.Location = new System.Drawing.Point(251, 280);
            this.btnRemoveTipoFactura.Name = "btnRemoveTipoFactura";
            this.btnRemoveTipoFactura.Size = new System.Drawing.Size(124, 37);
            this.btnRemoveTipoFactura.TabIndex = 7;
            this.btnRemoveTipoFactura.Text = "Dar de baja";
            this.btnRemoveTipoFactura.UseVisualStyleBackColor = true;
            this.btnRemoveTipoFactura.Click += new System.EventHandler(this.btnRemoveTipoFactura_Click);
            // 
            // btnEditTipoFactura
            // 
            this.btnEditTipoFactura.Location = new System.Drawing.Point(134, 280);
            this.btnEditTipoFactura.Name = "btnEditTipoFactura";
            this.btnEditTipoFactura.Size = new System.Drawing.Size(111, 37);
            this.btnEditTipoFactura.TabIndex = 6;
            this.btnEditTipoFactura.Text = "Editar";
            this.btnEditTipoFactura.UseVisualStyleBackColor = true;
            this.btnEditTipoFactura.Click += new System.EventHandler(this.btnEditTipoFactura_Click);
            // 
            // btnAddTipoFactura
            // 
            this.btnAddTipoFactura.Location = new System.Drawing.Point(12, 280);
            this.btnAddTipoFactura.Name = "btnAddTipoFactura";
            this.btnAddTipoFactura.Size = new System.Drawing.Size(116, 37);
            this.btnAddTipoFactura.TabIndex = 5;
            this.btnAddTipoFactura.Text = "Agregar";
            this.btnAddTipoFactura.UseVisualStyleBackColor = true;
            this.btnAddTipoFactura.Click += new System.EventHandler(this.btnAddTipoFactura_Click);
            // 
            // gridTipoFacturas
            // 
            this.gridTipoFacturas.AllowUserToAddRows = false;
            this.gridTipoFacturas.AllowUserToDeleteRows = false;
            this.gridTipoFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipoFacturas.Location = new System.Drawing.Point(12, 12);
            this.gridTipoFacturas.Name = "gridTipoFacturas";
            this.gridTipoFacturas.Size = new System.Drawing.Size(363, 262);
            this.gridTipoFacturas.TabIndex = 4;
            // 
            // frmTipoFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 329);
            this.Controls.Add(this.btnRemoveTipoFactura);
            this.Controls.Add(this.btnEditTipoFactura);
            this.Controls.Add(this.btnAddTipoFactura);
            this.Controls.Add(this.gridTipoFacturas);
            this.Name = "frmTipoFacturas";
            this.Text = "Tipos de facturas";
            this.Load += new System.EventHandler(this.frmTipoFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveTipoFactura;
        private System.Windows.Forms.Button btnEditTipoFactura;
        private System.Windows.Forms.Button btnAddTipoFactura;
        private System.Windows.Forms.DataGridView gridTipoFacturas;
    }
}