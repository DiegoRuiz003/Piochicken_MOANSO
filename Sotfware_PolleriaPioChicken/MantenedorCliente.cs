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
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
            listarCliente();
            txtIdCL.Enabled = false;
        }
        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }
        private void LimpiarVariables()
        {
            txtNombreCL.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cbxEstadoCL.Checked = false;
            //cbkEstadoCliente.Checked = false;

        }

        private void btnCrearCL_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entCliente cl = new entCliente();
                cl.Nombre = txtNombreCL.Text.Trim();
                cl.Dni = txtDni.Text.Trim();
                cl.Telefono = txtTelefono.Text.Trim();
                cl.Correo = txtCorreo.Text.Trim();
                cl.Estado = cbxEstadoCL.Checked;
                logCliente.Instancia.InsertarCliente(cl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;
            listarCliente();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex]; //
            txtIdCL.Text = filaActual.Cells[0].Value.ToString();
            txtNombreCL.Text = filaActual.Cells[1].Value.ToString();
            txtDni.Text = filaActual.Cells[2].Value.ToString();
            txtTelefono.Text = filaActual.Cells[3].Value.ToString();
            txtCorreo.Text = filaActual.Cells[4].Value.ToString();
            cbxEstadoCL.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }

        private void btnModificarCL_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente cl = new entCliente();
                cl.Id= int.Parse(txtIdCL.Text.Trim());
                cl.Nombre = txtNombreCL.Text.Trim();
                cl.Dni = txtDni.Text.Trim();
                cl.Telefono = txtTelefono.Text.Trim();
                cl.Correo = txtCorreo.Text.Trim();               
                cl.Estado = cbxEstadoCL.Checked;
                logCliente.Instancia.EditarCliente(cl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;
            listarCliente();
        }

        private void btnEliminarCL_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente cl = new entCliente();
                cl.Id = int.Parse(txtIdCL.Text.Trim());
                cbxEstadoCL.Checked = false;
                cl.Estado = cbxEstadoCL.Checked;
                logCliente.Instancia.EliminarCliente(cl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;
            listarCliente();
        }

        private void btnLeerCL_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource = logCliente.Instancia.LeerCliente();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelarCL_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }
    }
}
