using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaritoFormsPractice
{
    public class PrestamoLibro
    {
        private int codsoc;
        private int codlib;
        private DateTime fechaprest;
        private DateTime fechadev;

        public PrestamoLibro()
        { }
        public PrestamoLibro(int codsoc, int codlib, DateTime fechaprest, DateTime fechadev)
        {
            this.codsoc = codsoc;
            this.codlib = codlib;
            this.fechaprest = fechaprest;
            this.fechadev = fechadev;
        }

        public int Codsoc { get => codsoc; set => codsoc = value; }
        public int Codlib { get => codlib; set => codlib = value; }
        public DateTime Fechaprest { get => fechaprest; set => fechaprest = value; }
        public DateTime Fechadev { get => fechadev; set => fechadev = value; }
    }
}
