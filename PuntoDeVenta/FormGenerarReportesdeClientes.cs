using PuntoDeVenta;
using System;
using System.Windows.Forms;

namespace ABARROTES
{
    public partial class FormGenerarReportesdeClientes : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        public FormGenerarReportesdeClientes(OperacionesBD conexion)
        {
            InitializeComponent();
            Conexion = conexion;
        }

        private void FormGenerarReportesdeClientes_Load(object sender, EventArgs e)
        {
            Conexion.ObtenerClientesEnTabla(TablaClientes);
        }
    }
}
