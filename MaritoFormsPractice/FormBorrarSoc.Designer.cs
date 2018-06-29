namespace MaritoFormsPractice
{
    partial class FormBorrarSoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorrarSoc));
            this.IngCodSoc = new System.Windows.Forms.ComboBox();
            this.BotonBorrar = new System.Windows.Forms.Button();
            this.ListSoc = new System.Windows.Forms.ListBox();
            this.DescSoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IngCodSoc
            // 
            this.IngCodSoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IngCodSoc.FormattingEnabled = true;
            this.IngCodSoc.Location = new System.Drawing.Point(193, 38);
            this.IngCodSoc.Name = "IngCodSoc";
            this.IngCodSoc.Size = new System.Drawing.Size(138, 27);
            this.IngCodSoc.TabIndex = 0;
            this.IngCodSoc.SelectedIndexChanged += new System.EventHandler(this.IngSoc_SelectedIndexChanged);
            // 
            // BotonBorrar
            // 
            this.BotonBorrar.Enabled = false;
            this.BotonBorrar.Location = new System.Drawing.Point(143, 287);
            this.BotonBorrar.Name = "BotonBorrar";
            this.BotonBorrar.Size = new System.Drawing.Size(88, 35);
            this.BotonBorrar.TabIndex = 2;
            this.BotonBorrar.Text = "Borrar";
            this.BotonBorrar.UseVisualStyleBackColor = true;
            this.BotonBorrar.Click += new System.EventHandler(this.BotonBorrar_Click);
            // 
            // ListSoc
            // 
            this.ListSoc.FormattingEnabled = true;
            this.ListSoc.ItemHeight = 19;
            this.ListSoc.Location = new System.Drawing.Point(79, 99);
            this.ListSoc.Name = "ListSoc";
            this.ListSoc.Size = new System.Drawing.Size(224, 156);
            this.ListSoc.TabIndex = 3;
            // 
            // DescSoc
            // 
            this.DescSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescSoc.AutoSize = true;
            this.DescSoc.Location = new System.Drawing.Point(50, 41);
            this.DescSoc.Name = "DescSoc";
            this.DescSoc.Size = new System.Drawing.Size(50, 19);
            this.DescSoc.TabIndex = 4;
            this.DescSoc.Text = "Socio:";
            // 
            // FormBorrarSoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.DescSoc);
            this.Controls.Add(this.ListSoc);
            this.Controls.Add(this.BotonBorrar);
            this.Controls.Add(this.IngCodSoc);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBorrarSoc";
            this.Text = "Borrar Socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IngCodSoc;
        private System.Windows.Forms.Button BotonBorrar;
        private System.Windows.Forms.ListBox ListSoc;
        private System.Windows.Forms.Label DescSoc;
    }
}