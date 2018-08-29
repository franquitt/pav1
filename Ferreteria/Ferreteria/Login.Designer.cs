namespace Ferreteria
{
    partial class frmLogin
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(90, 34);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(270, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "Legajo";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(90, 95);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '?';
            this.txtPass.Size = new System.Drawing.Size(270, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "Contraseña";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(162, 141);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 213);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Name = "frmLogin";
            this.Text = "Iniciar sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
    }
}

