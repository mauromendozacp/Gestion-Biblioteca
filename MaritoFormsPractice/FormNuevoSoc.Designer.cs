namespace MaritoFormsPractice
{
    partial class FormNuevoSoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoSoc));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DescCodSoc = new System.Windows.Forms.Label();
            this.DescNomb = new System.Windows.Forms.Label();
            this.DescDir = new System.Windows.Forms.Label();
            this.IngCodSoc = new System.Windows.Forms.TextBox();
            this.IngNomb = new System.Windows.Forms.TextBox();
            this.IngDir = new System.Windows.Forms.TextBox();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.36264F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.63736F));
            this.tableLayoutPanel1.Controls.Add(this.DescCodSoc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DescNomb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DescDir, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IngCodSoc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.IngNomb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.IngDir, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 296);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DescCodSoc
            // 
            this.DescCodSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescCodSoc.AutoSize = true;
            this.DescCodSoc.Location = new System.Drawing.Point(16, 39);
            this.DescCodSoc.Name = "DescCodSoc";
            this.DescCodSoc.Size = new System.Drawing.Size(101, 19);
            this.DescCodSoc.TabIndex = 0;
            this.DescCodSoc.Text = "Código Socio:";
            // 
            // DescNomb
            // 
            this.DescNomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescNomb.AutoSize = true;
            this.DescNomb.Location = new System.Drawing.Point(32, 137);
            this.DescNomb.Name = "DescNomb";
            this.DescNomb.Size = new System.Drawing.Size(69, 19);
            this.DescNomb.TabIndex = 1;
            this.DescNomb.Text = "Nombre:";
            // 
            // DescDir
            // 
            this.DescDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescDir.AutoSize = true;
            this.DescDir.Location = new System.Drawing.Point(28, 236);
            this.DescDir.Name = "DescDir";
            this.DescDir.Size = new System.Drawing.Size(77, 19);
            this.DescDir.TabIndex = 2;
            this.DescDir.Text = "Dirección:";
            // 
            // IngCodSoc
            // 
            this.IngCodSoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngCodSoc.Location = new System.Drawing.Point(163, 35);
            this.IngCodSoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngCodSoc.Name = "IngCodSoc";
            this.IngCodSoc.Size = new System.Drawing.Size(167, 27);
            this.IngCodSoc.TabIndex = 4;
            this.IngCodSoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxIng_KeyPress);
            // 
            // IngNomb
            // 
            this.IngNomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngNomb.Location = new System.Drawing.Point(163, 133);
            this.IngNomb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngNomb.Name = "IngNomb";
            this.IngNomb.Size = new System.Drawing.Size(167, 27);
            this.IngNomb.TabIndex = 5;
            // 
            // IngDir
            // 
            this.IngDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngDir.Location = new System.Drawing.Point(163, 232);
            this.IngDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngDir.Name = "IngDir";
            this.IngDir.Size = new System.Drawing.Size(167, 27);
            this.IngDir.TabIndex = 6;
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(139, 320);
            this.BotonAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(99, 34);
            this.BotonAceptar.TabIndex = 1;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // FormNuevoSoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNuevoSoc";
            this.Text = "Nuevo Socio";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DescCodSoc;
        private System.Windows.Forms.Label DescNomb;
        private System.Windows.Forms.Label DescDir;
        private System.Windows.Forms.TextBox IngCodSoc;
        private System.Windows.Forms.TextBox IngNomb;
        private System.Windows.Forms.TextBox IngDir;
        private System.Windows.Forms.Button BotonAceptar;
    }
}

