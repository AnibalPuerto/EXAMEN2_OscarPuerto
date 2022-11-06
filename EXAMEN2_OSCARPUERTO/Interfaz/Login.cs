using BaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_correo.Text == String.Empty)
            {
                errorProvider1.SetError(txt_correo, "Ingrese un Correo");
                txt_correo.Focus();
                return;
            }
            errorProvider1.Clear();

            if (txt_contraseña.Text == String.Empty)
            {
                errorProvider1.SetError(txt_contraseña, "Ingrese una Contraseña");
                txt_contraseña.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos userDatos = new UsuarioDatos();

            bool validar = await userDatos.LoginAsync(txt_correo.Text, txt_contraseña.Text);
            if (validar)
            {
                Menu formMenu = new Menu();
                Hide();
                formMenu.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
