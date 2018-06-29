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
    public partial class FormPrestLib : Form
    {
        public FormPrestLib()
        {
            InitializeComponent();
        }
        public void LimpiarCampos()
        {
            IngCodSoc.ResetText();
            IngCodLib.ResetText();
            IngFecPrest.ResetText();
            IngFecDev.ResetText();
            IngCodSoc.Focus();
        }
        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if(ComprobarCodSoc() && ComprobarCodLib() && ComprobarFecDev())
            {
                PrestamoLibro auxpl;
                int auxcs, auxcl;
                DateTime auxfp, auxfd;
                auxcs = Convert.ToInt32(IngCodSoc.Text);
                auxcl = Convert.ToInt32(IngCodLib.Text);
                auxfp = IngFecPrest.Value.Date;
                auxfd = IngFecDev.Value.Date;
                auxpl = new PrestamoLibro(auxcs, auxcl, auxfp, auxfd);

                ActualizarSocio(auxcs);
                ActualizarLibro(auxcl);
                ActualizarMoroso(auxfd, auxcs, auxcl);
                Program.preslib.Add(auxpl);
                MessageBox.Show("Prestamo realizado correctamente!");
                LimpiarCampos();
            }
        }
        public void ActualizarSocio(int auxcs)
        {
            foreach (Socio soc in Program.soc)
            {
                if (soc.Codsoc == auxcs)
                {
                    soc.Cantlib++;
                }
            }
        }
        public void ActualizarLibro(int auxcl)
        {
            foreach (Libro lib in Program.lib)
            {
                if (lib.Codlib == auxcl)
                {
                    lib.Estado = "Prestado";
                }
            }
        }
        public void ActualizarMoroso(DateTime auxfd, int auxcs, int auxcl)
        {
            if (DateTime.Now > auxfd)
            {
                Moroso auxm = new Moroso(auxcs, auxcl);
                Program.mor.Add(auxm);
            }
        }
        public bool ComprobarCodSoc()
        {
            int auxcs = Convert.ToInt32(IngCodSoc.Text);
            foreach (Socio soc in Program.soc)
            {
                if (soc.Codsoc == auxcs)
                {
                    if (soc.Cantlib > 2)
                    {
                        MessageBox.Show("El Socio ha superado el limite de prestamos!");
                        return false;
                    }
                    return ComprobarMoroso(auxcs);
                }
            }
            MessageBox.Show("Código Socio inexistente!");
            return false;
        }
        public bool ComprobarMoroso(int auxcs)
        {
            foreach (Moroso mor in Program.mor)
            {
                if (mor.Codmor == auxcs)
                {
                    MessageBox.Show("Este socio es un MOROSO! >:V");
                    return false;
                }
            }
            return true;
        }
        public bool ComprobarCodLib()
        {
            int auxcl = Convert.ToInt32(IngCodLib.Text);
            foreach (Libro lib in Program.lib)
            {
                if (lib.Codlib == auxcl)
                {
                    if (lib.Estado != "Libre")
                    {
                        MessageBox.Show("Libro " + lib.Estado + "!");
                        return false;
                    }
                    return true;
                }
            }
            MessageBox.Show("Código Libro inexistente!");
            return false;
        }
        public bool ComprobarFecDev()
        {
            if (IngFecPrest.Value > IngFecDev.Value)
            {
                MessageBox.Show("La fecha de devolución no puede ser inferior a la fecha del prestamo!");
                return false;
            }
            else
            {
                return true;
            }
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

        private void IngCod_TextChanged(object sender, EventArgs e)
        {
            if (IngCodSoc.Text != "" && IngCodLib.Text != "")
            {
                BotonAceptar.Enabled = true;
            }
            else
            {
                BotonAceptar.Enabled = false;
            }
        }
    }
}
