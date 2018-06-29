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
    public partial class FormNuevoSoc : Form
    {
        public FormNuevoSoc()
        {
            InitializeComponent();
        }
        private void BoxIng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public bool ComprobarCampos()
        {
            if (IngCodSoc.Text == "" || IngNomb.Text == "" || IngDir.Text == "")
            {
                MessageBox.Show("Complete todos los campos!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                Socio auxsoc;
                int auxcs;
                string auxn, auxd;
                auxcs = Convert.ToInt32(IngCodSoc.Text);
                auxn = IngNomb.Text;
                auxd = IngDir.Text;
                auxsoc = new Socio(auxcs, auxn, auxd);

                Program.soc.Add(auxsoc);
                MessageBox.Show("Socio Agregado!");
                LimpiarCampos();
            }
        }

        public void LimpiarCampos()
        {
            IngCodSoc.ResetText();
            IngNomb.ResetText();
            IngDir.ResetText();
            IngCodSoc.Focus();
        }
    }
}
