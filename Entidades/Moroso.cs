using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaritoFormsPractice
{
    public class Moroso
    {
        private int codmor;
        private int codlib;

        public Moroso(int codmor, int codlib)
        {
            this.codmor = codmor;
            this.codlib = codlib;
        }

        public int Codmor { get => codmor; set => codmor = value; }
        public int Codlib { get => codlib; set => codlib = value; }
    }
}
