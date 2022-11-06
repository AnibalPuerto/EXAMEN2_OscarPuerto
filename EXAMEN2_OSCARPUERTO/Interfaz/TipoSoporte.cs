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
using Entidades;


namespace Interfaz
{
    public partial class TipoSoporte : Form
    {
        public TipoSoporte()
        {
            InitializeComponent();
        }

        SoporteDatos soporteDatos = new SoporteDatos();
        Soporte soport;
        string boton = string.Empty;

        private void TipoSoporte_Load(object sender, EventArgs e)
        {
            DataGridTipoSoporte();
        }
        private async void DataGridTipoSoporte()
        {
            SoporteDataGridView.DataSource = await soporteDatos.MostrarTablaSoporteAsync();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            boton = "Nuevo";
            HabilitarCampos();
        }

        //procedimiento del boton Nuevo
        private void HabilitarCampos() 
        {
            txt_codigo.ReadOnly = false;
            txt_codigo.Enabled = true;
            txt_nombreSoporte.Enabled = true;
            txt_descripcion.Enabled = true;
            txt_precio.Enabled = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
        }


        //procedimiento del boton Cancelar
        private void DeshabilitarCampos()
        {
            txt_codigo.Enabled = false;
            txt_nombreSoporte.Enabled = false;
            txt_descripcion.Enabled = false;
            txt_precio.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        //Procedimiento para limpiar
        private void LimpiarCampos()
        {
            txt_codigo.Clear();
            txt_nombreSoporte.Clear();
            txt_descripcion.Clear();
            txt_precio.Clear();
        }

        //BOTON MODIFICAR
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            boton = "Modificar";
            if (SoporteDataGridView.SelectedRows.Count > 0)
            {
                txt_codigo.Text = SoporteDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                txt_nombreSoporte.Text = SoporteDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                txt_descripcion.Text = SoporteDataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                txt_precio.Text = SoporteDataGridView.CurrentRow.Cells["Precio"].Value.ToString();


                HabilitarCampos();
                txt_codigo.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro para poder modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //BOTON GUARDAR
        private async void btn_guardar_Click(object sender, EventArgs e)
        {
            soport = new Soporte();
            if (boton == "Nuevo")
            {
                if (txt_codigo.Text == String.Empty)
                {
                    errorProviderSoporte.SetError(txt_codigo, "Ingrese un Codigo");
                    txt_codigo.Focus();
                    return;
                }
                if (txt_nombreSoporte.Text == String.Empty)
                {
                    errorProviderSoporte.SetError(txt_nombreSoporte, "Ingrese un Nombre de Soporte");
                    txt_nombreSoporte.Focus();
                    return;
                }
                if (txt_descripcion.Text == String.Empty)
                {
                    errorProviderSoporte.SetError(txt_descripcion, "Ingrese una descripcion");
                    txt_descripcion.Focus();
                    return;
                }
                if (txt_precio.Text == String.Empty)
                {
                    errorProviderSoporte.SetError(txt_codigo, "Ingrese un precio");
                    txt_precio.Focus();
                    return;
                }
                soport.Codigo = Convert.ToInt32(txt_codigo.Text);
                soport.Nombre = txt_nombreSoporte.Text;
                soport.Descripcion = txt_descripcion.Text;
                soport.Precio = Convert.ToDecimal(txt_precio.Text);

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

                }
            }
            else if (boton == "Modificar")
            {
                if (txt_codigo.Text == String.Empty)
                {
                    errorProviderSoporte.SetError(txt_codigo, "Ingrese un Codigo");
                    txt_codigo.Focus();
                    return;
                }
                if (txt_nombreSoporte.Text == String.Empty)
                {
                    errorProviderSoporte.SetError(txt_nombreSoporte, "Ingrese un Nombre de Soporte");
                    txt_nombreSoporte.Focus();
                    return;
                }
                if (txt_descripcion.Text == String.Empty)
                {
                    errorProviderSoporte.SetError(txt_descripcion, "Ingrese una descripcion");
                    txt_descripcion.Focus();
                    return;
                }
                if (txt_precio.Text == String.Empty)
                {
                    errorProviderSoporte.SetError(txt_codigo, "Ingrese un precio");
                    txt_precio.Focus();
                    return;
                }
                soport.Codigo = Convert.ToInt32(txt_codigo.Text);
                soport.Nombre = txt_nombreSoporte.Text;
                soport.Descripcion = txt_descripcion.Text;
                soport.Precio = Convert.ToDecimal(txt_precio.Text);

                bool modificar = await soporteDatos.ModificarDatosSoporteAsync(soport);
                if (modificar)
                {
                    DataGridTipoSoporte();
                    DeshabilitarCampos();
                    LimpiarCampos();
                    MessageBox.Show("Registro modificado exitosamente", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
