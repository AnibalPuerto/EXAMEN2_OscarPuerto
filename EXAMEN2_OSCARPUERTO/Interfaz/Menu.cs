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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ingresarUnNuevoTipoDeSoporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoSoporte SoporteForm = new TipoSoporte();
            SoporteForm.Show();
        }

        private void generarTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tickets ticketsForm = new Tickets();
            ticketsForm.Show();
        }
    }
}
