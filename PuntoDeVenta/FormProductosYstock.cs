using PuntoDeVenta;
using System;
using System.Windows.Forms;

namespace ABARROTES
{
    public partial class FormProductosYstock : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        public FormProductosYstock(OperacionesBD conexion)
        {
            InitializeComponent();
            Conexion = conexion;
        }

        private void FormProductosYstock_Load(object sender, EventArgs e)
        {
            Conexion.BuscarProductoporNombreYCantidad(tablaProductos);
        }
    }
}
