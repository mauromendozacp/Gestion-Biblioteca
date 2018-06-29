using System;
using System.Windows.Forms;

namespace MaritoFormsPractice
{
    public partial class MenuBiblioteca : Form
    {

        public MenuBiblioteca()
        {
            InitializeComponent();
            InsertarLibro();
        }

        public void InsertarLibro()
        {
            Libro aux = new Libro(111, "Libre", "Don Quijote", "Jorge");
            Program.lib.Add(aux);
            aux = new Libro(222, "Libre", "MADRE MIA WILLY", "Mati");
            Program.lib.Add(aux);
            aux = new Libro(333, "Libre", "El Ceba2", "Ceba2");
            Program.lib.Add(aux);
            aux = new Libro(444, "Libre", "Habia una vez truz", "Mau2");
            Program.lib.Add(aux);
            aux = new Libro(555, "Libre", "Jorge, el curioso", "Jorgito Jr.");
            Program.lib.Add(aux);
        }

        private void ToolNuevoSoc_Click(object sender, EventArgs e)
        {
            FormNuevoSoc fns = new FormNuevoSoc();
            fns.MdiParent = this;
            fns.StartPosition = FormStartPosition.CenterScreen;
            fns.Show();
        }

        private void ToolBorrarSoc_Click(object sender, EventArgs e)
        {
            FormBorrarSoc fbs = new FormBorrarSoc();
            fbs.MdiParent = this;
            fbs.StartPosition = FormStartPosition.CenterScreen;
            fbs.Show();
        }

        private void ToolVerSoc_Click(object sender, EventArgs e)
        {
            FormVerLista fvls = new FormVerLista(0);
            fvls.MdiParent = this;
            fvls.StartPosition = FormStartPosition.CenterScreen;
            fvls.Show();
        }

        private void ToolVerMor_Click(object sender, EventArgs e)
        {
            FormVerLista fvlm = new FormVerLista(1);
            fvlm.MdiParent = this;
            fvlm.StartPosition = FormStartPosition.CenterScreen;
            fvlm.Show();
        }

        private void ToolVerLib_Click(object sender, EventArgs e)
        {
            FormVerLista fvll = new FormVerLista(2);
            fvll.MdiParent = this;
            fvll.StartPosition = FormStartPosition.CenterScreen;
            fvll.Show();
        }

        private void ToolVerPrest_Click(object sender, EventArgs e)
        {
            FormVerLista fvlp = new FormVerLista(3);
            fvlp.MdiParent = this;
            fvlp.StartPosition = FormStartPosition.CenterScreen;
            fvlp.Show();
        }

        private void ToolBuscarFec_Click(object sender, EventArgs e)
        {
            FormBuscarFec fvlf = new FormBuscarFec();
            fvlf.MdiParent = this;
            fvlf.StartPosition = FormStartPosition.CenterScreen;
            fvlf.Show();
        }

        private void ToolPrestLib_Click(object sender, EventArgs e)
        {
            FormPrestLib fpl = new FormPrestLib();
            fpl.MdiParent = this;
            fpl.StartPosition = FormStartPosition.CenterScreen;
            fpl.Show();
        }

        private void ToolDevLib_Click(object sender, EventArgs e)
        {
            FormDevLib fdl = new FormDevLib();
            fdl.MdiParent = this;
            fdl.StartPosition = FormStartPosition.CenterScreen;
            fdl.Show();
        }
    }
}
