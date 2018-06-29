using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaritoFormsPractice
{
    static class Program
    {
        static public List<Socio> soc = new List<Socio>();
        static public List<Moroso> mor = new List<Moroso>();
        static public List<Libro> lib = new List<Libro>();
        static public List<PrestamoLibro> preslib = new List<PrestamoLibro>();
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuBiblioteca());
        }
    }
}
