using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//AGREGAR

namespace Sotfware_PolleriaPioChicken
{
    public partial class PolleriaPioChicken : Form
    {
        public PolleriaPioChicken()
        {
            InitializeComponent();
            panelAL.Visible = false;
            panelPD.Visible = false;
            panelVT.Visible = false;
            PanelesSubMenu();
        }
        //PANEL CONTENEDOR
        private Form activeform = null;
        private void AbrirForm(Form forms)
        {
            if (activeform != null)
                activeform.Close();
            activeform = forms;
            forms.TopLevel = false;
            forms.FormBorderStyle = FormBorderStyle.None;
            forms.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(forms);
            panelContenedor.Tag = forms;
            forms.BringToFront();
            forms.Show();
        }
        //PANELES
        private void PanelesSubMenu()
        {
            panelAlmacen.Visible = false;
            panelProduccion.Visible = false;
            panelVenta.Visible = false;
        }
        private void OcultarSubMenu()
        {
            if (panelAlmacen.Visible == true) panelAlmacen.Visible = false;
            if (panelProduccion.Visible == true) panelProduccion.Visible = false;
            if (panelVenta.Visible == true) panelVenta.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        //AGRGAR LIBRERIA
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconrestaura_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaura.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaura.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            panelAL.Visible = true;
            panelPD.Visible = false;
            panelVT.Visible = false;
            showSubMenu(panelAlmacen);
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            panelAL.Visible = false;
            panelPD.Visible = true;
            panelVT.Visible = false;
            showSubMenu(panelProduccion);
            panelPD.Location = new Point(0, 179);
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            panelAL.Visible = false;
            panelPD.Visible = false;
            panelVT.Visible = true;
            showSubMenu(panelVenta);
            panelVT.Location = new Point(0, 229);
        }

        private void btnNotaIngreso_Click(object sender, EventArgs e)
        {
            AbrirForm(new RealizaNotadeIngreso());
        }

        private void btnNotaSalida_Click(object sender, EventArgs e)
        {
            AbrirForm(new RealizaNotadeSalida());
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirForm(new MantenedorProveedor());
        }

        private void btnInsumo_Click(object sender, EventArgs e)
        {
            AbrirForm(new MantenedorInsumo());
        }

        private void btnTipoInsumo_Click(object sender, EventArgs e)
        {
            AbrirForm(new MantenedorTipodeInsumoR());
        }

        private void btnPlanProduccion_Click(object sender, EventArgs e)
        {
            AbrirForm(new RealizaPlandeProduccion());
        }

        private void btnOrdenProduccion_Click(object sender, EventArgs e)
        {
            AbrirForm(new RealizaOrdendeProduccion());
        }

        private void btnPedidoInsumo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPlato_Click(object sender, EventArgs e)
        {
            AbrirForm(new MantenedorPlatoR());
        }

        private void btnTipoPlato_Click(object sender, EventArgs e)
        {
            AbrirForm(new MantenedorTipoPlato());
        }

        private void btnNotaVenta_Click(object sender, EventArgs e)
        {
            AbrirForm(new RealizaVenta());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirForm(new MantenedorCliente());
        }

        private void btnMetodoPago_Click(object sender, EventArgs e)
        {
            AbrirForm(new MantenedorMetododePago());
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            AbrirForm(new RealizaPago());
        }
    }
}
