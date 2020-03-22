using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public String Sexo { get; set; }
        public String Cedula { get; set; }
        public String Telefono { get; set; }
        public bool EsCasado { get; set; }
        public bool EsExtranjero { get; set; }
        public bool EsBanquero { get; set; }

        public Persona(bool _esCasado, 
                       bool _esExtranjero, 
                       bool _esBanquero)
        {
            EsCasado = _esCasado;
            EsExtranjero = _esExtranjero;
            EsBanquero = _esBanquero;
        }

        public Persona()
        {
        }

        void Comer ()
        { 
        }
        void Dormir ()
        {
        }
        void Trabajar ()
        { 
        }
    }
}
