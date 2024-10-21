using PuntoDeVenta;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace ABARROTES
{
    public partial class FormReporteSaldos : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();

        public FormReporteSaldos(OperacionesBD conexion)
        {
            InitializeComponent();
            Conexion = conexion;
        }

        private void FormReporteSaldos_Load(object sender, EventArgs e)
        {
            Conexion.BuscarSaldosEnTabla(tablaSaldos);

        }

     

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
