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
    public partial class MantenedorTipoInsumo : Form
    {
        public MantenedorTipoInsumo()
        {
            InitializeComponent();
            ListarTipoInsumo();
            gbDatos.Enabled = false;
        }

        public void ListarTipoInsumo()
        {
            dgvTipoInsumo.DataSource = LogTipoInsumo.Instancia.ListarTipoInsumo();
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
                EntTipoInsumo ti = new EntTipoInsumo();
                ti.id = txtId.Text;
                ti.nombre = txtNombre.Text;
                ti.estado = cbEstado.Checked;
                LogTipoInsumo.Instancia.InsertarTipoInsumo(ti);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatos.Enabled = false;
            ListarTipoInsumo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntTipoInsumo ti = new EntTipoInsumo();
                ti.id = txtId.Text;
                ti.nombre = txtNombre.Text;
                ti.estado = cbEstado.Checked;
                LogTipoInsumo.Instancia.EditarTipoInsumo(ti);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatos.Enabled = false;
            ListarTipoInsumo();
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
            DataGridViewRow filaActual = dgvTipoInsumo.Rows[e.RowIndex]; //
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntTipoInsumo ti = new EntTipoInsumo();
                ti.id = txtId.Text;
                LogTipoInsumo.Instancia.DeshabilitarTipoInsumo(ti);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatos.Enabled = false;
            ListarTipoInsumo();

        }
    }
}
