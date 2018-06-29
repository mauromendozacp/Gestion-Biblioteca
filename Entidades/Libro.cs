using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaritoFormsPractice
{
    public class Libro
    {
        private int codlib;
        private string estado;
        private string titulo;
        private string autor;

        public Libro(int codlib, string estado, string titulo, string autor)
        {
            this.codlib = codlib;
            this.estado = estado;
            this.titulo = titulo;
            this.autor = autor;
        }

        public int Codlib { get => codlib; set => codlib = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
    }
}
