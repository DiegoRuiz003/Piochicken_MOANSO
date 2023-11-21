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
    public partial class MantenedorMetododePago : Form
    {
        public MantenedorMetododePago()
        {
            InitializeComponent();
            listarMetodoPago();
            txtIdMP.Enabled = false;
        }
        public void listarMetodoPago()
        {
            dgvMetodoPago.DataSource = LogMetodoPago.Instancia.ListarMetodoPago();
        }
        private void LimpiarVariables()
        {
            txtMetodoPago.Text = "";
            cbxEstadoMP.Checked = false;
            //cbkEstadoCliente.Checked = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarMP_Click(object sender, EventArgs e)
        {
            try
            {
                EntMetodoPago mp = new EntMetodoPago();
                mp.MetodoPago = txtMetodoPago.Text.Trim();
                mp.Estado = cbxEstadoMP.Checked;
                LogMetodoPago.Instancia.InsertarMetodoPago(mp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarMetodoPago();
        }

        private void btnModificarMP_Click(object sender, EventArgs e)
        {
            try
            {
                EntMetodoPago mp = new EntMetodoPago();
                mp.Id=int.Parse(txtIdMP.Text.Trim());
                mp.MetodoPago = txtMetodoPago.Text.Trim();
                mp.Estado = cbxEstadoMP.Checked;
                LogMetodoPago.Instancia.EditarMetodoPago(mp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarMetodoPago();
        }

        private void dgvMetodoPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMetodoPago.Rows[e.RowIndex]; 
            txtIdMP.Text = filaActual.Cells[0].Value.ToString();
            txtMetodoPago.Text = filaActual.Cells[1].Value.ToString();
            cbxEstadoMP.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void btnDeshabilitarMP_Click(object sender, EventArgs e)
        {
            try
            {
                EntMetodoPago mp = new EntMetodoPago();
                mp.Id = int.Parse(txtIdMP.Text.Trim());
                cbxEstadoMP.Checked = false;
                mp.Estado = cbxEstadoMP.Checked;
                LogMetodoPago.Instancia.EliminarMetodoPago(mp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarMetodoPago();
        }

        private void btnCancelarMP_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }
    }
}
