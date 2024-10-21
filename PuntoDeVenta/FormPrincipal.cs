
using PuntoDeVenta;
using System;
using System.Windows.Forms;
namespace ABARROTES
{
    public partial class FormPrincipal : Form
    {

        private OperacionesBD Conexion = new OperacionesBD();
        public FormPrincipal(OperacionesBD conexion)
        {
            InitializeComponent();
            PanelMostrarReportes.Visible = false;
            Conexion = conexion;
        }

       
        private void BtnReportes_Click(object sender, EventArgs e)
        {
            if (PanelMostrarReportes.Visible == true)
            {
                PanelMostrarReportes.Visible = false;
            }
            else
            {
                PanelMostrarReportes.Visible = true;
            }

        }
        private void BtnReportesVentas_Click(object sender, EventArgs e)
        {

            PanelMostrarReportes.Visible = false;
            AbrirFormHija(new FormReporteVentas(Conexion));
        }
        private void BtnReportesInventario_Click(object sender, EventArgs e)
        {
            PanelMostrarReportes.Visible = false;
            AbrirFormHija(new FormReporteInventario(Conexion));
        }

        private void BtnReportesSaldos_Click(object sender, EventArgs e)
        {
            PanelMostrarReportes.Visible = false;
            AbrirFormHija(new FormReporteSaldos(Conexion));
        }

        //Metodo para abrir formularios dentro del panel
        private void AbrirFormHija(object formHija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                var control = this.PanelContenedor.Controls[0];
                this.PanelContenedor.Controls.RemoveAt(0);
                control.Dispose();
            }
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            PanelMostrarReportes.Visible = false;
            AbrirFormHija(new FormProductos(Conexion));
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            PanelMostrarReportes.Visible = false;
            AbrirFormHija(new FormVentas(Conexion));
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            PanelMostrarReportes.Visible = false;
            AbrirFormHija(new FormInventario(Conexion));
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            PanelMostrarReportes.Visible = false;
            AbrirFormHija(new FormProveedores(Conexion));
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            PanelMostrarReportes.Visible = false;
            AbrirFormHija(new FormClientes(Conexion));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormGenerarReportesDeProveedores(Conexion));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormGenerarReportesdeClientes(Conexion));
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormProductosYstock(Conexion));
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
