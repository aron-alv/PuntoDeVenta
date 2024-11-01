using PuntoDeVenta;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace ABARROTES
{
    public partial class FormReporteVentas : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        public FormReporteVentas(OperacionesBD conexion)
        {
            InitializeComponent();
            Conexion = conexion;
        }

        private void CargarClientes()
        {
            // función ObtenerClientes para obtener el diccionario de clientes
            Dictionary<int, string> clientes = Conexion.ObtenerClientes();


            if (clientes.Count > 0)
            {
                // Asignamos el diccionario como fuente de datos del ComboBox
                comboBoxClientes.DataSource = new BindingSource(clientes, null);
                comboBoxClientes.DisplayMember = "Value"; // Mostrar los nombres 
                comboBoxClientes.ValueMember = "Key"; //  ID del cliente 
            }
            else
            {
                MessageBox.Show("No se encontraron clientes.");
            }
        }


        private void FormReporteVentas_Load(object sender, System.EventArgs e)
        {
            CargarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime? fechaInicio = null;
            DateTime? fechaFin = null;
            int? idCliente = null;

            if (checkBoxFechaInicio.Checked)
            {
                fechaInicio = dateTimePickerInicio.Value;
            }


            if (checkBoxFechaFin.Checked)
            {
                fechaFin = dateTimePickerFin.Value;
            }


            if (comboBoxClientes.SelectedValue != null)
            {
                idCliente = (int?)comboBoxClientes.SelectedValue;
            }


            bool resultado = Conexion.FiltrarVentas(dataGridViewVentas, fechaInicio, fechaFin, idCliente);


            if (!resultado)
            {
                MessageBox.Show("Error al filtrar las ventas.");
            }
        }
    }



}

