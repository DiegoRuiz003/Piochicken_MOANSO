using CapaLogica;
using CapaEntidad;
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
    public partial class MantenedorProveedor : Form
    {
        public MantenedorProveedor()
        {
            InitializeComponent();
            listarProveedor();
            txtIdPV.Enabled = false;
        }

        public void listarProveedor()
        {
            dgvProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
        }
        private void LimpiarVariables()
        {
            txtNombrePV.Text = "";
            txtRazonPV.Text = "";
            txtTelefonoPV.Text = "";
            //cbkEstadoCliente.Checked = false;

        }

        private void btnCrearPV_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entProveedor pro = new entProveedor();
                pro.Nombre= txtNombrePV.Text.Trim();
                pro.RazonSocial=txtRazonPV.Text.Trim();
                pro.Telefono=txtTelefonoPV.Text.Trim();
                pro.Estado = cbxEstadoPV.Checked;            
                logProveedor.Instancia.InsertaProveedor(pro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;
            listarProveedor();
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProveedor.Rows[e.RowIndex]; //
            txtIdPV.Text = filaActual.Cells[0].Value.ToString();
            txtNombrePV.Text = filaActual.Cells[1].Value.ToString();
            txtRazonPV.Text = filaActual.Cells[2].Value.ToString();           
            txtTelefonoPV.Text = filaActual.Cells[3].Value.ToString();
            cbxEstadoPV.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void btnModificarPV_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor pro = new entProveedor();
                pro.Id=int.Parse(txtIdPV.Text.Trim());
                pro.Nombre = txtNombrePV.Text.Trim();
                pro.RazonSocial = txtRazonPV.Text.Trim();
                pro.Telefono = txtTelefonoPV.Text.Trim();
                pro.Estado = cbxEstadoPV.Checked;
                logProveedor.Instancia.EditarProveedor(pro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;
            listarProveedor();
        }

        private void btnEliminarPV_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor pro = new entProveedor();
                pro.Id = int.Parse(txtIdPV.Text.Trim());              
                cbxEstadoPV.Checked = false;
                pro.Estado = cbxEstadoPV.Checked;
                logProveedor.Instancia.EliminarProveedor(pro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;
            listarProveedor();
        }

        private void btnLeerPV_Click(object sender, EventArgs e)
        {
            
           dgvProveedor.DataSource = logProveedor.Instancia.LeerProveedor();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
