using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP_III_tarea2
{
    public partial class Evaluacion1 : Form
    {
        public Evaluacion1()
        {
            InitializeComponent();
        }

        private void btnCalcularSueldo_Click(object sender, EventArgs e)
        {
            DateTime fechaNac = dTPFNac.Value;
            DateTime fechaIng = dTPFIng.Value;

            double sueldo = Convert.ToDouble(txtSueldo.Text), ventasPM = Convert.ToDouble(txtVentasPM.Text);


            if (ventasPM > 10000 && calcularEdad(fechaNac) >= 30 && calcularAniosL(fechaIng) >= 10)
            {
                sueldo = sueldo + (sueldo * 0.05);
                MessageBox.Show("Su sueldo aumentó en un 5% exitosamente. Sueldo actual: L." + sueldo);
            }
            else
            {
                if(ventasPM <= 10000)
                {
                    MessageBox.Show("Su sueldo no puede aumentar en 5% porque sus " +
                        "ventas promedio mensuales son inferiores o igual a L.10,000","", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }if(calcularEdad(fechaNac) < 30)
                {
                    MessageBox.Show("Su sueldo no puede aumentar en 5% porque su edad es " +
                        "menor a 30 años", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }if (calcularAniosL(fechaIng) < 10)
                {
                    MessageBox.Show("Su sueldo no puede aumentar en 5% porque su tiempo " +
                        "laborando en la empresa es inferior a 10 años", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }


        }

        private int calcularEdad(DateTime fNacimiento)
        {
            DateTime fNac = fNacimiento;
            DateTime fAct = DateTime.Now;

            int edad = 0;

            if (fNac > fAct)
            {
                MessageBox.Show("La fecha de nacimiento que ingresó es mayor a la actual");
                return 0;
            }
            {
                edad = fAct.Year - fNac.Year;
                if (fNac.Month > fAct.Month)
                {
                    --edad;
                }
            }

            return edad;

        }

        private int calcularAniosL(DateTime _fIngreso)
        {
            DateTime fIngreso = _fIngreso;
            DateTime fAct = DateTime.Now;

            int aniosLaborando = 0;

            if (fIngreso > fAct)
            {
                MessageBox.Show("La fecha de ingreso a la empresa que eligió es mayor a la actual");
                return 0;
            }
            {
                aniosLaborando = fAct.Year - fIngreso.Year;
                if (fIngreso.Month > fAct.Month)
                {
                    --aniosLaborando;
                }
            }

            return aniosLaborando;

        }


    }
}
