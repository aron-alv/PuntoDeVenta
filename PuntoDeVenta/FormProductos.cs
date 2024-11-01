
using PuntoDeVenta;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABARROTES
{
    public partial class FormProductos : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        public FormProductos(OperacionesBD Conexion)
        {
            InitializeComponent();
            this.Conexion = Conexion;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        { // Llenar el ComboBox nadamas con los nombres de los proveedores
            Dictionary<int, string> proveedores = Conexion.ObtenerProveedores();
            if (proveedores.Count > 0)
            {
                IDProveedor.DataSource = new BindingSource(proveedores, null);
                IDProveedor.DisplayMember = "Value";
                IDProveedor.ValueMember = "Key";
            }
            else
            {

            }

            Conexion.BuscarProductosEnTabla(TablaProductos);
        }

        private void IDProducto_Click(object sender, EventArgs e)
        {
            if (IDProducto.Text == "ID")
            {
                IDProducto.Text = "";
            }
        }

        private void IDProducto_Leave(object sender, EventArgs e)
        {
            if (IDProducto.Text == "")
            {
                IDProducto.Text = "ID";
            }
        }

        private void NombreProducto_Enter(object sender, EventArgs e)
        {
            if (NombreProducto.Text == "NOMBRE")
            {
                NombreProducto.Text = "";
            }
        }

        private void NombreProducto_Leave(object sender, EventArgs e)
        {
            if (NombreProducto.Text == "")
            {
                NombreProducto.Text = "NOMBRE";
            }
        }

        private void PrecioProducto_Enter(object sender, EventArgs e)
        {
            if (PrecioProducto.Text == "PRECIO")
            {
                PrecioProducto.Text = "";
            }

        }

        private void PrecioProducto_Leave(object sender, EventArgs e)
        {
            if (PrecioProducto.Text == "")
            {
                PrecioProducto.Text = "PRECIO";
            }
        }

        private void DescripcionProducto_Enter(object sender, EventArgs e)
        {
            if (DescripcionProducto.Text == "DESCRIPCION")
            {
                DescripcionProducto.Text = "";
            }
        }

        private void DescripcionProducto_Leave(object sender, EventArgs e)
        {
            if (DescripcionProducto.Text == "")
            {
                DescripcionProducto.Text = "DESCRIPCION";
            }
        }



        private void IDProveedor_Leave(object sender, EventArgs e)
        {
            if (IDProveedor.Text == "")
            {
                IDProveedor.Text = "ID PROVEEDOR";
            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (TablaProductos.SelectedRows.Count > 0)
            {
                if (IDProducto.Text == "ID" || NombreProducto.Text == "NOMBRE" || PrecioProducto.Text == "PRECIO" || DescripcionProducto.Text == "DESCRIPCION" || IDProveedor.Text == "ID PROVEEDOR")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                    return;
                }
                int id = Convert.ToInt32(IDProducto.Text);
                string nombre = NombreProducto.Text;
                double precio = Convert.ToDouble(PrecioProducto.Text);
                string descripcion = DescripcionProducto.Text;
                int? selectedValue = IDProveedor.SelectedValue as int?;
                if (selectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un proveedor.");
                    return;
                }
                int idProveedor = selectedValue.Value;

                try
                {
                    if (Conexion.ModificarProducto(id, nombre, precio, descripcion, idProveedor))
                    {
                        MessageBox.Show("Producto modificado correctamente");
                        Conexion.BuscarProductosEnTabla(TablaProductos);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar producto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (IDProducto.Text == "ID" || NombreProducto.Text == "NOMBRE" || PrecioProducto.Text == "PRECIO" || DescripcionProducto.Text == "DESCRIPCION" || IDProveedor.Text == "ID PROVEEDOR")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                    return;
                }
                int id = Convert.ToInt32(IDProducto.Text);
                string nombre = NombreProducto.Text;
                double precio = Convert.ToDouble(PrecioProducto.Text);
                string descripcion = DescripcionProducto.Text;
                int? selectedValue = IDProveedor.SelectedValue as int?;
                if (selectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un proveedor.");
                    return;
                }
                int idProveedor = selectedValue.Value;
                try
                {
                    if (Conexion.AgregarProducto(id, nombre, precio, descripcion, idProveedor))
                    {
                        MessageBox.Show("Producto agregado correctamente");
                        Conexion.BuscarProductosEnTabla(TablaProductos);
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar producto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void IDProveedor_Enter_1(object sender, EventArgs e)
        {
            if (IDProveedor.Text == "PROVEEDOR")
            {
                IDProveedor.Text = "";
            }


        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (TablaProductos.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(TablaProductos.SelectedRows[0].Cells[0].Value);
                    if (Conexion.EliminarProducto(id))
                    {
                        MessageBox.Show("Producto eliminado correctamente");
                        Conexion.BuscarProductosEnTabla(TablaProductos);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar producto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar");
            }
        }

        private void TablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TablaProductos.SelectedRows.Count > 0)
            {
                IDProducto.ReadOnly = true;
                IDProducto.Text = TablaProductos.SelectedRows[0].Cells[0].Value.ToString();
                NombreProducto.Text = TablaProductos.SelectedRows[0].Cells[1].Value.ToString();
                PrecioProducto.Text = TablaProductos.SelectedRows[0].Cells[2].Value.ToString();
                DescripcionProducto.Text = TablaProductos.SelectedRows[0].Cells[3].Value.ToString();
                IDProveedor.Text = TablaProductos.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
        public void LimpiarCampos()
        {
            IDProducto.ReadOnly = false;
            IDProducto.Text = "ID";
            NombreProducto.Text = "NOMBRE";
            PrecioProducto.Text = "PRECIO";
            DescripcionProducto.Text = "DESCRIPCION";
            IDProveedor.Text = "ID PROVEEDOR";

        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscarProducto.Text.Trim();

            Conexion.BuscarProducto(busqueda, TablaProductos);
        }

        private void txtBuscarProducto_Enter(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text == "BUSCAR")
            {
                txtBuscarProducto.Text = "";
            }
        }

        private void txtBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text == "")
            {
                txtBuscarProducto.Text = "BUSCAR";
                Conexion.BuscarProductosEnTabla(TablaProductos);
            }
        }

        private void FormProductos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            TablaProductos.ClearSelection();
        }





        private void FormProductos_Enter(object sender, EventArgs e)
        {

        }


    }
}
