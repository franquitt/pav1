namespace Ferreteria.Forms
{
    partial class frmProveedores
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
            this.btnAddProveedor = new System.Windows.Forms.Button();
            this.gridProveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProveedor
            // 
            this.btnAddProveedor.Location = new System.Drawing.Point(413, 232);
            this.btnAddProveedor.Name = "btnAddProveedor";
            this.btnAddProveedor.Size = new System.Drawing.Size(100, 36);
            this.btnAddProveedor.TabIndex = 4;
            this.btnAddProveedor.Text = "Nuevo";
            this.btnAddProveedor.UseVisualStyleBackColor = true;
            this.btnAddProveedor.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // gridProveedores
            // 
            this.gridProveedores.AllowUserToAddRows = false;
            this.gridProveedores.AllowUserToDeleteRows = false;
            this.gridProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProveedores.Location = new System.Drawing.Point(12, 12);
            this.gridProveedores.MultiSelect = false;
            this.gridProveedores.Name = "gridProveedores";
            this.gridProveedores.ReadOnly = true;
            this.gridProveedores.Size = new System.Drawing.Size(501, 214);
            this.gridProveedores.TabIndex = 3;
            this.gridProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellDoubleClick);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 281);
            this.Controls.Add(this.btnAddProveedor);
            this.Controls.Add(this.gridProveedores);
            this.Name = "frmProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddProveedor;
        private System.Windows.Forms.DataGridView gridProveedores;
    }
}