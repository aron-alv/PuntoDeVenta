using PuntoDeVenta;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ABARROTES
{
    public partial class FormReporteInventario : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        public FormReporteInventario(OperacionesBD conexion)
        {
            InitializeComponent();
            Conexion = conexion;
        }

        private void FormReporteInventario_Load(object sender, System.EventArgs e)
        {
            // Llenar el ComboBox nadamas con los nombres de los proveedores
            Dictionary<int, string> proveedores = Conexion.ObtenerProveedores();
            if (proveedores.Count > 0)
            {
                IDProveedor.DataSource = new BindingSource(proveedores, null);
                IDProveedor.DisplayMember = "Value";
                IDProveedor.ValueMember = "Key";
            }
            else
            {
                MessageBox.Show("No se encontraron proveedores.");
            }
        }

        private void BtnFiltrar_Click(object sender, System.EventArgs e)
        {
            DateTime? fechaInicio = null;
            DateTime? fechaFin = null;
            int? idProveedor = null;

            if (checkBoxFechaInicio.Checked)
            {
                fechaInicio = dateTimePickerInicio.Value;
            }

            if (checkBoxFechaFin.Checked)
            {
                fechaFin = dateTimePickerFin.Value;
            }

            if (IDProveedor.SelectedValue != null)
            {
                idProveedor = (int?)IDProveedor.SelectedValue;
            }

            bool resultado = Conexion.FiltrarInventario(dataGridViewInventario, fechaInicio, fechaFin, idProveedor);

            if (!resultado)
            {
                MessageBox.Show("Error al filtrar inventario.");
            }
        }
    }
}
