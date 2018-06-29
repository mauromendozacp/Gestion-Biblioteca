namespace MaritoFormsPractice
{
    partial class FormDevLib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevLib));
            this.BotonDevolver = new System.Windows.Forms.Button();
            this.PanelPrestLib = new System.Windows.Forms.TableLayoutPanel();
            this.DescSoc = new System.Windows.Forms.Label();
            this.DescLib = new System.Windows.Forms.Label();
            this.IngCodSoc = new System.Windows.Forms.ComboBox();
            this.IngCodLib = new System.Windows.Forms.ComboBox();
            this.ListPrest = new System.Windows.Forms.ListBox();
            this.PanelPrestLib.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotonDevolver
            // 
            this.BotonDevolver.Enabled = false;
            this.BotonDevolver.Location = new System.Drawing.Point(123, 312);
            this.BotonDevolver.Name = "BotonDevolver";
            this.BotonDevolver.Size = new System.Drawing.Size(120, 37);
            this.BotonDevolver.TabIndex = 3;
            this.BotonDevolver.Text = "Devolver Libro";
            this.BotonDevolver.UseVisualStyleBackColor = true;
            this.BotonDevolver.Click += new System.EventHandler(this.BotonDevolver_Click);
            // 
            // PanelPrestLib
            // 
            this.PanelPrestLib.ColumnCount = 2;
            this.PanelPrestLib.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.72222F));
            this.PanelPrestLib.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.27778F));
            this.PanelPrestLib.Controls.Add(this.DescSoc, 0, 0);
            this.PanelPrestLib.Controls.Add(this.DescLib, 0, 1);
            this.PanelPrestLib.Controls.Add(this.IngCodSoc, 1, 0);
            this.PanelPrestLib.Controls.Add(this.IngCodLib, 1, 1);
            this.PanelPrestLib.Location = new System.Drawing.Point(12, 13);
            this.PanelPrestLib.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelPrestLib.Name = "PanelPrestLib";
            this.PanelPrestLib.RowCount = 2;
            this.PanelPrestLib.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PanelPrestLib.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PanelPrestLib.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelPrestLib.Size = new System.Drawing.Size(360, 130);
            this.PanelPrestLib.TabIndex = 4;
            // 
            // DescSoc
            // 
            this.DescSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescSoc.AutoSize = true;
            this.DescSoc.Location = new System.Drawing.Point(46, 23);
            this.DescSoc.Name = "DescSoc";
            this.DescSoc.Size = new System.Drawing.Size(50, 19);
            this.DescSoc.TabIndex = 0;
            this.DescSoc.Text = "Socio:";
            // 
            // DescLib
            // 
            this.DescLib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescLib.AutoSize = true;
            this.DescLib.Location = new System.Drawing.Point(47, 88);
            this.DescLib.Name = "DescLib";
            this.DescLib.Size = new System.Drawing.Size(48, 19);
            this.DescLib.TabIndex = 1;
            this.DescLib.Text = "Libro:";
            // 
            // IngCodSoc
            // 
            this.IngCodSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngCodSoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IngCodSoc.FormattingEnabled = true;
            this.IngCodSoc.Location = new System.Drawing.Point(182, 22);
            this.IngCodSoc.Name = "IngCodSoc";
            this.IngCodSoc.Size = new System.Drawing.Size(138, 27);
            this.IngCodSoc.TabIndex = 6;
            this.IngCodSoc.SelectedIndexChanged += new System.EventHandler(this.IngCod_SelectedIndexChanged);
            // 
            // IngCodLib
            // 
            this.IngCodLib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngCodLib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IngCodLib.FormattingEnabled = true;
            this.IngCodLib.Location = new System.Drawing.Point(182, 87);
            this.IngCodLib.Name = "IngCodLib";
            this.IngCodLib.Size = new System.Drawing.Size(138, 27);
            this.IngCodLib.TabIndex = 7;
            this.IngCodLib.SelectedIndexChanged += new System.EventHandler(this.IngCod_SelectedIndexChanged);
            // 
            // ListPrest
            // 
            this.ListPrest.FormattingEnabled = true;
            this.ListPrest.ItemHeight = 19;
            this.ListPrest.Location = new System.Drawing.Point(64, 150);
            this.ListPrest.Name = "ListPrest";
            this.ListPrest.Size = new System.Drawing.Size(244, 137);
            this.ListPrest.TabIndex = 5;
            // 
            // FormDevLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.ListPrest);
            this.Controls.Add(this.PanelPrestLib);
            this.Controls.Add(this.BotonDevolver);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDevLib";
            this.Text = "Devolver Libro";
            this.PanelPrestLib.ResumeLayout(false);
            this.PanelPrestLib.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BotonDevolver;
        private System.Windows.Forms.TableLayoutPanel PanelPrestLib;
        private System.Windows.Forms.Label DescSoc;
        private System.Windows.Forms.Label DescLib;
        private System.Windows.Forms.ComboBox IngCodSoc;
        private System.Windows.Forms.ComboBox IngCodLib;
        private System.Windows.Forms.ListBox ListPrest;
    }
}