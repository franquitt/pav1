namespace Ferreteria.Forms
{
    partial class frmTipoFactura
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
            this.txtNameTipoFactura = new System.Windows.Forms.TextBox();
            this.lblNombreTipoFactura = new System.Windows.Forms.Label();
            this.btnSaveTipoFactura = new System.Windows.Forms.Button();
            this.btnDeleteTipoFactura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNameTipoFactura
            // 
            this.txtNameTipoFactura.Location = new System.Drawing.Point(73, 12);
            this.txtNameTipoFactura.Name = "txtNameTipoFactura";
            this.txtNameTipoFactura.Size = new System.Drawing.Size(206, 20);
            this.txtNameTipoFactura.TabIndex = 9;
            // 
            // lblNombreTipoFactura
            // 
            this.lblNombreTipoFactura.AutoSize = true;
            this.lblNombreTipoFactura.Location = new System.Drawing.Point(12, 9);
            this.lblNombreTipoFactura.Name = "lblNombreTipoFactura";
            this.lblNombreTipoFactura.Size = new System.Drawing.Size(44, 13);
            this.lblNombreTipoFactura.TabIndex = 7;
            this.lblNombreTipoFactura.Text = "Nombre";
            // 
            // btnSaveTipoFactura
            // 
            this.btnSaveTipoFactura.Location = new System.Drawing.Point(207, 38);
            this.btnSaveTipoFactura.Name = "btnSaveTipoFactura";
            this.btnSaveTipoFactura.Size = new System.Drawing.Size(72, 33);
            this.btnSaveTipoFactura.TabIndex = 5;
            this.btnSaveTipoFactura.Text = "Guardar";
            this.btnSaveTipoFactura.UseVisualStyleBackColor = true;
            this.btnSaveTipoFactura.Click += new System.EventHandler(this.btnSaveTipoFactura_Click);
            // 
            // btnDeleteTipoFactura
            // 
            this.btnDeleteTipoFactura.Location = new System.Drawing.Point(129, 38);
            this.btnDeleteTipoFactura.Name = "btnDeleteTipoFactura";
            this.btnDeleteTipoFactura.Size = new System.Drawing.Size(72, 33);
            this.btnDeleteTipoFactura.TabIndex = 10;
            this.btnDeleteTipoFactura.Text = "Dar de baja";
            this.btnDeleteTipoFactura.UseVisualStyleBackColor = true;
            this.btnDeleteTipoFactura.Click += new System.EventHandler(this.btnDeleteTipoFactura_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "(Todos los campos deben estar llenos)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTipoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 107);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteTipoFactura);
            this.Controls.Add(this.txtNameTipoFactura);
            this.Controls.Add(this.lblNombreTipoFactura);
            this.Controls.Add(this.btnSaveTipoFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTipoFactura";
            this.Text = "Tipo de factura";
            this.Load += new System.EventHandler(this.frmNuevoTipoFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameTipoFactura;
        private System.Windows.Forms.Label lblNombreTipoFactura;
        private System.Windows.Forms.Button btnSaveTipoFactura;
        private System.Windows.Forms.Button btnDeleteTipoFactura;
        private System.Windows.Forms.Label label1;
    }
}