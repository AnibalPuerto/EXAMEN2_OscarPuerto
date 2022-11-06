using BaseDatos;
using Entidades;
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
    public partial class Tickets : Form
    {
        SoporteDatos tipoSoporte = new SoporteDatos();
        Tickets ticket;
        public Tickets()
        {
            InitializeComponent();
        }

        private void txt_respuesta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_codigoSoport_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            DataGridTipoSoporte();
        }
        private async void DataGridTipoSoporte()
        {
            DetalleDataGridView.DataSource = await tipoSoporte.MostrarTablaSoporteAsync();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ticket = new Tickets();


            if (txt_nombUsuario.Text == String.Empty)
            {
                errorProvider1.SetError(txt_nombUsuario, "Ingrese un usuario");
                txt_nombUsuario.Focus();
                return;
            }
            if (dateTimePicker == null)
            {
                errorProvider1.SetError(dateTimePicker, "Ingrese una fecha");
                dateTimePicker.Focus();
                return;
            }
            if (txt_cliente.Text == String.Empty)
            {
                errorProvider1.SetError(txt_cliente, "Ingrese un Cliente");
                txt_cliente.Focus();
                return;
            }
            if (txt_codigoSoport.Text == String.Empty)
            {
                errorProvider1.SetError(txt_codigoSoport, "Ingrese un codigo");
                txt_codigoSoport.Focus();
                return;
            }
            if (txt_nombSoport.Text == String.Empty)
            {
                errorProvider1.SetError(txt_nombSoport, "Ingrese un tipo de soporte");
                txt_nombSoport.Focus();
                return;
            }
            if (txt_precioSop.Text == String.Empty)
            {
                errorProvider1.SetError(txt_precioSop, "Ingrese un precio");
                txt_precioSop.Focus();
                return;
            }
            if (txt_solicitud.Text == String.Empty)
            {
                errorProvider1.SetError(txt_solicitud, "Ingrese una descripcion");
                txt_solicitud.Focus();
                return;
            }
            if (txt_respuesta.Text == String.Empty)
            {
                errorProvider1.SetError(txt_respuesta, "Ingrese una descripcion");
                txt_respuesta.Focus();
                return;
            }

           /* ticket.
            ticket.Codigo = Convert.ToInt32(txt_codigo.Text);
            soport.Nombre = txt_nombreSoporte.Text;
            soport.Descripcion = txt_descripcion.Text;
            soport.Precio = Convert.ToDecimal(txt_precioSop.Text);

            bool insertar = await soporteDatos.InsertarDatosSoporteAsync(soport);
            if (insertar)
            {
                DataGridTipoSoporte();
                DeshabilitarCampos();
                LimpiarCampos();
                MessageBox.Show("Tipo de soporte registrado exitosamente", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo registrar el tipo de soporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
        }  
    }
}
