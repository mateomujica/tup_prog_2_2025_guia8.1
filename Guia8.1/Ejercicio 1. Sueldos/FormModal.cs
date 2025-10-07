using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1._Sueldos
{
    public partial class FormModal : Form
    {
        public FormModal()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbAsalariado_CheckedChanged(object sender, EventArgs e)
        {
            tbxBasico.Enabled = true;
            tbxAportes.Enabled = true;
            tbxHoras.Enabled = false;
            tbxImporte.Enabled = false;
            tbxRetenciones.Enabled = false;
        }


        private void FormModal_Load(object sender, EventArgs e)
        {

        }

        private void rbJornalero_CheckedChanged(object sender, EventArgs e)
        {
            tbxHoras.Enabled = true;
            tbxImporte.Enabled = true;
            tbxRetenciones.Enabled = true;
            tbxBasico.Enabled = false;
            tbxAportes.Enabled = false;
        }
    }
}
