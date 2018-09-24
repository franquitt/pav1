namespace Ferreteria
{
    partial class frmNuevoUsuario
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
            this.txtLegajo = new System.Windows.Forms.MaskedTextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNuevoUsuarioLegajo = new System.Windows.Forms.Label();
            this.lblNuevoUsuarioPass = new System.Windows.Forms.Label();
            this.lblNuevoUsuarioNombre = new System.Windows.Forms.Label();
            this.label4lblNuevoUsuarioApellido = new System.Windows.Forms.Label();
            this.lblNuevoUsuarioFechaNac = new System.Windows.Forms.Label();
            this.lblNuevoUsuarioTelefono = new System.Windows.Forms.Label();
            this.txtFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.cmbTipoUser = new System.Windows.Forms.ComboBox();
            this.lblTipoUser = new System.Windows.Forms.Label();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(125, 15);
            this.txtLegajo.Mask = "99999";
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(153, 20);
            this.txtLegajo.TabIndex = 0;
            this.txtLegajo.ValidatingType = typeof(int);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(125, 42);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(153, 20);
            this.txtPass.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(125, 94);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(153, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // lblNuevoUsuarioLegajo
            // 
            this.lblNuevoUsuarioLegajo.AutoSize = true;
            this.lblNuevoUsuarioLegajo.Location = new System.Drawing.Point(13, 18);
            this.lblNuevoUsuarioLegajo.Name = "lblNuevoUsuarioLegajo";
            this.lblNuevoUsuarioLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblNuevoUsuarioLegajo.TabIndex = 6;
            this.lblNuevoUsuarioLegajo.Text = "Legajo";
            // 
            // lblNuevoUsuarioPass
            // 
            this.lblNuevoUsuarioPass.AutoSize = true;
            this.lblNuevoUsuarioPass.Location = new System.Drawing.Point(13, 45);
            this.lblNuevoUsuarioPass.Name = "lblNuevoUsuarioPass";
            this.lblNuevoUsuarioPass.Size = new System.Drawing.Size(61, 13);
            this.lblNuevoUsuarioPass.TabIndex = 7;
            this.lblNuevoUsuarioPass.Text = "Contraseña";
            // 
            // lblNuevoUsuarioNombre
            // 
            this.lblNuevoUsuarioNombre.AutoSize = true;
            this.lblNuevoUsuarioNombre.Location = new System.Drawing.Point(13, 71);
            this.lblNuevoUsuarioNombre.Name = "lblNuevoUsuarioNombre";
            this.lblNuevoUsuarioNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNuevoUsuarioNombre.TabIndex = 8;
            this.lblNuevoUsuarioNombre.Text = "Nombre";
            // 
            // label4lblNuevoUsuarioApellido
            // 
            this.label4lblNuevoUsuarioApellido.AutoSize = true;
            this.label4lblNuevoUsuarioApellido.Location = new System.Drawing.Point(13, 97);
            this.label4lblNuevoUsuarioApellido.Name = "label4lblNuevoUsuarioApellido";
            this.label4lblNuevoUsuarioApellido.Size = new System.Drawing.Size(44, 13);
            this.label4lblNuevoUsuarioApellido.TabIndex = 9;
            this.label4lblNuevoUsuarioApellido.Text = "Apellido";
            // 
            // lblNuevoUsuarioFechaNac
            // 
            this.lblNuevoUsuarioFechaNac.AutoSize = true;
            this.lblNuevoUsuarioFechaNac.Location = new System.Drawing.Point(13, 123);
            this.lblNuevoUsuarioFechaNac.Name = "lblNuevoUsuarioFechaNac";
            this.lblNuevoUsuarioFechaNac.Size = new System.Drawing.Size(106, 13);
            this.lblNuevoUsuarioFechaNac.TabIndex = 10;
            this.lblNuevoUsuarioFechaNac.Text = "Fecha de nacimiento";
            // 
            // lblNuevoUsuarioTelefono
            // 
            this.lblNuevoUsuarioTelefono.AutoSize = true;
            this.lblNuevoUsuarioTelefono.Location = new System.Drawing.Point(13, 149);
            this.lblNuevoUsuarioTelefono.Name = "lblNuevoUsuarioTelefono";
            this.lblNuevoUsuarioTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblNuevoUsuarioTelefono.TabIndex = 11;
            this.lblNuevoUsuarioTelefono.Text = "Teléfono";
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(125, 120);
            this.txtFechaNac.Mask = "0000-00-00";
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(153, 20);
            this.txtFechaNac.TabIndex = 12;
            this.txtFechaNac.ValidatingType = typeof(System.DateTime);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(125, 146);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(153, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(148, 208);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(130, 38);
            this.btnAgregarUsuario.TabIndex = 14;
            this.btnAgregarUsuario.Text = "Guardar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // cmbTipoUser
            // 
            this.cmbTipoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUser.FormattingEnabled = true;
            this.cmbTipoUser.Location = new System.Drawing.Point(125, 173);
            this.cmbTipoUser.Name = "cmbTipoUser";
            this.cmbTipoUser.Size = new System.Drawing.Size(153, 21);
            this.cmbTipoUser.TabIndex = 15;
            // 
            // lblTipoUser
            // 
            this.lblTipoUser.AutoSize = true;
            this.lblTipoUser.Location = new System.Drawing.Point(16, 180);
            this.lblTipoUser.Name = "lblTipoUser";
            this.lblTipoUser.Size = new System.Drawing.Size(82, 13);
            this.lblTipoUser.TabIndex = 16;
            this.lblTipoUser.Text = "Tipo de Usuario";
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(12, 209);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(128, 37);
            this.btnDelUser.TabIndex = 17;
            this.btnDelUser.Text = "Eliminar";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // frmNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 259);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.lblTipoUser);
            this.Controls.Add(this.cmbTipoUser);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.lblNuevoUsuarioTelefono);
            this.Controls.Add(this.lblNuevoUsuarioFechaNac);
            this.Controls.Add(this.label4lblNuevoUsuarioApellido);
            this.Controls.Add(this.lblNuevoUsuarioNombre);
            this.Controls.Add(this.lblNuevoUsuarioPass);
            this.Controls.Add(this.lblNuevoUsuarioLegajo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLegajo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNuevoUsuario";
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtLegajo;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNuevoUsuarioLegajo;
        private System.Windows.Forms.Label lblNuevoUsuarioPass;
        private System.Windows.Forms.Label lblNuevoUsuarioNombre;
        private System.Windows.Forms.Label label4lblNuevoUsuarioApellido;
        private System.Windows.Forms.Label lblNuevoUsuarioFechaNac;
        private System.Windows.Forms.Label lblNuevoUsuarioTelefono;
        private System.Windows.Forms.MaskedTextBox txtFechaNac;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUser;
        private System.Windows.Forms.Label lblTipoUser;
        private System.Windows.Forms.Button btnDelUser;
    }
}