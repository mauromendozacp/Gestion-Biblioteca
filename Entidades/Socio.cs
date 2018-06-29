using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaritoFormsPractice
{
    public class Socio
    {
        private int codsoc;
        private int cantlib;
        private string nomb;
        private string direccion;

        public Socio(int codsoc, string nomb, string direccion)
        {
            this.codsoc = codsoc;
            this.cantlib = 0;
            this.nomb = nomb;
            this.direccion = direccion;
        }

        public int Codsoc { get => codsoc; set => codsoc = value; }
        public int Cantlib { get => cantlib; set => cantlib = value; }
        public string Nomb { get => nomb; set => nomb = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
