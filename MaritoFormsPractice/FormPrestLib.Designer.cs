namespace MaritoFormsPractice
{
    partial class FormPrestLib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrestLib));
            this.PanelPrestLib = new System.Windows.Forms.TableLayoutPanel();
            this.DescFecDev = new System.Windows.Forms.Label();
            this.DescCodSoc = new System.Windows.Forms.Label();
            this.DescCodLib = new System.Windows.Forms.Label();
            this.DescFecPrest = new System.Windows.Forms.Label();
            this.IngCodSoc = new System.Windows.Forms.TextBox();
            this.IngCodLib = new System.Windows.Forms.TextBox();
            this.IngFecPrest = new System.Windows.Forms.DateTimePicker();
            this.IngFecDev = new System.Windows.Forms.DateTimePicker();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.PanelPrestLib.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrestLib
            // 
            this.PanelPrestLib.ColumnCount = 2;
            this.PanelPrestLib.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.72222F));
            this.PanelPrestLib.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.27778F));
            this.PanelPrestLib.Controls.Add(this.DescFecDev, 0, 3);
            this.PanelPrestLib.Controls.Add(this.DescCodSoc, 0, 0);
            this.PanelPrestLib.Controls.Add(this.DescCodLib, 0, 1);
            this.PanelPrestLib.Controls.Add(this.DescFecPrest, 0, 2);
            this.PanelPrestLib.Controls.Add(this.IngCodSoc, 1, 0);
            this.PanelPrestLib.Controls.Add(this.IngCodLib, 1, 1);
            this.PanelPrestLib.Controls.Add(this.IngFecPrest, 1, 2);
            this.PanelPrestLib.Controls.Add(this.IngFecDev, 1, 3);
            this.PanelPrestLib.Location = new System.Drawing.Point(12, 13);
            this.PanelPrestLib.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelPrestLib.Name = "PanelPrestLib";
            this.PanelPrestLib.RowCount = 4;
            this.PanelPrestLib.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PanelPrestLib.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PanelPrestLib.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PanelPrestLib.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PanelPrestLib.Size = new System.Drawing.Size(360, 296);
            this.PanelPrestLib.TabIndex = 1;
            // 
            // DescFecDev
            // 
            this.DescFecDev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescFecDev.AutoSize = true;
            this.DescFecDev.Location = new System.Drawing.Point(4, 249);
            this.DescFecDev.Name = "DescFecDev";
            this.DescFecDev.Size = new System.Drawing.Size(133, 19);
            this.DescFecDev.TabIndex = 7;
            this.DescFecDev.Text = "Fecha Devolución:";
            // 
            // DescCodSoc
            // 
            this.DescCodSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescCodSoc.AutoSize = true;
            this.DescCodSoc.Location = new System.Drawing.Point(20, 27);
            this.DescCodSoc.Name = "DescCodSoc";
            this.DescCodSoc.Size = new System.Drawing.Size(101, 19);
            this.DescCodSoc.TabIndex = 0;
            this.DescCodSoc.Text = "Código Socio:";
            // 
            // DescCodLib
            // 
            this.DescCodLib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescCodLib.AutoSize = true;
            this.DescCodLib.Location = new System.Drawing.Point(21, 101);
            this.DescCodLib.Name = "DescCodLib";
            this.DescCodLib.Size = new System.Drawing.Size(99, 19);
            this.DescCodLib.TabIndex = 1;
            this.DescCodLib.Text = "Código Libro:";
            // 
            // DescFecPrest
            // 
            this.DescFecPrest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescFecPrest.AutoSize = true;
            this.DescFecPrest.Location = new System.Drawing.Point(10, 175);
            this.DescFecPrest.Name = "DescFecPrest";
            this.DescFecPrest.Size = new System.Drawing.Size(121, 19);
            this.DescFecPrest.TabIndex = 2;
            this.DescFecPrest.Text = "Fecha Prestamo:";
            // 
            // IngCodSoc
            // 
            this.IngCodSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngCodSoc.Location = new System.Drawing.Point(189, 23);
            this.IngCodSoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngCodSoc.Name = "IngCodSoc";
            this.IngCodSoc.Size = new System.Drawing.Size(123, 27);
            this.IngCodSoc.TabIndex = 4;
            this.IngCodSoc.TextChanged += new System.EventHandler(this.IngCod_TextChanged);
            this.IngCodSoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxIng_KeyPress);
            // 
            // IngCodLib
            // 
            this.IngCodLib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngCodLib.Location = new System.Drawing.Point(189, 97);
            this.IngCodLib.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngCodLib.Name = "IngCodLib";
            this.IngCodLib.Size = new System.Drawing.Size(123, 27);
            this.IngCodLib.TabIndex = 5;
            this.IngCodLib.TextChanged += new System.EventHandler(this.IngCod_TextChanged);
            this.IngCodLib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxIng_KeyPress);
            // 
            // IngFecPrest
            // 
            this.IngFecPrest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngFecPrest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IngFecPrest.Location = new System.Drawing.Point(191, 171);
            this.IngFecPrest.Name = "IngFecPrest";
            this.IngFecPrest.Size = new System.Drawing.Size(120, 27);
            this.IngFecPrest.TabIndex = 8;
            // 
            // IngFecDev
            // 
            this.IngFecDev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngFecDev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IngFecDev.Location = new System.Drawing.Point(191, 245);
            this.IngFecDev.Name = "IngFecDev";
            this.IngFecDev.Size = new System.Drawing.Size(120, 27);
            this.IngFecDev.TabIndex = 9;
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Enabled = false;
            this.BotonAceptar.Location = new System.Drawing.Point(127, 317);
            this.BotonAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(99, 34);
            this.BotonAceptar.TabIndex = 2;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // FormPrestLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.PanelPrestLib);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrestLib";
            this.Text = "Prestar Libro";
            this.PanelPrestLib.ResumeLayout(false);
            this.PanelPrestLib.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelPrestLib;
        private System.Windows.Forms.Label DescFecDev;
        private System.Windows.Forms.Label DescCodSoc;
        private System.Windows.Forms.Label DescCodLib;
        private System.Windows.Forms.Label DescFecPrest;
        private System.Windows.Forms.TextBox IngCodSoc;
        private System.Windows.Forms.TextBox IngCodLib;
        private System.Windows.Forms.DateTimePicker IngFecPrest;
        private System.Windows.Forms.DateTimePicker IngFecDev;
        private System.Windows.Forms.Button BotonAceptar;
    }
}