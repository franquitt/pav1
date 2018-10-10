namespace Ferreteria.Forms
{
    partial class frmLotes
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
            this.gridLotes = new System.Windows.Forms.DataGridView();
            this.btnAgregarLote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLotes
            // 
            this.gridLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLotes.Location = new System.Drawing.Point(12, 12);
            this.gridLotes.Name = "gridLotes";
            this.gridLotes.Size = new System.Drawing.Size(408, 229);
            this.gridLotes.TabIndex = 0;
            this.gridLotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLotes_CellDoubleClick);
            // 
            // btnAgregarLote
            // 
            this.btnAgregarLote.Location = new System.Drawing.Point(345, 247);
            this.btnAgregarLote.Name = "btnAgregarLote";
            this.btnAgregarLote.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarLote.TabIndex = 1;
            this.btnAgregarLote.Text = "Agregar";
            this.btnAgregarLote.UseVisualStyleBackColor = true;
            this.btnAgregarLote.Click += new System.EventHandler(this.btnAgregarLote_Click);
            // 
            // frmLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 300);
            this.Controls.Add(this.btnAgregarLote);
            this.Controls.Add(this.gridLotes);
            this.Name = "frmLotes";
            this.Text = "Lotes";
            this.Load += new System.EventHandler(this.frmLotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLotes;
        private System.Windows.Forms.Button btnAgregarLote;
    }
}