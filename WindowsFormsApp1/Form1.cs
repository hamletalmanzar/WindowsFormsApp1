using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Persona per1 = new Persona();
            Estudiante est1 = new Estudiante();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
