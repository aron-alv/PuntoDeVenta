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
    public partial class FormGenerarReportesDeProveedores : Form
    {
        OperacionesBD Conexion = new OperacionesBD();
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
