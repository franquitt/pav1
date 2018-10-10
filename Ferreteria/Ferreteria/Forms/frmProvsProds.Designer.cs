namespace Ferreteria.Forms
{
    partial class frmProvsProds
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
            this.gridProvProd = new System.Windows.Forms.DataGridView();
            this.btnAgregarProvProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProvProd
            // 
            this.gridProvProd.AllowUserToAddRows = false;
            this.gridProvProd.AllowUserToDeleteRows = false;
            this.gridProvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProvProd.Location = new System.Drawing.Point(13, 13);
            this.gridProvProd.Name = "gridProvProd";
            this.gridProvProd.ReadOnly = true;
            this.gridProvProd.Size = new System.Drawing.Size(574, 203);
            this.gridProvProd.TabIndex = 0;
            this.gridProvProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProvProd_CellDoubleClick);
            // 
            // btnAgregarProvProd
            // 
            this.btnAgregarProvProd.Location = new System.Drawing.Point(502, 222);
            this.btnAgregarProvProd.Name = "btnAgregarProvProd";
            this.btnAgregarProvProd.Size = new System.Drawing.Size(85, 39);
            this.btnAgregarProvProd.TabIndex = 1;
            this.btnAgregarProvProd.Text = "Agregar";
            this.btnAgregarProvProd.UseVisualStyleBackColor = true;
            this.btnAgregarProvProd.Click += new System.EventHandler(this.btnAgregarProvProd_Click);
            // 
            // frmProvsProds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 273);
            this.Controls.Add(this.btnAgregarProvProd);
            this.Controls.Add(this.gridProvProd);
            this.Name = "frmProvsProds";
            this.Text = "Asociaciones de Proveedores y productos";
            this.Load += new System.EventHandler(this.frmProvsProds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProvProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProvProd;
        private System.Windows.Forms.Button btnAgregarProvProd;
    }
}