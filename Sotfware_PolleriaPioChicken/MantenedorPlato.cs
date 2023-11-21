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
    public partial class MantenedorPlato : Form
    {
        private bool esAgregar = false;

        private List<EntInsumo> insumosEscogidos = new List<EntInsumo>();
        private List<string> insumosRetirados = new List<string>();

        public MantenedorPlato()
        {
            InitializeComponent();
            ListarTipoPlato();
            ListarInsumo();
            ListarPlato();
            gbDatos.Enabled = false;
        }

        public void ListarTipoPlato()
        {
            cbbTipoPlato.DataSource = LogPlato.Instancia.ListarTipoPlato();
        }

        public void ListarInsumo()
        {
            cbbInsumo.DataSource = LogPlato.Instancia.ListarInsumo();
        }

        public void ListarPlato()
        {
            dgvPlato.DataSource = LogPlato.Instancia.ListarPlato();
        }

        public void ListarInsumoPlato(string idPlato)
        {
            dgvPlato.DataSource = LogPlato.Instancia.ListarInsumoPlato(idPlato);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
            esAgregar = true;
        }

        private void LimpiarVariables()
        {
            txtId.Text = "";
            txtNombre.Text = " ";
            cbbTipoPlato.SelectedIndex = -1;
            cbbInsumo.SelectedIndex = -1;
            nudPrecio.Value = 0;
            cbEstado.Checked = false;
            dgvInsumoPlato.DataSource = null;
            insumosEscogidos.Clear();
            insumosRetirados.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntPlato plato = new EntPlato();
                plato.id = txtId.Text;
                plato.nombre = txtNombre.Text;
                plato.idTipoPlato = cbbTipoPlato.SelectedItem.ToString();
                plato.precio = Convert.ToInt16(nudPrecio.Value);
                plato.estado = cbEstado.Checked;

                foreach (DataGridViewRow r in dgvInsumoPlato.Rows)
                {
                    EntInsumoPlato insumoPlato = new EntInsumoPlato();
                    insumoPlato.idInsumo = r.Cells[0].Value.ToString();
                    insumoPlato.idPlato = plato.id;
                    insumoPlato.estado = true;

                    plato.insumosPlato.Add(insumoPlato);
                }

                LogPlato.Instancia.InsertarPlato(plato);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            LimpiarVariables();
            gbDatos.Enabled = false;
            ListarPlato();

            esAgregar = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntPlato plato = new EntPlato();
                plato.id = txtId.Text;
                plato.nombre = txtNombre.Text;
                plato.idTipoPlato = cbbTipoPlato.SelectedItem.ToString();
                plato.precio = Convert.ToInt16(nudPrecio.Value);
                plato.estado = cbEstado.Checked;

                foreach (DataGridViewRow r in dgvInsumoPlato.Rows)
                {
                    EntInsumoPlato insumoPlato = new EntInsumoPlato();
                    insumoPlato.idInsumo = r.Cells[0].Value.ToString();
                    insumoPlato.idPlato = plato.id;
                    insumoPlato.estado = true;

                    plato.insumosPlato.Add(insumoPlato);
                }
                plato.insumosPlatoRetirados = insumosRetirados;


                LogPlato.Instancia.EditarPlato(plato);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatos.Enabled = false;
            ListarPlato();
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
            esAgregar = false;
        }

        private void dgvPlato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (esAgregar) return;

            int rowIndexPlato = e.RowIndex;
            DataGridViewRow filaActual = dgvPlato.Rows[e.RowIndex];
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            cbbTipoPlato.Text = filaActual.Cells[2].Value.ToString();
            nudPrecio.Value = Convert.ToInt16(filaActual.Cells[3].Value);
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);

            insumosEscogidos.Clear();
            insumosRetirados.Clear();

            dgvInsumoPlato.DataSource = LogPlato.Instancia.ListarInsumoPlato(txtId.Text);


            insumosEscogidos = (List<EntInsumo>)dgvInsumoPlato.DataSource;

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntPlato Plato = new EntPlato();
                Plato.id = txtId.Text;
                Plato.insumosPlato = (List<EntInsumoPlato>)dgvInsumoPlato.DataSource;
                LogPlato.Instancia.DeshabilitarPlato(Plato);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatos.Enabled = false;
            ListarPlato();

            esAgregar = false;

        }

        public EntInsumo ListarInsumoEscogido(string idInsumo)
        {
            return LogPlato.Instancia.ListarInsumoEscogido(idInsumo);
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvInsumoPlato.Rows)
            {
                if (r.Cells[0].Value.ToString().Equals(cbbInsumo.Text))
                {
                    MessageBox.Show("Insumo ya escogido.");
                    return;
                }
            }

            insumosEscogidos.Add(ListarInsumoEscogido(cbbInsumo.Text));

            dgvInsumoPlato.DataSource = null;
            dgvInsumoPlato.DataSource = insumosEscogidos;
        }

        int rowIndexInsumoPlato;
        private void dgvInsumoPlato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndexInsumoPlato = e.RowIndex;
        }

        private void btnQuitarInsumo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < insumosEscogidos.Count; i++)
            {
                if (insumosEscogidos[i].id.Equals(dgvInsumoPlato.Rows[rowIndexInsumoPlato].Cells[0].Value.ToString()))
                {
                    insumosRetirados.Add(insumosEscogidos[i].id);

                    insumosEscogidos.RemoveAt(i);
                    break;
                }
            }

            dgvInsumoPlato.DataSource = null;
            dgvInsumoPlato.DataSource = insumosEscogidos;
        }

    }
}
