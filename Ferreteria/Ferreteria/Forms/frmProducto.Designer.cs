namespace Ferreteria.Forms
{
    partial class frmProducto
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
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.btnSaveProducto = new System.Windows.Forms.Button();
            this.btnDeleteProducto = new System.Windows.Forms.Button();
            this.lblClasificacionProducto = new System.Windows.Forms.Label();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(59, 6);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(345, 20);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(9, 9);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Nombre";
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.Location = new System.Drawing.Point(12, 29);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(392, 20);
            this.lblDescripcionProducto.TabIndex = 2;
            this.lblDescripcionProducto.Text = "Descripcion";
            this.lblDescripcionProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(12, 52);
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(394, 138);
            this.txtDescripcionProducto.TabIndex = 3;
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(9, 208);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioProducto.TabIndex = 4;
            this.lblPrecioProducto.Text = "Precio";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(52, 205);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(354, 20);
            this.txtPrecioProducto.TabIndex = 6;
            // 
            // btnSaveProducto
            // 
            this.btnSaveProducto.Location = new System.Drawing.Point(331, 275);
            this.btnSaveProducto.Name = "btnSaveProducto";
            this.btnSaveProducto.Size = new System.Drawing.Size(75, 45);
            this.btnSaveProducto.TabIndex = 7;
            this.btnSaveProducto.Text = "Guardar";
            this.btnSaveProducto.UseVisualStyleBackColor = true;
            this.btnSaveProducto.Click += new System.EventHandler(this.btnSaveProducto_Click);
            // 
            // btnDeleteProducto
            // 
            this.btnDeleteProducto.Location = new System.Drawing.Point(250, 275);
            this.btnDeleteProducto.Name = "btnDeleteProducto";
            this.btnDeleteProducto.Size = new System.Drawing.Size(75, 45);
            this.btnDeleteProducto.TabIndex = 8;
            this.btnDeleteProducto.Text = "Dar de baja";
            this.btnDeleteProducto.UseVisualStyleBackColor = true;
            this.btnDeleteProducto.Click += new System.EventHandler(this.btnDeleteProducto_Click);
            // 
            // lblClasificacionProducto
            // 
            this.lblClasificacionProducto.AutoSize = true;
            this.lblClasificacionProducto.Location = new System.Drawing.Point(9, 242);
            this.lblClasificacionProducto.Name = "lblClasificacionProducto";
            this.lblClasificacionProducto.Size = new System.Drawing.Size(66, 13);
            this.lblClasificacionProducto.TabIndex = 9;
            this.lblClasificacionProducto.Text = "Clasificacion";
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(81, 239);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(325, 21);
            this.cboClasificacion.TabIndex = 10;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 332);
            this.Controls.Add(this.cboClasificacion);
            this.Controls.Add(this.lblClasificacionProducto);
            this.Controls.Add(this.btnDeleteProducto);
            this.Controls.Add(this.btnSaveProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.lblDescripcionProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Name = "frmProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Button btnSaveProducto;
        private System.Windows.Forms.Button btnDeleteProducto;
        private System.Windows.Forms.Label lblClasificacionProducto;
        private System.Windows.Forms.ComboBox cboClasificacion;
    }
}