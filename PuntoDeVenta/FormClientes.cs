
using PuntoDeVenta;
using System;
using System.Data.SqlTypes;
using System.Windows.Forms;
namespace ABARROTES
{
    public partial class FormClientes : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        public FormClientes(OperacionesBD conexion)
        {
            InitializeComponent();
            Conexion = conexion;
        }






        private void txtBuscarCliebte_Leave(object sender, System.EventArgs e)
        {

            if (txtBuscarCliebte.Text == "")
            {
                TablaClientes.ClearSelection();
                txtBuscarCliebte.Text = "BUSCAR CLIENTE";
                // Actualizar la tabla
                Conexion.ObtenerClientesEnTabla(TablaClientes);

            }
        }

        private void FormClientes_Load(object sender, System.EventArgs e)
        {
            Conexion.ObtenerClientesEnTabla(TablaClientes);
            TablaClientes.ClearSelection();
            int siguienteID = Conexion.ObtenerSiguienteIDCliente();
            if (siguienteID != -1)
            {
                IDCliente.Text = siguienteID.ToString();
            }
        }

        private void BtnEliminar_Click(object sender, System.EventArgs e)
        {

            if (TablaClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un cliente");
                return;
            }


            if (!int.TryParse(TablaClientes.SelectedRows[0].Cells[0].Value.ToString(), out int id))
            {
                MessageBox.Show("Error al obtener el ID del cliente.");
                return;
            }


            try
            {
                if (Conexion.EliminarCliente(id))
                {
                    MessageBox.Show("Cliente eliminado correctamente");


                    Conexion.ObtenerClientesEnTabla(TablaClientes);
                    IDCliente.ReadOnly = false;
                    LimpiarTextbox();
                }
                else
                {
                    MessageBox.Show("Error al eliminar cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TablaClientes.ClearSelection();
        }

        private void txtBuscarCliebte_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscarCliebte.Text.Trim();


            Conexion.BuscarCliente(busqueda, TablaClientes);

        }

        private void TablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TablaClientes.SelectedRows.Count > 0)
            {
                IDCliente.ReadOnly = true;
                IDCliente.Text = TablaClientes.SelectedRows[0].Cells[0].Value.ToString();
                NombreCliente.Text = TablaClientes.SelectedRows[0].Cells[1].Value.ToString();
                NumTelefono.Text = TablaClientes.SelectedRows[0].Cells[2].Value.ToString();
                DireccionCliente.Text = TablaClientes.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        public void LimpiarTextbox()
        {
            int SiguienteID = Conexion.ObtenerSiguienteIDCliente();
            IDCliente.Text = $"{SiguienteID}";
            NombreCliente.Text = "";
            NumTelefono.Text = "";
            DireccionCliente.Text = "";


        }
        private void FormClientes_Click(object sender, EventArgs e)
        {
            if (TablaClientes.SelectedRows.Count > 0)
            {
                LimpiarTextbox();

            }
            TablaClientes.ClearSelection();
           
        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (TablaClientes.SelectedRows.Count > 0)
            {
                //hacer la modificacion del cliente
                if (IDCliente.Text == "ID" || NombreCliente.Text == "NOMBRE" || NumTelefono.Text == "TELEFONO" || DireccionCliente.Text == "DIRECCION")
                {
                    MessageBox.Show("Llena todos los campos");
                    return;
                }
                int id = int.Parse(IDCliente.Text);
                string nombre = NombreCliente.Text;
                string telefono = NumTelefono.Text;
                string direccion = DireccionCliente.Text;
                if (Conexion.ModificarCliente(id, nombre, telefono, direccion))
                {
                    MessageBox.Show("Cliente modificado correctamente");
                    Conexion.ObtenerClientesEnTabla(TablaClientes);
                    LimpiarTextbox();
                    TablaClientes.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Error al modificar cliente");
                }
            }
            else
            {
                if (NombreCliente.Text == "NOMBRE" || NumTelefono.Text == "TELEFONO" || DireccionCliente.Text == "DIRECCION")
                {
                    MessageBox.Show("Llena todos los campos");
                    return;
                }

                string nombre = NombreCliente.Text;
                string telefono = NumTelefono.Text;
                string direccion = DireccionCliente.Text;
                if (Conexion.AgregarCliente(nombre, telefono, direccion, out int nuevoID))
                {
                    MessageBox.Show("Cliente agregado correctamente");
                    Conexion.ObtenerClientesEnTabla(TablaClientes);
                    LimpiarTextbox();
                    TablaClientes.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Error al agregar cliente");
                }
            }
        }


        private void TablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NombreCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
