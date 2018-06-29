using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaritoFormsPractice
{
    public partial class FormBuscarFec : Form
    {
        public FormBuscarFec()
        {
            InitializeComponent();
            PrestView.DataSource = Program.preslib;
        }

        private void IngFec_ValueChanged(object sender, EventArgs e)
        {
            PrestView.Refresh();
            List<PrestamoLibro> listpl = new List<PrestamoLibro>();
            DateTime auxfd = IngFec.Value.Date;
            foreach (PrestamoLibro prestlib in Program.preslib)
            {
                if (prestlib.Fechadev == auxfd)
                {
                    listpl.Add(prestlib);
                }
            }
            PrestView.DataSource = listpl;
        }
    }
}
