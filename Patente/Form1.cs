using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }




        private void btmCargar_Click(object sender, EventArgs e)
        {
            if (rbtmVieja.Checked == true || rbtmNueva.Checked == true)
            {
                if (mtxtPatente.Text.Length != 6 && mtxtPatente.Text.Length != 7)
                {
                    MessageBox.Show("Debe llenar todos los espacios en blanco");
                }
                else
                {
                    rbtmVieja.Checked = false;
                    rbtmNueva.Checked = false;
                    lblPatente.Text = "La patente cargada es: " + mtxtPatente.Text.ToUpper();
                    mtxtPatente.Text = "";
                }
            }
            else
            {
                if (mtxtPatente.Text.Length != 11)
                {
                    MessageBox.Show("Debe llenar todos los espacios en blanco");
                }
                else
                {
                    lblPatente.Text = "El CUIT pertenece al DNI: " + mtxtPatente.Text.Substring(2, 8);
                    lblCuit.Text = "EL CUIT cargado es: " + mtxtPatente.Text.Substring(0, 2) + "-" + mtxtPatente.Text.Substring(2, 8) + "-" + mtxtPatente.Text.Substring(10, 1);
                    mtxtPatente.Text = "";
                }
            }
          
                   
        }

        private void rbtmVieja_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtmVieja.Checked)
            {
                mtxtPatente.Mask = "LLL000";
               
            }
        }

        private void rbtmNueva_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtmNueva.Checked)
            {
                mtxtPatente.Mask = "LL000LL";
              
            }
        }

        private void mtxtPatente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            lblPatente.Text = "Error al introducir el dato";
        }

        private void mtxtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbtmVieja.Checked == false && rbtmNueva.Checked == false && rbtmCUIT.Checked == false)
            {
                e.Handled = true;
                MessageBox.Show("Seleccione un tipo de patente");
            }
            
        }

        private void rbtmCUIT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtmCUIT.Checked)
            {
                mtxtPatente.Mask = "00000000000";

            }
        }


    }
}
