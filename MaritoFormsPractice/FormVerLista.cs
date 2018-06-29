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
    public partial class FormVerLista : Form
    {
        public FormVerLista(int i)
        {
            InitializeComponent();
            InsertarLista(i);
        }
        public void InsertarLista(int i)
        {
            switch (i)
            {
                case 0: ListView.DataSource = Program.soc;
                    break;
                case 1: ListView.DataSource = Program.mor;
                    break;
                case 2: ListView.DataSource = Program.lib;
                    break;
                case 3: ListView.DataSource = Program.preslib;
                    break;
                default: this.Close();
                    break;
            }
        }
    }
}
