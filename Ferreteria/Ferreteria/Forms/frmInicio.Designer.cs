namespace Ferreteria
{
    partial class frmInicio
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
            this.lblInicio = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificacionDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asociacionesProveedoresProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(217, 147);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(116, 13);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Ha ingresado con éxito";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeUsuariosToolStripMenuItem,
            this.vendedoToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Usuarios";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // tipoDeUsuariosToolStripMenuItem
            // 
            this.tipoDeUsuariosToolStripMenuItem.Name = "tipoDeUsuariosToolStripMenuItem";
            this.tipoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.tipoDeUsuariosToolStripMenuItem.Text = "Perfiles";
            this.tipoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.tipoDeUsuariosToolStripMenuItem_Click);
            // 
            // vendedoToolStripMenuItem
            // 
            this.vendedoToolStripMenuItem.Name = "vendedoToolStripMenuItem";
            this.vendedoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.vendedoToolStripMenuItem.Text = "Vendedores";
            this.vendedoToolStripMenuItem.Click += new System.EventHandler(this.vendedoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.lotesToolStripMenuItem,
            this.productosToolStripMenuItem1,
            this.clasificacionDeProductosToolStripMenuItem,
            this.asociacionesProveedoresProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // lotesToolStripMenuItem
            // 
            this.lotesToolStripMenuItem.Name = "lotesToolStripMenuItem";
            this.lotesToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.lotesToolStripMenuItem.Text = "Lotes";
            this.lotesToolStripMenuItem.Click += new System.EventHandler(this.lotesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(257, 22);
            this.productosToolStripMenuItem1.Text = "Productos";
            this.productosToolStripMenuItem1.Click += new System.EventHandler(this.productosToolStripMenuItem1_Click);
            // 
            // clasificacionDeProductosToolStripMenuItem
            // 
            this.clasificacionDeProductosToolStripMenuItem.Name = "clasificacionDeProductosToolStripMenuItem";
            this.clasificacionDeProductosToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.clasificacionDeProductosToolStripMenuItem.Text = "Clasificacion de Productos";
            this.clasificacionDeProductosToolStripMenuItem.Click += new System.EventHandler(this.clasificacionDeProductosToolStripMenuItem_Click);
            // 
            // asociacionesProveedoresProductosToolStripMenuItem
            // 
            this.asociacionesProveedoresProductosToolStripMenuItem.Name = "asociacionesProveedoresProductosToolStripMenuItem";
            this.asociacionesProveedoresProductosToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.asociacionesProveedoresProductosToolStripMenuItem.Text = "Asociaciones Proveedores - Productos";
            this.asociacionesProveedoresProductosToolStripMenuItem.Click += new System.EventHandler(this.asociacionesProveedoresProductosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem1,
            this.tipoDeFacturaToolStripMenuItem,
            this.facturacionToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // tipoDeFacturaToolStripMenuItem
            // 
            this.tipoDeFacturaToolStripMenuItem.Name = "tipoDeFacturaToolStripMenuItem";
            this.tipoDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.tipoDeFacturaToolStripMenuItem.Text = "Tipo de Factura";
            this.tipoDeFacturaToolStripMenuItem.Click += new System.EventHandler(this.tipoDeFacturaToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Los 10 productos mas vendidos en el ultimo mes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clasificacionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipoDeFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asociacionesProveedoresProductosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}