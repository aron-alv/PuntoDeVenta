﻿using PuntoDeVenta;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;



namespace ABARROTES
{
    public partial class FormInventario : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        private List<Tuple<int, string, decimal>> productos;

        public FormInventario(OperacionesBD Conexion)
        {
            InitializeComponent();
            this.Conexion = Conexion;
         
            
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
            comboBoxProveedores.Focus();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && this.ActiveControl == txtCantidadEntrante)
            {
                btnAgregarProductoATabla_Click(this, new EventArgs());
                dgvProductos.Visible = true;
                panel1.Visible = true;
                comboBoxProductos.Focus();
                return true; 
            }
          
            return base.ProcessCmdKey(ref msg, keyData);
        }
    
        private void btnRegistrarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaRegistro = dtpFechaRegistro.Value;
                string observaciones = txtObservaciones.Text;

                int? selectedValue = comboBoxProveedores.SelectedValue as int?;
                if (selectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un proveedor.");
                    return;
                }
                int idProveedor = selectedValue.Value;

                decimal importe = 0;
                decimal iva = decimal.Parse(txtIVA.Text, System.Globalization.NumberStyles.Currency);
                decimal total = decimal.Parse(txtTotal.Text, System.Globalization.NumberStyles.Currency);

                List<Tuple<int, decimal, decimal>> productos = new List<Tuple<int, decimal, decimal>>();

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (row.IsNewRow) continue;

                    int idProducto = Convert.ToInt32(row.Cells["ID_Producto"].Value);
                    if (decimal.TryParse(row.Cells["Cantidad"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal cantidad) &&
                        decimal.TryParse(row.Cells["Precio"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precio))
                    {
                        decimal subtotal = cantidad * precio;
                        productos.Add(new Tuple<int, decimal, decimal>(idProducto, cantidad, precio));
                        importe += subtotal;
                    }
                    else
                    {
                        MessageBox.Show("Cantidad o Precio no tienen un formato válido.");
                        return;
                    }
                }

          



                int idInventario = Conexion.AgregarInventario(fechaRegistro, observaciones, importe, iva, total, idProveedor);

                if (idInventario > 0)
                {
                    MessageBox.Show("Inventario registrado con éxito.");
                    Conexion.BuscarInventarioEnTabla(tablaInventario);

                    bool resultadoDetalle = Conexion.AgregarDetalleInventario(idInventario, productos); // No envíes el total aquí

                    if (resultadoDetalle)
                    {
                        MessageBox.Show("Detalle de inventario agregado con éxito.");
                        dgvProductos.Visible = false;
                        panel1.Visible = false;
                        comboBoxProveedores.Enabled = true;
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el detalle del inventario.");
                    }
                }
                else
                {
                    MessageBox.Show("Error al registrar el inventario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void limpiarCampos()
        {
            txtCantidadEntrante.Text = "";
            textBoxPrecio.Text = "";
            
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

        private void btnAgregarProductoATabla_Click(object sender, EventArgs e)
        {
            try
            {
                var productoSeleccionado = (KeyValuePair<int, string>)comboBoxProductos.SelectedItem;
                var idProducto = productoSeleccionado.Key;
                var nombreProducto = productoSeleccionado.Value;
                var cantidad = txtCantidadEntrante.Text;
                var precio = textBoxPrecio.Text;

                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(cantidad) || string.IsNullOrEmpty(precio))
                {
                    MessageBox.Show("Por favor, ingrese la cantidad y el precio.");
                    return;
                }

                // Validar que la cantidad y el precio sean valores numéricos
                if (!decimal.TryParse(cantidad, out decimal cantidadDecimal) || !decimal.TryParse(precio, out decimal precioDecimal))
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos para la cantidad y el precio.");
                    return;
                }

                // Calcular el subtotal
                decimal SubTotal = cantidadDecimal * precioDecimal;

                // Agregar el producto al DataGridView
                dgvProductos.Rows.Add(idProducto, nombreProducto,cantidadDecimal, precioDecimal, SubTotal);

                // Limpiar los campos de entrada
                txtCantidadEntrante.Clear();
                textBoxPrecio.Clear();
                UpdateTotals();
                comboBoxProveedores.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto a la tabla: {ex.Message}");
            }
        }

        private void UpdateTotals()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow r in dgvProductos.Rows)
            {
                if (r.Cells[4].Value != null)
                {
                    subtotal += Convert.ToDecimal(r.Cells[4].Value);
                }
            }
            decimal iva = subtotal * 0.16m; // IVA
            decimal total = subtotal + iva;

            // actualizar los valores en los TextBoxes
            textBoxSubtotal.Text = subtotal.ToString("C");
            txtIVA.Text = iva.ToString("C");
            txtTotal.Text = total.ToString("C");
        }

        private void dgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0 && e.RowIndex < dgvProductos.Rows.Count)
            {
                var row = dgvProductos.Rows[e.RowIndex];
                decimal cantidad = Convert.ToDecimal(row.Cells[2].Value);
                decimal precio = Convert.ToDecimal(row.Cells[3].Value);
                decimal importe = cantidad * precio;
                row.Cells[4].Value = importe;

                UpdateTotals();
            }
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvProductos.SelectedRows.Count > 0)
            {
                dgvProductos.Rows.Remove(dgvProductos.SelectedRows[0]);
                UpdateTotals();
            }
        }

        private void dgvProductos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                   dgvProductos.ContextMenuStrip = SubMenu;
                }
            }
        }
    }
}
