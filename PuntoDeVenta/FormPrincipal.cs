﻿
using PuntoDeVenta;
using System;
using System.Drawing;
using System.Windows.Forms;
using static ABARROTES.Form1;
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
            labelUsuario.Text = UsuarioActual.Usuario;
            this.MinimumSize = new Size(this.Width, 745);
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


        private void AbrirFormHija(object formHija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                var control = this.PanelContenedor.Controls[0];
                this.PanelContenedor.Controls.RemoveAt(0);
                control.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();

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
            // Busca si ya hay una instancia de Form2 abierta
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormPrincipal && form != this)
                {
                    form.Close();
                    break;
                }
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
           

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                BtnCerrarSesion_Click(this, new EventArgs());

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           AbrirFormHija(new ReportesVistas(Conexion));
        }
    }
}
