using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
 
    public partial class ReportesVistas : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        public ReportesVistas(OperacionesBD conexion)
        {
            InitializeComponent();
            Conexion = conexion;
          
        }

        private void BtnTotalProductoVendido_Click(object sender, EventArgs e)
        {
            bool resultado = Conexion.TotalDeProductosVendidos(chartTotalProductoVendido, lblProductosVendidosenTotal);
            chartTotalProductoVendido.Visible = true;
          
            chartVentasTotalPorCliente.Visible = false;
            panelVentasPorDia.Visible = false;
            panelVentasPorMes.Visible = false;
            charIngresoGeneradoAlDia.Visible = false;
            chartVentasMensuales.Visible = false;
            
        }

        private void chartTotalProductoVendido_Click(object sender, EventArgs e)
        {

        }

        private void BtnVentasTotalesPorCliente_Click(object sender, EventArgs e)
        {
            bool resultado = Conexion.VentasTotalPorCliente(chartVentasTotalPorCliente, lblProductosVendidosenTotal);
            chartVentasTotalPorCliente.Visible = true;
       
            chartTotalProductoVendido.Visible = false;
            charIngresoGeneradoAlDia.Visible = false;
            chartVentasMensuales.Visible = false;
            panelVentasPorDia.Visible = false;
            panelVentasPorMes.Visible = false;
          
        }

       

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DateTime FechaIncio = DtpInicio.Value;
            DateTime FechaFin = DtpFin.Value;
            bool resultado = Conexion.VentasMensualesPorFecha(chartVentasMensuales, FechaIncio, FechaFin, lblProductosVendidosenTotal);
            lblProductosVendidosenTotal.Visible = true;
        }

        private void DtpInicio_ValueChanged(object sender, EventArgs e)
        {
            DtpInicio.Value= new DateTime(DtpInicio.Value.Year, DtpInicio.Value.Month, 1);
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            DtpFin.Value = new DateTime(DtpFin.Value.Year, DtpFin.Value.Month, DateTime.DaysInMonth(DtpFin.Value.Year, DtpFin.Value.Month));
        }

        private void BtnIngresoGeneradoAlDia_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DtpDiaInicio.Value.Date; 
            DateTime fechaFin = DtpDiaFin.Value.Date;
            bool resultado = Conexion.IngresoGeneradoAlDia(charIngresoGeneradoAlDia, fechaInicio, fechaFin, lblProductosVendidosenTotal);
            lblProductosVendidosenTotal.Visible = true;
        }

     

        private void BtnVentasAlMes_Click(object sender, EventArgs e)
        {
            panelVentasPorMes.Visible = true;
            chartVentasMensuales.Visible = true;
            panelVentasPorDia.Visible = false;          
            chartVentasTotalPorCliente.Visible = false;
            chartTotalProductoVendido.Visible = false;
            charIngresoGeneradoAlDia.Visible = false;
            lblProductosVendidosenTotal.Visible = false;
        }

        private void BtnIngresoDiario_Click(object sender, EventArgs e)
        {
            charIngresoGeneradoAlDia.Visible = true;
            panelVentasPorDia.Visible = true;
            panelVentasPorMes.Visible = false;
            chartVentasMensuales.Visible = false;
            chartVentasTotalPorCliente.Visible = false;
            chartTotalProductoVendido.Visible = false;
            lblProductosVendidosenTotal.Visible = false;

        }

        private void ReportesVistas_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
