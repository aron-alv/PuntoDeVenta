
using PuntoDeVenta;
using System.Windows.Forms;
namespace ABARROTES
{
    public partial class FormProveedores : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        public FormProveedores(OperacionesBD conexion)
        {
            InitializeComponent();
            Conexion = conexion;
        }

        private void IDProveedor_Enter(object sender, System.EventArgs e)
        {
            if (IDProveedor.Text == "ID")
            {
                IDProveedor.Text = "";
            }
        }

        private void IDProveedor_Leave(object sender, System.EventArgs e)
        {
            if (IDProveedor.Text == "")
            {
                IDProveedor.Text = "ID";
            }
        }

        private void NombreProducto_Enter(object sender, System.EventArgs e)
        {
            if (NombreProveedor.Text == "NOMBRE")
            {
                NombreProveedor.Text = "";
            }
        }

        private void NombreProducto_Leave(object sender, System.EventArgs e)
        {
            if (NombreProveedor.Text == "")
            {
                NombreProveedor.Text = "NOMBRE";
            }
        }

        private void NumTelefono_Enter(object sender, System.EventArgs e)
        {
            if (NumTelefono.Text == "TELEFONO")
            {
                NumTelefono.Text = "";
            }
        }

        private void NumTelefono_Leave(object sender, System.EventArgs e)
        {
            if (NumTelefono.Text == "")
            {
                NumTelefono.Text = "TELEFONO";
            }
        }

        private void DireccionProveedor_Enter(object sender, System.EventArgs e)
        {
            if (DireccionProveedor.Text == "DIRECCION")
            {
                DireccionProveedor.Text = "";
            }
        }

        private void DireccionProveedor_Leave(object sender, System.EventArgs e)
        {
            if (DireccionProveedor.Text == "")
            {
                DireccionProveedor.Text = "DIRECCION";
            }
        }

        private void BtnAgregarProducto_Click(object sender, System.EventArgs e)
        {
            if (TablaProveedores.SelectedRows.Count > 0)
            {
                //hacer la modificacion del cliente
                if (IDProveedor.Text == "ID" || NombreProveedor.Text == "NOMBRE" || NumTelefono.Text == "TELEFONO" || DireccionProveedor.Text == "DIRECCION")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                    return;
                }
                int id = int.Parse(IDProveedor.Text);
                string nombre = NombreProveedor.Text;
                string telefono = NumTelefono.Text;
                string direccion = DireccionProveedor.Text;
                if (Conexion.ModificarProveedor(id, nombre, telefono, direccion))
                {
                    MessageBox.Show("Proveedor modificado correctamente");
                    Conexion.ObtenerProveedoresEnTabla(TablaProveedores);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificar proveedor");
                }
            }
            else
            {
                if (IDProveedor.Text == "ID" || NombreProveedor.Text == "NOMBRE" || NumTelefono.Text == "TELEFONO" || DireccionProveedor.Text == "DIRECCION")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                    return;
                }
                int id = int.Parse(IDProveedor.Text);
                string nombre = NombreProveedor.Text;
                string telefono = NumTelefono.Text;
                string direccion = DireccionProveedor.Text;
                if (Conexion.AgregarProveedor(id, nombre, telefono, direccion))
                {
                    MessageBox.Show("Proveedor agregado correctamente");
                    Conexion.ObtenerProveedoresEnTabla(TablaProveedores);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar proveedor");
                }
            }




        }

        private void FormProveedores_Load(object sender, System.EventArgs e)
        {
            Conexion.ObtenerProveedoresEnTabla(TablaProveedores);
            TablaProveedores.ClearSelection();
        }

        private void BtnEliminarProveedores_Click(object sender, System.EventArgs e)
        {

            if (TablaProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Favor de seleccionar un proveedor");
                return;
            }
            int id = int.Parse(TablaProveedores.SelectedRows[0].Cells[0].Value.ToString());
            if (Conexion.EliminarProveedor(id))
            {
                MessageBox.Show("Proveedor eliminado correctamente");
                Conexion.ObtenerProveedoresEnTabla(TablaProveedores);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al eliminar proveedor");
            }
        }

        private void TablaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TablaProveedores.SelectedRows.Count > 0)
            {
                IDProveedor.ReadOnly = true;
                IDProveedor.Text = TablaProveedores.SelectedRows[0].Cells[0].Value.ToString();
                NombreProveedor.Text = TablaProveedores.SelectedRows[0].Cells[1].Value.ToString();
                NumTelefono.Text = TablaProveedores.SelectedRows[0].Cells[2].Value.ToString();
                DireccionProveedor.Text = TablaProveedores.SelectedRows[0].Cells[3].Value.ToString();


            }
        }
        public void LimpiarCampos()
        {
            IDProveedor.ReadOnly = false;
            IDProveedor.Text = "ID";
            NombreProveedor.Text = "NOMBRE";
            NumTelefono.Text = "TELEFONO";
            DireccionProveedor.Text = "DIRECCION";
        }

        private void FormProveedores_Click(object sender, System.EventArgs e)
        {
            LimpiarCampos();
            Conexion.ObtenerProveedoresEnTabla(TablaProveedores);
            TablaProveedores.ClearSelection();

        }

        private void txtBuscarProveedores_TextChanged(object sender, System.EventArgs e)
        {
            string busqueda = txtBuscarProveedores.Text;
            Conexion.BuscarProveedor(busqueda, TablaProveedores);

        }

        private void txtBuscarProveedores_Enter(object sender, System.EventArgs e)
        {
            if (txtBuscarProveedores.Text == "BUSCAR PROVEEDORES")
            {
                txtBuscarProveedores.Text = "";
            }
        }

        private void txtBuscarProveedores_Leave(object sender, System.EventArgs e)
        {
            if (txtBuscarProveedores.Text == "")
            {
                txtBuscarProveedores.Text = "BUSCAR PROVEEDORES";
                Conexion.ObtenerProveedoresEnTabla(TablaProveedores);
            }
        }
    }
}
