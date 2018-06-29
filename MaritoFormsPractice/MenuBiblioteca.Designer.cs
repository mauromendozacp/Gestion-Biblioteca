namespace MaritoFormsPractice
{
    partial class MenuBiblioteca
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBiblioteca));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolSocio = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolNuevoSoc = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBorrarSoc = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolVerSoc = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMoroso = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolVerMor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolVerLib = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolPrestLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolPrestLib = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolDevLib = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBuscarFec = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolVerPrest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolSocio,
            this.ToolMoroso,
            this.ToolLibro,
            this.ToolPrestLibro});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(615, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // ToolSocio
            // 
            this.ToolSocio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolNuevoSoc,
            this.ToolBorrarSoc,
            this.ToolVerSoc});
            this.ToolSocio.Name = "ToolSocio";
            this.ToolSocio.Size = new System.Drawing.Size(48, 20);
            this.ToolSocio.Text = "Socio";
            // 
            // ToolNuevoSoc
            // 
            this.ToolNuevoSoc.Name = "ToolNuevoSoc";
            this.ToolNuevoSoc.Size = new System.Drawing.Size(122, 22);
            this.ToolNuevoSoc.Text = "Nuevo";
            this.ToolNuevoSoc.Click += new System.EventHandler(this.ToolNuevoSoc_Click);
            // 
            // ToolBorrarSoc
            // 
            this.ToolBorrarSoc.Name = "ToolBorrarSoc";
            this.ToolBorrarSoc.Size = new System.Drawing.Size(122, 22);
            this.ToolBorrarSoc.Text = "Borrar";
            this.ToolBorrarSoc.Click += new System.EventHandler(this.ToolBorrarSoc_Click);
            // 
            // ToolVerSoc
            // 
            this.ToolVerSoc.Name = "ToolVerSoc";
            this.ToolVerSoc.Size = new System.Drawing.Size(122, 22);
            this.ToolVerSoc.Text = "Ver Socio";
            this.ToolVerSoc.Click += new System.EventHandler(this.ToolVerSoc_Click);
            // 
            // ToolMoroso
            // 
            this.ToolMoroso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolVerMor});
            this.ToolMoroso.Name = "ToolMoroso";
            this.ToolMoroso.Size = new System.Drawing.Size(60, 20);
            this.ToolMoroso.Text = "Moroso";
            // 
            // ToolVerMor
            // 
            this.ToolVerMor.Name = "ToolVerMor";
            this.ToolVerMor.Size = new System.Drawing.Size(152, 22);
            this.ToolVerMor.Text = "Ver Moroso";
            this.ToolVerMor.Click += new System.EventHandler(this.ToolVerMor_Click);
            // 
            // ToolLibro
            // 
            this.ToolLibro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolVerLib});
            this.ToolLibro.Name = "ToolLibro";
            this.ToolLibro.Size = new System.Drawing.Size(46, 20);
            this.ToolLibro.Text = "Libro";
            // 
            // ToolVerLib
            // 
            this.ToolVerLib.Name = "ToolVerLib";
            this.ToolVerLib.Size = new System.Drawing.Size(152, 22);
            this.ToolVerLib.Text = "Ver Libro";
            this.ToolVerLib.Click += new System.EventHandler(this.ToolVerLib_Click);
            // 
            // ToolPrestLibro
            // 
            this.ToolPrestLibro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolPrestLib,
            this.ToolDevLib,
            this.ToolBuscarFec,
            this.ToolVerPrest});
            this.ToolPrestLibro.Name = "ToolPrestLibro";
            this.ToolPrestLibro.Size = new System.Drawing.Size(99, 20);
            this.ToolPrestLibro.Text = "Prestamo Libro";
            // 
            // ToolPrestLib
            // 
            this.ToolPrestLib.Name = "ToolPrestLib";
            this.ToolPrestLib.Size = new System.Drawing.Size(164, 22);
            this.ToolPrestLib.Text = "Prestar Libro";
            this.ToolPrestLib.Click += new System.EventHandler(this.ToolPrestLib_Click);
            // 
            // ToolDevLib
            // 
            this.ToolDevLib.Name = "ToolDevLib";
            this.ToolDevLib.Size = new System.Drawing.Size(164, 22);
            this.ToolDevLib.Text = "Devolver Libro";
            this.ToolDevLib.Click += new System.EventHandler(this.ToolDevLib_Click);
            // 
            // ToolBuscarFec
            // 
            this.ToolBuscarFec.Name = "ToolBuscarFec";
            this.ToolBuscarFec.Size = new System.Drawing.Size(164, 22);
            this.ToolBuscarFec.Text = "Buscar por Fecha";
            this.ToolBuscarFec.Click += new System.EventHandler(this.ToolBuscarFec_Click);
            // 
            // ToolVerPrest
            // 
            this.ToolVerPrest.Name = "ToolVerPrest";
            this.ToolVerPrest.Size = new System.Drawing.Size(164, 22);
            this.ToolVerPrest.Text = "Ver Prestamo";
            this.ToolVerPrest.Click += new System.EventHandler(this.ToolVerPrest_Click);
            // 
            // MenuBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 569);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuBiblioteca";
            this.Text = "Menu Biblioteca";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem ToolSocio;
        private System.Windows.Forms.ToolStripMenuItem ToolMoroso;
        private System.Windows.Forms.ToolStripMenuItem ToolLibro;
        private System.Windows.Forms.ToolStripMenuItem ToolPrestLibro;
        private System.Windows.Forms.ToolStripMenuItem ToolNuevoSoc;
        private System.Windows.Forms.ToolStripMenuItem ToolBorrarSoc;
        private System.Windows.Forms.ToolStripMenuItem ToolVerSoc;
        private System.Windows.Forms.ToolStripMenuItem ToolVerMor;
        private System.Windows.Forms.ToolStripMenuItem ToolVerLib;
        private System.Windows.Forms.ToolStripMenuItem ToolPrestLib;
        private System.Windows.Forms.ToolStripMenuItem ToolDevLib;
        private System.Windows.Forms.ToolStripMenuItem ToolBuscarFec;
        private System.Windows.Forms.ToolStripMenuItem ToolVerPrest;
    }
}



