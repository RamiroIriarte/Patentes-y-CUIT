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
             
                if (mtxtPatente.Text != "")
                {
                    lblPatente.Text = "La patente cargada es:" + mtxtPatente.Text;
                }
                else
                {
                    MessageBox.Show("Debe llenar los espacios en blanco");
                }
          
            
        }

        private void rbtmVieja_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtmVieja.Checked)
            {
                mtxtPatente.Mask = " LLL000";
               
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
            MessageBox.Show("Error al introducir el dato");
        }

        private void mtxtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbtmVieja.Checked == false && rbtmNueva.Checked == false)
            {
                MessageBox.Show("Seleccione un tipo de patente");

                mtxtPatente.Text = "";
            }
            
        }
    }
}
