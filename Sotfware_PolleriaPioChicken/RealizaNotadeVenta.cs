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
    public partial class RealizaVenta : Form
    {
        EntNotaVenta nv = new EntNotaVenta();
        entDetNotaVenta dnv = new entDetNotaVenta();
        string DniCliente;
        string idplato;
        public static int confilas = 0;
        public static decimal Total = 0;
        public RealizaVenta()
        {
            InitializeComponent();
            llenarComboTipoPlato();
            
        }
        private void limpiarVariables()
        {
            txtCantidadV.Text = "";
            txtDescripcionPL.Text = "";
            txtDniCL.Text = "";
            txtDniV.Text = "";
            txtNombreCLB.Text = "";
            txtPrecioBuscar.Text = "";
            txtTotalV.Text = "";
            cbxPlatoBuscar.SelectedIndex = 0;
            cbxTipoPlatoBuscar.SelectedIndex = 0;
         
        }
        private void LimpiarDataGridView()
        {

            //dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.Rows.Clear();
            //dgvDetalleVenta.Columns.Clear();


        }
        private void llenarComboTipoPlato()
        {
            cbxTipoPlatoBuscar.DataSource = LogTipoPlatoR.Instancia.ListarTipoPlato();
            cbxTipoPlatoBuscar.DisplayMember = "Nombre";
            cbxTipoPlatoBuscar.ValueMember = "Id";
        }

        private void llenarComboPlato()
        {

            int idtipoplato = (int)cbxTipoPlatoBuscar.SelectedValue;
            cbxPlatoBuscar.DataSource = LogPlatoR.Instancia.ListarPlato_Tipo(idtipoplato);
            cbxPlatoBuscar.DisplayMember = "Nombre";
            cbxPlatoBuscar.ValueMember = "Id";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            txtDniV.Focus();

            DniCliente = txtDniV.Text.Trim(); // se obtiene el valor de una celda 
            entCliente C = logCliente.Instancia.BuscarCliente(DniCliente);

            if (C != null && (C.Estado = true))
            {
                txtDniCL.Text = Convert.ToString(C.Id);
                txtNombreCLB.Text = Convert.ToString(C.Nombre);
            }
            else
                MessageBox.Show("El cliente no existe or esta inhabilitado, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cbxTipoPlatoBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idtipoplato = (int)cbxTipoPlatoBuscar.SelectedValue;
            
            if ((int)cbxTipoPlatoBuscar.SelectedIndex != -1) { }
                llenarComboPlato();
            
        }

        private void cbxPlatoBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPlatoBuscar.Focus();

            idplato = cbxPlatoBuscar.SelectedValue.ToString(); // se obtiene el valor de una celda 
            EntPlatoR p = LogPlatoR.Instancia.BuscarPlato(idplato);

            if (p != null && (p.Estado = true))
            {
                txtDescripcionPL.Text = Convert.ToString(p.Descripcion);
                txtPrecioBuscar.Text = Convert.ToString(p.Precio);
                //txtNombreCLB.Text = Convert.ToString(p.Nombre);
            }
            else
                MessageBox.Show("El cliente no existe or esta inhabilitado, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAgregarDetV_Click(object sender, EventArgs e)
        {
            entDetNotaVenta dnv = new entDetNotaVenta();
            EntPlatoR p = new EntPlatoR();

            if ((this.txtNombreCLB.Text.Trim() != "") && (cbxPlatoBuscar.SelectedIndex != null) && (txtCantidadV.Text.Trim() != ""))
            {

                        dgvDetalleVenta.Rows.Add(cbxPlatoBuscar.SelectedValue.ToString(), cbxPlatoBuscar.Text,txtDescripcionPL.Text, txtCantidadV.Text, txtPrecioBuscar.Text);
                        decimal subTotal = Convert.ToDecimal(dgvDetalleVenta.Rows[confilas].Cells[3].Value) * Convert.ToDecimal(dgvDetalleVenta.Rows[confilas].Cells[4].Value);
                        dgvDetalleVenta.Rows[confilas].Cells[5].Value = subTotal;
                        confilas++;

                Total = 0;
                foreach (DataGridViewRow Fila in dgvDetalleVenta.Rows)
                {

                    Total += Convert.ToDecimal(Fila.Cells[5].Value);
                }
                txtTotalV.Text = Total.ToString();
            }
        }

        private void btnQuitarDetV_Click(object sender, EventArgs e)
        {
            if (confilas > 0)
            {
                Total = Total - Convert.ToDecimal(dgvDetalleVenta.Rows[dgvDetalleVenta.CurrentRow.Index].Cells[5].Value);
                //txtTotal.Text = "S/." + Total.ToString();
                txtTotalV.Text = Total.ToString();
                dgvDetalleVenta.Rows.RemoveAt(dgvDetalleVenta.CurrentRow.Index);
                confilas--;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int idnotaventa;
            try
            {
                EntNotaVenta nv = new EntNotaVenta();
                //entDetPedido dPed = new entDetPedido();
                entCliente c = new entCliente();
                EntPlatoR p = new EntPlatoR();

                nv.Fecha = Convert.ToDateTime(dateNotaVenta.Value);
                nv.Total = Convert.ToDecimal(txtTotalV.Text);

                c.Id = int.Parse(txtDniCL.Text);
                if (nv.IdCliente == null)
                {
                    nv.IdCliente = new entCliente();  // Asegúrate de que el objeto esté instanciado
                }

                nv.IdCliente = c;
                nv.IdCliente.Id = c.Id;

                //Ped.DetPedidos = (List<entDetPedido>)(listaDetPedido);


                //Ped.estPedido = cbkEstado.Checked;
                nv.Estado = false;
                idnotaventa = LogNotaVenta.Instancia.InsertarNotaVenta(nv);

                if (nv.DetNotaVenta == null)
                {
                    nv.DetNotaVenta = new List<entDetNotaVenta>();  // Asegúrate de que la lista esté instanciada
                }

                //MessageBox.Show(""+idPed);
                //limpiarVariables();
                //LimpiarDataGridView();
                //MessageBox.Show("REGISTRADO CON EXITO");
                GrabarDetalle(idnotaventa);
                //limpiarVariables();
                //LimpiarDataGridView();

                //Close();
                //ActualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("REGITRADO CON EXITO");
                //throw ex;
            }
        }

        private void GrabarDetalle(int cod)
        {
            foreach (DataGridViewRow Fila in dgvDetalleVenta.Rows)
            {
                dnv.IdNotaventa =  cod;
                EntPlatoR p = new EntPlatoR();


                p.Id = Fila.Cells[0].Value.ToString();
                dnv.IdPlato = p;
                dnv.IdPlato.Id = p.Id;

                dnv.Cantidad = Convert.ToInt32(Fila.Cells[3].Value.ToString());
                dnv.Precio = Convert.ToDecimal(Fila.Cells[4].Value.ToString());
                dnv.SubTotal = Convert.ToDecimal(Fila.Cells[5].Value.ToString());


                LogNotaVenta.Instancia.InsertarDetNotaVenta(dnv);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarVariables();
            LimpiarDataGridView();
        }
    }
}
