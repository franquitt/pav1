namespace Ferreteria.Forms
{
    partial class frmClasificacion
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
            this.txtNombreClasificacion = new System.Windows.Forms.TextBox();
            this.lblNombreClasificacion = new System.Windows.Forms.Label();
            this.btnSaveClasificacion = new System.Windows.Forms.Button();
            this.txtDescripcionClasificacion = new System.Windows.Forms.TextBox();
            this.lblDescripcionClasificacion = new System.Windows.Forms.Label();
            this.btnDeleteClasificacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreClasificacion
            // 
            this.txtNombreClasificacion.Location = new System.Drawing.Point(59, 6);
            this.txtNombreClasificacion.Name = "txtNombreClasificacion";
            this.txtNombreClasificacion.Size = new System.Drawing.Size(213, 20);
            this.txtNombreClasificacion.TabIndex = 9;
            // 
            // lblNombreClasificacion
            // 
            this.lblNombreClasificacion.AutoSize = true;
            this.lblNombreClasificacion.Location = new System.Drawing.Point(9, 9);
            this.lblNombreClasificacion.Name = "lblNombreClasificacion";
            this.lblNombreClasificacion.Size = new System.Drawing.Size(44, 13);
            this.lblNombreClasificacion.TabIndex = 7;
            this.lblNombreClasificacion.Text = "Nombre";
            // 
            // btnSaveClasificacion
            // 
            this.btnSaveClasificacion.Location = new System.Drawing.Point(149, 222);
            this.btnSaveClasificacion.Name = "btnSaveClasificacion";
            this.btnSaveClasificacion.Size = new System.Drawing.Size(123, 32);
            this.btnSaveClasificacion.TabIndex = 5;
            this.btnSaveClasificacion.Text = "Guardar";
            this.btnSaveClasificacion.UseVisualStyleBackColor = true;
            this.btnSaveClasificacion.Click += new System.EventHandler(this.btnSaveClasificacion_Click);
            // 
            // txtDescripcionClasificacion
            // 
            this.txtDescripcionClasificacion.Location = new System.Drawing.Point(12, 55);
            this.txtDescripcionClasificacion.Multiline = true;
            this.txtDescripcionClasificacion.Name = "txtDescripcionClasificacion";
            this.txtDescripcionClasificacion.Size = new System.Drawing.Size(260, 161);
            this.txtDescripcionClasificacion.TabIndex = 10;
            // 
            // lblDescripcionClasificacion
            // 
            this.lblDescripcionClasificacion.Location = new System.Drawing.Point(12, 29);
            this.lblDescripcionClasificacion.Name = "lblDescripcionClasificacion";
            this.lblDescripcionClasificacion.Size = new System.Drawing.Size(260, 23);
            this.lblDescripcionClasificacion.TabIndex = 11;
            this.lblDescripcionClasificacion.Text = "Descripcion";
            this.lblDescripcionClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteClasificacion
            // 
            this.btnDeleteClasificacion.Location = new System.Drawing.Point(12, 222);
            this.btnDeleteClasificacion.Name = "btnDeleteClasificacion";
            this.btnDeleteClasificacion.Size = new System.Drawing.Size(120, 32);
            this.btnDeleteClasificacion.TabIndex = 12;
            this.btnDeleteClasificacion.Text = "Dar de baja";
            this.btnDeleteClasificacion.UseVisualStyleBackColor = true;
            this.btnDeleteClasificacion.Click += new System.EventHandler(this.btnDeleteClasificacion_Click);
            // 
            // frmClasificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 263);
            this.Controls.Add(this.btnDeleteClasificacion);
            this.Controls.Add(this.lblDescripcionClasificacion);
            this.Controls.Add(this.txtDescripcionClasificacion);
            this.Controls.Add(this.txtNombreClasificacion);
            this.Controls.Add(this.lblNombreClasificacion);
            this.Controls.Add(this.btnSaveClasificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmClasificacion";
            this.Text = "Nueva clasificacion";
            this.Load += new System.EventHandler(this.frmClasificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreClasificacion;
        private System.Windows.Forms.Label lblNombreClasificacion;
        private System.Windows.Forms.Button btnSaveClasificacion;
        private System.Windows.Forms.TextBox txtDescripcionClasificacion;
        private System.Windows.Forms.Label lblDescripcionClasificacion;
        private System.Windows.Forms.Button btnDeleteClasificacion;
    }
}