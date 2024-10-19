using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Operaciones;


namespace ABARROTES
{
    public partial class FormInventario : Form
    {
        OperacionesBD Conexion = new OperacionesBD();
        private List<Tuple<int, string, decimal>> productos;

        public FormInventario(OperacionesBD Conexion)
        {
            InitializeComponent();
            this.Conexion = Conexion;
            txtCantidadEntrante.TextChanged += new EventHandler(CalculateTotals);
            textBoxPrecio.TextChanged += new EventHandler(CalculateTotals);
        }

        private void FormInventario_Load(object sender, System.EventArgs e)
        {
            // Cargar proveedores en el ComboBox de Proveedores
            Dictionary<int, string> proveedores = Conexion.ObtenerProveedores();
            if (proveedores.Count > 0)
            {
                comboBoxProveedores.DataSource = new BindingSource(proveedores, null);
                comboBoxProveedores.DisplayMember = "Value"; 
                comboBoxProveedores.ValueMember = "Key";    
            }
            else
            {
                MessageBox.Show("No se encontraron proveedores.");
            }

            // Cargar productos en el ComboBox de Productos
            var productosIds = Conexion.ObtenerProductos().Keys.ToList(); // Obtener solo los IDs de productos
            productos = new List<Tuple<int, string, decimal>>(); // Lista de tuplas para almacenar los productos

           
            foreach (var id in productosIds)
            {
               
                if (Conexion.ObtenerProductoDetalle(id, out string nombre, out double precio))
                {
                    productos.Add(new Tuple<int, string, decimal>(id, nombre, (decimal)precio));
                }
            }

           
            Dictionary<int, string> productosDiccionario = productos.ToDictionary(p => p.Item1, p => p.Item2);

            if (productosDiccionario.Count > 0)
            {
                comboBoxProductos.DataSource = new BindingSource(productosDiccionario, null);
                comboBoxProductos.DisplayMember = "Value"; 
                comboBoxProductos.ValueMember = "Key";   
            }
            else
            {
                MessageBox.Show("No se encontraron productos.");
            }

            // Cargar el inventario en la tabla
            Conexion.BuscarInventarioEnTabla(tablaInventario);
            comboBoxProveedores.SelectedIndex = -1;
        }

        private void CalculateTotals(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidadEntrante.Text, out int cantidadEntrante) && decimal.TryParse(textBoxPrecio.Text, out decimal costoUnitario))
            {
                decimal importe = cantidadEntrante * costoUnitario; // Calcular Importe
                decimal iva = importe * 0.16m; // Calcular IVA
                decimal total = importe + iva; // Calcular Total

                // Actualizar los valores calculados en los TextBoxes
                txtIVA.Text = iva.ToString("F2");
                txtTotal.Text = total.ToString("F2");
                txtImporte.Text = importe.ToString("F2");
            }
        }

        private void btnRegistrarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaRegistro = dtpFechaRegistro.Value;
                string observaciones = txtObservaciones.Text;

                int cantidadEntrante = int.Parse(txtCantidadEntrante.Text);
                decimal costoUnitario = decimal.Parse(textBoxPrecio.Text);

                decimal importe = cantidadEntrante * costoUnitario;
                decimal iva = importe * 0.16m;
                decimal total = importe + iva;

              
                txtIVA.Text = iva.ToString("F2"); 
                txtTotal.Text = total.ToString("F2"); 

                int? selectedValue = comboBoxProveedores.SelectedValue as int?;
                if (selectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un proveedor.");
                    return;
                }
                int idProveedor = selectedValue.Value;

                int idInventario = Conexion.AgregarInventario(fechaRegistro, observaciones, importe, iva, total, idProveedor);

                if (idInventario > 0)
                {
                    MessageBox.Show("Inventario registrado con éxito.");
                    Conexion.BuscarInventarioEnTabla(tablaInventario);

                    var selectedProduct = comboBoxProductos.SelectedItem as KeyValuePair<int, string>?;
                    if (selectedProduct == null)
                    {
                        MessageBox.Show("Por favor, seleccione un producto.");
                        return;
                    }

                    int idProducto = selectedProduct.Value.Key; 

                    decimal subtotal = cantidadEntrante * costoUnitario; 

                    bool resultadoDetalle = Conexion.AgregarDetalleInventario(idInventario, idProducto, cantidadEntrante, costoUnitario, subtotal);

                    if (resultadoDetalle)
                    {
                        MessageBox.Show("Detalle de inventario agregado con éxito.");
                        limpiarCampos();
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
               
            }
        }
        public void limpiarCampos()
        {
            txtCantidadEntrante.Text = "";
            textBoxPrecio.Text = "";
            txtImporte.Text = "";
            txtIVA.Text = "";
            txtTotal.Text = "";
            txtObservaciones.Text = "";
        }

        private void comboBoxProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBoxProveedores.SelectedItem != null)
            {
               
                int idProveedor = ((KeyValuePair<int, string>)comboBoxProveedores.SelectedItem).Key;

               
                Conexion.CargarProductosPorProveedor(idProveedor, comboBoxProductos);
            }
        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductos.SelectedItem is KeyValuePair<int, string> selectedItem)
            {
                int idProducto = selectedItem.Key;
                Conexion.ObtenerPrecioProducto(idProducto, textBoxPrecio);
            }
            else
            {
                
            }

        }

    }
}
