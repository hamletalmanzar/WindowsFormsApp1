using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Animal
    {  
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int PatasCantidad { get; set; }
        public bool Macho { get; set; }
        public DateTime Nacimiento { get; set; }
        public decimal Peso { get; set; }

        void Alimentarse ()
        {

        }

    }
}
