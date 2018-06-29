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
    public partial class FormDevLib : Form
    {
        PrestamoLibro auxpl = new PrestamoLibro();
        public FormDevLib()
        {
            InitializeComponent();
            InsertarLista();
        }
        public void InsertarLista()
        {
            InsertarSocio();
            InsertarLibro();
        }

        public void InsertarSocio()
        {
            IngCodSoc.Items.Clear();
            for (int i = 0; i < Program.soc.Count; i++)
            {
                IngCodSoc.Items.Add(Program.soc[i].Nomb);
            }
        }
        public void InsertarLibro()
        {
            IngCodLib.Items.Clear();
            for (int i = 0; i < Program.lib.Count; i++)
            {
                IngCodLib.Items.Add(Program.lib[i].Titulo);
            }
        }

        private void IngCod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IngCodSoc.SelectedIndex < 0 || IngCodLib.SelectedIndex < 0)
            {
                BotonDevolver.Enabled = false;
            }
            else
            {
                ListPrest.Items.Clear();
                int i, j;
                i = IngCodSoc.SelectedIndex;
                j = IngCodLib.SelectedIndex;
                if (ComprobarPrestamo(i, j))
                {                    
                    BotonDevolver.Enabled = true;
                }
            }
        }
        public bool ComprobarPrestamo(int i, int j)
        {
            foreach (PrestamoLibro prestlib in Program.preslib)
            {
                if (prestlib.Codsoc == Program.soc[i].Codsoc && prestlib.Codlib == Program.lib[j].Codlib)
                {
                    InsertarPrestamo(prestlib);
                    return true;
                }
            }
            return false;
        }
        public void InsertarPrestamo(PrestamoLibro prestlib)
        {
            ListPrest.Items.Add("Código Socio: " + prestlib.Codsoc);
            ListPrest.Items.Add("Código Libro: " + prestlib.Codlib);
            ListPrest.Items.Add("Fecha Prestamo: " + prestlib.Fechaprest.Date);
            ListPrest.Items.Add("Fecha Devolución: " + prestlib.Fechadev.Date);
            auxpl = prestlib;
        }
        private void BotonDevolver_Click(object sender, EventArgs e)
        {
            int auxcs, auxcl;
            auxcs = auxpl.Codsoc;
            auxcl = auxpl.Codlib;
            ActualizarSocio(auxcs);
            ActualizarLibro(auxcl);
            ActualizarMoroso(auxcs, auxcl);
            Program.preslib.Remove(auxpl);
            BotonDevolver.Enabled = false;
            ListPrest.Items.Clear();
            MessageBox.Show("Devolución realizada correctamente!");
            InsertarLista();
        }
        public void ActualizarSocio(int auxcs)
        {
            foreach (Socio soc in Program.soc)
            {
                if (soc.Codsoc == auxcs)
                {
                    soc.Cantlib--;
                }
            }
        }
        public void ActualizarLibro(int auxcl)
        {
            foreach (Libro lib in Program.lib)
            {
                if (lib.Codlib == auxcl)
                {
                    lib.Estado = "Libre";
                }
            }
        }
        public void ActualizarMoroso(int auxcs, int auxcl)
        {
            foreach (Moroso mor in Program.mor)
            {
                if (mor.Codmor == auxcs && mor.Codlib == auxcl)
                {
                    Program.mor.Remove(mor);
                }
            }
        }
    }
}
