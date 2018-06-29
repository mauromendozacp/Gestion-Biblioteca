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
    public partial class FormBorrarSoc : Form
    {
        public FormBorrarSoc()
        {
            InitializeComponent();
            InsertarSocio();
        }

        public void InsertarSocio()
        {
            IngCodSoc.Items.Clear();
            for (int i = 0; i < Program.soc.Count; i++)
            {
                IngCodSoc.Items.Add(Program.soc[i].Nomb);
            }
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            int i = IngCodSoc.SelectedIndex;
            Program.soc.RemoveAt(i);
            BotonBorrar.Enabled = false;
            ListSoc.Items.Clear();
            MessageBox.Show("Socio borrado correctamente!");
            InsertarSocio();
        }

        private void IngSoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSoc.Items.Clear();
            int i, auxcs, auxcl;
            string auxn, auxd;
            i = IngCodSoc.SelectedIndex;
            auxcs = Program.soc[i].Codsoc;
            auxn = Program.soc[i].Nomb;
            auxd = Program.soc[i].Direccion;
            auxcl = Program.soc[i].Cantlib;
            ListSoc.Items.Add("Codigo: " + auxcs);
            ListSoc.Items.Add("Nombre: " + auxn);
            ListSoc.Items.Add("Dirección: " + auxd);
            ListSoc.Items.Add("Cantidad Libro: " + auxcl);
            BotonBorrar.Enabled = true;
        }
    }
}
