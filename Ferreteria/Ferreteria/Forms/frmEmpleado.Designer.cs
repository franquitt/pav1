namespace Ferreteria
{
    partial class frmEmpleado
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.gridVendedores = new System.Windows.Forms.DataGridView();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(195, 240);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(104, 44);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Agregar";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // gridVendedores
            // 
            this.gridVendedores.AllowUserToAddRows = false;
            this.gridVendedores.AllowUserToDeleteRows = false;
            this.gridVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVendedores.Location = new System.Drawing.Point(13, 13);
            this.gridVendedores.MultiSelect = false;
            this.gridVendedores.Name = "gridVendedores";
            this.gridVendedores.Size = new System.Drawing.Size(518, 221);
            this.gridVendedores.TabIndex = 2;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(314, 240);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(104, 44);
            this.btnEditUser.TabIndex = 3;
            this.btnEditUser.Text = "Editar";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(425, 241);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(106, 41);
            this.btnDelUser.TabIndex = 4;
            this.btnDelUser.Text = "Dar de Baja";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 294);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.gridVendedores);
            this.Controls.Add(this.btnAddUser);
            this.Name = "frmEmpleado";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Vendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView gridVendedores;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDelUser;
    }
}