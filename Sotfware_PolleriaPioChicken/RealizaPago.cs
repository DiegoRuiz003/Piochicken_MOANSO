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
    public partial class RealizaPago : Form
    {
        int idnotaventa;
        public RealizaPago()
        {
            InitializeComponent();
            llenarMetodoPago();

        }
        private void limpiarVariables()
        {
            txtBuscarNotaVenta.Text = "";
            txtDniNota.Text = "";
            txtEstadoNota.Text = "";
            txtNombreNota.Text = "";
            txtTotalNota.Text = "";
            checkPago.Checked = false;
        }
        private void LimpiarDataGridView()
        {
            
            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.Rows.Clear();      
            dgvDetalleVenta.Columns.Clear();   

            
        }
        private void llenarMetodoPago()
        {
            cbxMetodoPago.DataSource=LogMetodoPago.Instancia.ListarMetodoPago();
            cbxMetodoPago.DisplayMember = "MetodoPago";
            cbxMetodoPago.ValueMember = "Id";
        }

        private void btnBuscarNotaVenta_Click(object sender, EventArgs e)
        {
            txtBuscarNotaVenta.Focus();
            entCliente cliente = new entCliente();

            idnotaventa = Convert.ToInt32(txtBuscarNotaVenta.Text); // se obtiene el valor de una celda 
            EntNotaVenta nv = logPago.Instancia.BuscarNotaVenta(idnotaventa);

            
                txtNombreNota.Text = Convert.ToString(cliente.Nombre);
                txtDniNota.Text = Convert.ToString(cliente.Dni);
                txtTotalNota.Text = Convert.ToString(nv.Total);
                txtEstadoNota.Text = Convert.ToString(nv.Estado);

            dgvDetalleVenta.DataSource = logPago.Instancia.ListarDetNotaVenta(idnotaventa);

            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entPago pl = new entPago();
                pl.IdMetodoPago = Convert.ToInt32(cbxMetodoPago.SelectedValue);
                pl.IdNotaVenta = Convert.ToInt32(txtBuscarNotaVenta.Text);
                pl.Fecha = Convert.ToDateTime(datePago.Text);
                pl.Total = Convert.ToDecimal(txtTotalNota.Text);
                pl.Estado = checkPago.Checked;
                logPago.Instancia.InsertarPago(pl);
                MessageBox.Show("PAGO CON EXITO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
            LimpiarDataGridView();
        }

       
    }
}
