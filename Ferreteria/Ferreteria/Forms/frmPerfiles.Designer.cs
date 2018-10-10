namespace Ferreteria.Forms
{
    partial class frmPerfiles
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
            this.gridProfiles = new System.Windows.Forms.DataGridView();
            this.btnAddProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProfiles
            // 
            this.gridProfiles.AllowUserToAddRows = false;
            this.gridProfiles.AllowUserToDeleteRows = false;
            this.gridProfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfiles.Location = new System.Drawing.Point(13, 13);
            this.gridProfiles.Name = "gridProfiles";
            this.gridProfiles.Size = new System.Drawing.Size(410, 249);
            this.gridProfiles.TabIndex = 0;
            this.gridProfiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProfiles_CellDoubleClick);
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.Location = new System.Drawing.Point(307, 269);
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(116, 37);
            this.btnAddProfile.TabIndex = 1;
            this.btnAddProfile.Text = "Agregar";
            this.btnAddProfile.UseVisualStyleBackColor = true;
            this.btnAddProfile.Click += new System.EventHandler(this.btnAddProfile_Click);
            // 
            // frmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 318);
            this.Controls.Add(this.btnAddProfile);
            this.Controls.Add(this.gridProfiles);
            this.Name = "frmPerfiles";
            this.Text = "Perfiles de Usuarios";
            this.Load += new System.EventHandler(this.frmPerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProfiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProfiles;
        private System.Windows.Forms.Button btnAddProfile;
    }
}