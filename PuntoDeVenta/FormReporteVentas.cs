using System.Data;
using System;
using System.Windows.Forms;
using Operaciones;
using System.Collections.Generic;
namespace ABARROTES
{
    public partial class FormReporteVentas : Form
    {
        OperacionesBD Conexion = new OperacionesBD();
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

            if (checkBoxFechaInicio.Checked) // Asumiendo que tienes un checkbox para la fecha de inicio
            {
                fechaInicio = dateTimePickerInicio.Value;
            }

            // Verificar si se debe filtrar por fecha de fin
            if (checkBoxFechaFin.Checked) // Asumiendo que tienes un checkbox para la fecha de fin
            {
                fechaFin = dateTimePickerFin.Value;
            }

            // Obtener el ID del cliente seleccionado
            if (comboBoxClientes.SelectedValue != null)
            {
                idCliente = (int?)comboBoxClientes.SelectedValue;
            }

            // Llamar al método FiltrarVentas con las fechas y el ID del cliente
            bool resultado = Conexion.FiltrarVentas(dataGridViewVentas, fechaInicio, fechaFin, idCliente);

            // Mostrar mensaje si hubo un error
            if (!resultado)
            {
                MessageBox.Show("Error al filtrar las ventas.");
            }
        }
    }



    }

