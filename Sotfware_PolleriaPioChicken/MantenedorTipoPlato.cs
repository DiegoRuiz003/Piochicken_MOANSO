using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sotfware_PolleriaPioChicken
{
    public partial class MantenedorTipoPlato : Form
    {
        public MantenedorTipoPlato()
        {
            InitializeComponent();
            ListarTipoPlato();
            gbDatos.Enabled = false;
        }

        public void ListarTipoPlato()
        {
            dgvTipoPlato.DataSource = LogTipoPlato.Instancia.ListarTipoPlato();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void LimpiarVariables()
        {
            txtId.Text = "";
            txtNombre.Text = " ";
            cbEstado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntTipoPlato tp = new EntTipoPlato();
                tp.id = txtId.Text;
                tp.nombre = txtNombre.Text;
                tp.estado = cbEstado.Checked;
                LogTipoPlato.Instancia.InsertarTipoPlato(tp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatos.Enabled = false;
            ListarTipoPlato();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntTipoPlato tp = new EntTipoPlato();
                tp.id = txtId.Text;
                tp.nombre = txtNombre.Text;
                tp.estado = cbEstado.Checked;
                LogTipoPlato.Instancia.EditarTipoPlato(tp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatos.Enabled = false;
            ListarTipoPlato();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;

        }

        private void dgvTipoPlato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTipoPlato.Rows[e.RowIndex]; //
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntTipoPlato tp = new EntTipoPlato();
                tp.id = txtId.Text;
                LogTipoPlato.Instancia.DeshabilitarTipoPlato(tp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatos.Enabled = false;
            ListarTipoPlato();

        }
    }
}
