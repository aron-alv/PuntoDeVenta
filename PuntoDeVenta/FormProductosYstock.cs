using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace ABARROTES
{
    public partial class FormProductosYstock : Form
    {
        OperacionesBD Conexion = new OperacionesBD();
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
