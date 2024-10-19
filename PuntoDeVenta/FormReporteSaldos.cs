using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Operaciones;


namespace ABARROTES
{
    public partial class FormReporteSaldos : Form
    {
        OperacionesBD Conexion = new OperacionesBD();
  
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
