namespace MaritoFormsPractice
{
    partial class FormBuscarFec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarFec));
            this.DescFec = new System.Windows.Forms.Label();
            this.IngFec = new System.Windows.Forms.DateTimePicker();
            this.PrestView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PrestView)).BeginInit();
            this.SuspendLayout();
            // 
            // DescFec
            // 
            this.DescFec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescFec.AutoSize = true;
            this.DescFec.Location = new System.Drawing.Point(28, 24);
            this.DescFec.Name = "DescFec";
            this.DescFec.Size = new System.Drawing.Size(133, 19);
            this.DescFec.TabIndex = 6;
            this.DescFec.Text = "Fecha Devolución:";
            // 
            // IngFec
            // 
            this.IngFec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IngFec.Location = new System.Drawing.Point(184, 18);
            this.IngFec.Name = "IngFec";
            this.IngFec.Size = new System.Drawing.Size(163, 27);
            this.IngFec.TabIndex = 7;
            this.IngFec.ValueChanged += new System.EventHandler(this.IngFec_ValueChanged);
            // 
            // PrestView
            // 
            this.PrestView.AllowUserToAddRows = false;
            this.PrestView.AllowUserToDeleteRows = false;
            this.PrestView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PrestView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrestView.Location = new System.Drawing.Point(12, 66);
            this.PrestView.MultiSelect = false;
            this.PrestView.Name = "PrestView";
            this.PrestView.ReadOnly = true;
            this.PrestView.RowHeadersVisible = false;
            this.PrestView.Size = new System.Drawing.Size(360, 283);
            this.PrestView.TabIndex = 8;
            // 
            // FormBuscarFec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.PrestView);
            this.Controls.Add(this.IngFec);
            this.Controls.Add(this.DescFec);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBuscarFec";
            this.Text = "Buscar Prestamo por Fecha";
            ((System.ComponentModel.ISupportInitialize)(this.PrestView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescFec;
        private System.Windows.Forms.DateTimePicker IngFec;
        private System.Windows.Forms.DataGridView PrestView;
    }
}