using PuntoDeVenta;
using System;
using System.Windows.Forms;

namespace ABARROTES
{
    public partial class FormGenerarReportesDeProveedores : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        public FormGenerarReportesDeProveedores(OperacionesBD conexion)
        {
            InitializeComponent();
            Conexion = conexion;
        }

        private void FormGenerarReportesDeProveedores_Load(object sender, EventArgs e)
        {
            Conexion.ObtenerProveedoresEnTabla(TablaProveedores);
        }
    }
}
