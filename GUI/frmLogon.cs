using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace GUI
{
    public partial class frmLogon : Form
    {
        BLLUsuario ngusuario = new BLLUsuario();
//        Dim WithEvents ngtexto As New BLLTexto
//    Dim WithEvents ngidioma As New BLLIdioma
//    Dim WithEvents ngusuario As New BLLusuario
        

        static void Main() {
            Application.Run(new frmLogon());
        }

        public frmLogon()
        {
            InitializeComponent();
        }


        private void buttonX1_Click(object sender, EventArgs e)
        {
            BEUsuario unusuario = new BEUsuario();
            // Dim sesion As BESesion 
            BESesion sesion;
            unusuario.IDusuario = Convert.ToInt32(txtUsuario.Text);
            unusuario.Password = txtContra.Text;


            // Autenticación de usuario
            unusuario = ngusuario.LogOn(unusuario);
            if (unusuario.IDusuario > 0)
            {
                //BESesion.Instancia.Idioma = unusuario.Idioma;
                this.Hide();
            }
            else
            {
                if (BESesion.Instancia.IntentosFallidos < 3)
                {
                    BESesion.Instancia.IntentosFallidos += 1;
                }
                else
                {
                    //Demasiados intentos fallidos, sale de la aplicació
                    MessageBox.Show("Demasiados intentos fallidos.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.TextLength > 0)
            {
                txtContra.Enabled = true;
                btnAcceder.Enabled = true;
                
            }
            else
            {
                txtContra.Enabled = false;
                txtContra.Text = "";
                btnAcceder.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
