﻿namespace Ferreteria.Forms
{
    partial class frmPerfil
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
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProfile = new System.Windows.Forms.TextBox();
            this.txtNameProfile = new System.Windows.Forms.TextBox();
            this.btnDelProfile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(134, 72);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(95, 40);
            this.btnSaveProfile.TabIndex = 0;
            this.btnSaveProfile.Text = "Guardar";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtIdProfile
            // 
            this.txtIdProfile.Enabled = false;
            this.txtIdProfile.Location = new System.Drawing.Point(74, 10);
            this.txtIdProfile.Name = "txtIdProfile";
            this.txtIdProfile.Size = new System.Drawing.Size(155, 20);
            this.txtIdProfile.TabIndex = 3;
            // 
            // txtNameProfile
            // 
            this.txtNameProfile.Location = new System.Drawing.Point(74, 46);
            this.txtNameProfile.Name = "txtNameProfile";
            this.txtNameProfile.Size = new System.Drawing.Size(155, 20);
            this.txtNameProfile.TabIndex = 4;
            // 
            // btnDelProfile
            // 
            this.btnDelProfile.Location = new System.Drawing.Point(16, 73);
            this.btnDelProfile.Name = "btnDelProfile";
            this.btnDelProfile.Size = new System.Drawing.Size(96, 39);
            this.btnDelProfile.TabIndex = 5;
            this.btnDelProfile.Text = "Dar de Baja";
            this.btnDelProfile.UseVisualStyleBackColor = true;
            this.btnDelProfile.Click += new System.EventHandler(this.btnDelProfile_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "(Todos los campos deben estar llenos)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 145);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelProfile);
            this.Controls.Add(this.txtNameProfile);
            this.Controls.Add(this.txtIdProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPerfil";
            this.Text = "Editar Perfil";
            this.Load += new System.EventHandler(this.frmNuevoPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProfile;
        private System.Windows.Forms.TextBox txtNameProfile;
        private System.Windows.Forms.Button btnDelProfile;
        private System.Windows.Forms.Label label3;
    }
}