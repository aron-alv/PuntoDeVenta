
using PuntoDeVenta;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using static ABARROTES.Form1;
using static PuntoDeVenta.OperacionesBD;


namespace ABARROTES
{
    public partial class FormVentas : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        private List<Tuple<int, string, decimal>> productos;

        private PrintPreviewDialog printPreviewDialog1;

        public FormVentas(OperacionesBD conexion)
        {
            InitializeComponent();
            Conexion = conexion;
            this.KeyPreview = true;
           string Usuario=UsuarioActual.Usuario;

        }
        private void CargarClientes()
        {
            // funciON PARA  ObtenerClientes 
            Dictionary<int, string> clientes = Conexion.ObtenerClientes();


            if (clientes.Count > 0)
            {

                comboBoxClientes.DataSource = new BindingSource(clientes, null);
                comboBoxClientes.DisplayMember = "Value";
                comboBoxClientes.ValueMember = "Key";
            }
            else
            {

            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && this.ActiveControl == txtIDVenta)
            {
                BuscarIDVenta_Click(this, new EventArgs());

                return true;
            }
            if (keyData == Keys.F5)
            {
                BtnRealizarVenta_Click(this, new EventArgs());
                return true;
            }
            if (keyData == Keys.Enter && this.ActiveControl == txtCantidad)
            {
                BtnAgregarATabla_Click(this, new EventArgs());
                comboBoxProductos.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void FormVentas_Load(object sender, EventArgs e)
        {
            comboBoxProductos.Items.Clear();
            int proximoIDVenta = Conexion.ObtenerProximoIDVenta();
            txtIDVenta.Text = proximoIDVenta.ToString();


          BtnImprimirTicket.Visible = false;
            productos = new List<Tuple<int, string, decimal>>();
            var productosIds = Conexion.ObtenerProductos().Keys;

            foreach (var id in productosIds)
            {
                if (Conexion.ObtenerProductoDetalle(id, out string nombre, out double precio))
                {
                    productos.Add(new Tuple<int, string, decimal>(id, nombre, (decimal)precio));
                    comboBoxProductos.Items.Add(new { Id = id, Nombre = nombre });
                }
            }
            CbmMetododePago.SelectedIndex = 0;
            comboBoxProductos.DisplayMember = "Nombre";
            comboBoxProductos.ValueMember = "Id";
            CargarClientes();
            comboBoxClientes.TabIndex = 0;
            comboBoxProductos.TabIndex = 1;
            txtCantidad.TabIndex = 2;
            tablaFolios.Visible = false;
            comboBoxClientes.Focus();
        }

        private void BtnAgregarATabla_Click(object sender, EventArgs e)
        {
            if (comboBoxProductos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Ingrese la cantidad del producto.");
                return;
            }
            var selectedProduct = comboBoxProductos.SelectedItem as dynamic;
            int productId = selectedProduct.Id;
            var producto = productos.Find(p => p.Item1 == productId);

            if (producto != null)
            {
                string nombre = producto.Item2;
                decimal precio = producto.Item3;
                decimal cantidad = decimal.Parse(txtCantidad.Text);
                decimal importe = precio * cantidad;
                //si el producto ya esta en la tabla, solo se actualiza la cantidad
                foreach (DataGridViewRow row in dataGridViewProductos.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == productId)
                    {
                        decimal cantidadActual = Convert.ToDecimal(row.Cells[2].Value);
                        decimal precioActual = Convert.ToDecimal(row.Cells[3].Value);
                        decimal importeActual = cantidadActual * precioActual;
                        cantidad += cantidadActual;
                        importe = importeActual + importe;
                        dataGridViewProductos.Rows.Remove(row);
                        break;
                    }
                }
                dataGridViewProductos.Rows.Add(productId, nombre, cantidad, precio, importe);
                panelDatosVenta.Visible = true;
               BtnImprimirTicket.Visible = false;
            }
            UpdateTotals();
            txtCantidad.Text = "";
            comboBoxProductos.SelectedIndex = -1;
            tablaFolios.Visible = false;
        }

        private void dataGridViewProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0 && e.RowIndex < dataGridViewProductos.Rows.Count)
            {
                var row = dataGridViewProductos.Rows[e.RowIndex];
                decimal cantidad = Convert.ToDecimal(row.Cells[2].Value);
                decimal precio = Convert.ToDecimal(row.Cells[3].Value);
                decimal importe = cantidad * precio;
                row.Cells[4].Value = importe;


                UpdateTotals();
            }
        }
        private void UpdateTotals()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow r in dataGridViewProductos.Rows)
            {
                if (r.Cells[4].Value != null)
                {
                    subtotal += Convert.ToDecimal(r.Cells[4].Value);
                }
            }
            decimal iva = subtotal * 0.16m;
            decimal total = subtotal + iva;

            // actualizar los valores en los TextBoxes
            textBoxSubtotal.Text = subtotal.ToString("C");
            textBoxIVA.Text = iva.ToString("C");
            textBoxTotal.Text = total.ToString("C");
        }

        private void BtnRealizarVenta_Click(object sender, EventArgs e)
        {
            decimal subtotal;
            if (!decimal.TryParse(textBoxSubtotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out subtotal))
            {
                MessageBox.Show("ingrese los Campos faltantes.");
                return;
            }

            decimal iva = decimal.Parse(textBoxIVA.Text, System.Globalization.NumberStyles.Currency);
            decimal total = decimal.Parse(textBoxTotal.Text, System.Globalization.NumberStyles.Currency);
            DateTime fecha = DateTime.Now;
            string metodoPago = CbmMetododePago.Text;


            if (comboBoxClientes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }
            int idCliente = (int)comboBoxClientes.SelectedValue;




            // Obtener los detalles de la venta desde la tabla
            List<Tuple<int, decimal, decimal>> detallesVenta = new List<Tuple<int, decimal, decimal>>();
            foreach (DataGridViewRow row in dataGridViewProductos.Rows)
            {
                if (row.Cells["ID"].Value != null && row.Cells["Cantidad"].Value != null && row.Cells["Importe"].Value != null)
                {
                    int idProducto = Convert.ToInt32(row.Cells["ID"].Value);
                    decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["Importe"].Value);
                    detallesVenta.Add(new Tuple<int, decimal, decimal>(idProducto, cantidad, precio));
                }
            }


            try
            {
                // registrar la venta
                bool ventaRegistrada = Conexion.RegistrarVenta(fecha, subtotal, iva, total, metodoPago, idCliente, detallesVenta);

                if (ventaRegistrada)
                {
                  
                    int idVenta = Conexion.ObtenerProximoIDVenta() - 1;

                 
                    Venta venta = Conexion.ObtenerVentaPorID(idVenta);

               
                    contenidoTicket = GenerarContenidoTicket(venta);

                   
                    printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

                    // Configurar el PrintPreviewDialog
                    PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
                    {
                        Document = printDocument1,
                        WindowState = FormWindowState.Maximized
                    };

                    // muestra la vista preliminar
                    printPreviewDialog.ShowDialog();

                    dataGridViewProductos.Rows.Clear();
                    LimpiarCampos();
                    MessageBox.Show("Venta realizada con éxito.");


                }
                else
                {
                    MessageBox.Show("Error al realizar la venta.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al realizar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LimpiarCampos()
        {
            textBoxSubtotal.Text = "-";
            textBoxIVA.Text = "-";
            textBoxTotal.Text = "-";
            txtCantidad.Text = "";
            comboBoxProductos.SelectedIndex = -1;
        }

        private void eLIMINARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                dataGridViewProductos.Rows.RemoveAt(dataGridViewProductos.SelectedRows[0].Index);
                UpdateTotals();
            }
        }

        private void dataGridViewProductos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dataGridViewProductos.SelectedRows.Count > 0)
                {
                    dataGridViewProductos.ContextMenuStrip = SubMenu;
                }
            }
        }

        private void dataGridViewProductos_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void BuscarIDVenta_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtIDVenta.Text))
            {
                FormVentas_Load(this, new EventArgs());
            }
            else
            {
                int idVenta = int.Parse(txtIDVenta.Text);

                try
                {
                    Conexion.BuscarIDVenta(idVenta, tablaFolios);
                    tablaFolios.Visible = true;
                    panelDatosVenta.Visible = false;
                    BtnImprimirTicket.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnDashBoards_Click(object sender, EventArgs e)
        {
            ReportesVistas reportesVistas = new ReportesVistas(Conexion);
            reportesVistas.Show();

        }
        private string GenerarContenidoTicket(Venta venta)
        {
            decimal totalProductos = 0;
            StringBuilder ticket = new StringBuilder();

            ticket.AppendLine("ABARROTES");
            ticket.AppendLine("================================");
            ticket.AppendLine($"Folio: {venta.NumeroTicket}");
            ticket.AppendLine($"Fecha: {venta.FechaVenta}");
            ticket.AppendLine($"Cliente: {venta.Cliente}");
            ticket.AppendLine($"Vendedor: {UsuarioActual.Usuario}");
            ticket.AppendLine($"Metodo de Pago:{venta.FormaPago}");
            ticket.AppendLine("----------------------------------------------------");

            ticket.AppendLine("PRODUCTO".PadRight(20) + "CANTIDAD".PadRight(11) + "PRECIO".PadRight(12) + "SUBTOTAL".PadRight(8));
            ticket.AppendLine("====================================================");

            foreach (var producto in venta.Productos)
            {
                string nombreProducto = producto.Nombre.PadRight(20).Substring(0, 20);
                string cantidad = producto.Cantidad.ToString().PadLeft(5); 
                string precioUnitario = $"${producto.PrecioUnitario:F2}".PadLeft(12); 
                string subtotal = $"${producto.Subtotal:F2}".PadLeft(14); 

                ticket.AppendLine($"{nombreProducto}{cantidad}{precioUnitario}{subtotal}");
                totalProductos += producto.Subtotal;
            }
       
            ticket.AppendLine("====================================================");
            ticket.AppendLine($"{"Subtotal:".PadLeft(44)}{totalProductos:F2}".PadLeft(15));
            ticket.AppendLine($"{"IVA:".PadLeft(44)}{venta.IVA:F2}".PadLeft(15));
            ticket.AppendLine($"{"Total:".PadLeft(44)}{venta.TotalVenta:F2}".PadLeft(15));
            ticket.AppendLine("====================================================");
            ticket.AppendLine("¡Gracias por su compra!".PadLeft(30));

            return ticket.ToString();
        }



        private string contenidoTicket;

      

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          
            e.Graphics.DrawString(contenidoTicket, new Font("Courier New", 5), Brushes.Black, new PointF(10, 10));
        }

        private void BtnImprimirTicket_Click(object sender, EventArgs e)
        {
            int idventa = int.Parse(txtIDVenta.Text);
            Venta venta = Conexion.ObtenerVentaPorID(idventa);
            contenidoTicket = GenerarContenidoTicket(venta);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);


            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument1,
                WindowState = FormWindowState.Maximized
            };

            
            printPreviewDialog.ShowDialog();
        }
    }

}

