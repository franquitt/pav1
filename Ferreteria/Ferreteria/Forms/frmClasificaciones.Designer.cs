namespace Ferreteria.Forms
{
    partial class frmClasificaciones
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
            this.btnAddClasificaciones = new System.Windows.Forms.Button();
            this.gridClasificaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridClasificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClasificaciones
            // 
            this.btnAddClasificaciones.Location = new System.Drawing.Point(12, 268);
            this.btnAddClasificaciones.Name = "btnAddClasificaciones";
            this.btnAddClasificaciones.Size = new System.Drawing.Size(410, 37);
            this.btnAddClasificaciones.TabIndex = 5;
            this.btnAddClasificaciones.Text = "Agregar";
            this.btnAddClasificaciones.UseVisualStyleBackColor = true;
            this.btnAddClasificaciones.Click += new System.EventHandler(this.btnAddClasificaciones_Click);
            // 
            // gridClasificaciones
            // 
            this.gridClasificaciones.AllowUserToAddRows = false;
            this.gridClasificaciones.AllowUserToDeleteRows = false;
            this.gridClasificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClasificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClasificaciones.Location = new System.Drawing.Point(12, 12);
            this.gridClasificaciones.Name = "gridClasificaciones";
            this.gridClasificaciones.Size = new System.Drawing.Size(410, 249);
            this.gridClasificaciones.TabIndex = 4;
            this.gridClasificaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClasificaciones_CellDoubleClick);
            // 
            // frmClasificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 313);
            this.Controls.Add(this.btnAddClasificaciones);
            this.Controls.Add(this.gridClasificaciones);
            this.Name = "frmClasificaciones";
            this.Text = "Clasificaciones";
            this.Load += new System.EventHandler(this.frmClasificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClasificaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddClasificaciones;
        private System.Windows.Forms.DataGridView gridClasificaciones;
    }
}