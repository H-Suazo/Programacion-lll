using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_LP_III
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] estudiante = new string[5];
        string[] edad = new string[5];
        int a = 0;

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            
            estudiante[a] = txtNombre.Text;

            edad[a] = txtEdad.Text;

            a = a + 1;
        }

        private void btnEjecutar2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < estudiante.Length; i++)
            {
                listBox1.Items.Add("Nombre: "+ estudiante[i] + ", " + "Edad: "+ edad[i]);

            }

        }
    }
}

