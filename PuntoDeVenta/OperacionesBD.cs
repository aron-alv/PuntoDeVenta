using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
namespace PuntoDeVenta
{
    public class OperacionesBD
    {
        private SqlConnection connection;

        public bool AbrirConexion(string Server, string ModoAuth, string User, string Password, string Database)
        {
            try
            {
                string connectionString = $"Data Source={Server};Initial Catalog={Database};User ID={User};Password={Password}; MultipleActiveResultSets=True";

                connection = new SqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool CerrarConexion()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //////                                                      /////////////
        //////ss                     PRODUCTOS                      /////////////
        //////s                                                      /
        /////////ss
        public bool AgregarProducto(int ID_Producto, string Nombre, double Precio, string Descripcion, int ID_Proveedor)
        {
            try
            {
                string query = "INSERT INTO Producto (ID_Producto, Nombre, Precio, Descripcion, ID_Proveedor) " +
                    "VALUES (@ID_Producto, @Nombre, @Precio, @Descripcion, @ID_Proveedor)";
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Precio", Precio);
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error al agregar el Producto: {ex.Message}");
            }
        }
        public bool EliminarProducto(int ID_Producto)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Eliminar registros relacionados en la tabla DetalleVenta
                string deleteDetalleVentaQuery = "DELETE FROM DetalleVenta WHERE ID_Producto = @ID_Producto";
                using (SqlCommand deleteDetalleVentaCommand = new SqlCommand(deleteDetalleVentaQuery, connection))
                {
                    deleteDetalleVentaCommand.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                    deleteDetalleVentaCommand.ExecuteNonQuery();
                }

                // Eliminar registros relacionados en la tabla Saldos
                string deleteSaldosQuery = "DELETE FROM Saldos WHERE ID_Producto = @ID_Producto";
                using (SqlCommand deleteSaldosCommand = new SqlCommand(deleteSaldosQuery, connection))
                {
                    deleteSaldosCommand.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                    deleteSaldosCommand.ExecuteNonQuery();
                }

                // Eliminar registros relacionados en la tabla DetalleInventario
                string deleteDetailsQuery = "DELETE FROM DetalleInventario WHERE ID_Producto = @ID_Producto";
                using (SqlCommand deleteDetailsCommand = new SqlCommand(deleteDetailsQuery, connection))
                {
                    deleteDetailsCommand.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                    deleteDetailsCommand.ExecuteNonQuery();
                }

                // Eliminar el producto
                string deleteProductQuery = "DELETE FROM Producto WHERE ID_Producto = @ID_Producto";
                using (SqlCommand deleteProductCommand = new SqlCommand(deleteProductQuery, connection))
                {
                    deleteProductCommand.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                    int rowsAffected = deleteProductCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al eliminar producto: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        public bool ModificarProducto(int ID_Producto, string Nombre, double Precio, string Descripcion, int ID_Proveedor)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "UPDATE Producto SET Nombre = @Nombre, Precio = @Precio, Descripcion = @Descripcion, ID_Proveedor = @ID_Proveedor WHERE ID_Producto = @ID_Producto";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Precio", Precio);
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al modificar el Producto: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public bool BuscarProductosEnTabla(DataGridView tablaProductos)
        {
            tablaProductos.Rows.Clear();
            try
            {
                string query = "SELECT Producto.ID_Producto, Producto.Nombre, Producto.Precio, Producto.Descripcion,Proveedor.Nombre AS NombreProveedor " +
                               "FROM Producto " +
                               "JOIN Proveedor ON Producto.ID_Proveedor = Proveedor.ID_Proveedor";

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tablaProductos.Rows.Add(reader["ID_Producto"], reader["Nombre"], reader["Precio"], reader["Descripcion"], reader["NombreProveedor"]);
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool BuscarProducto(string busqueda, DataGridView tablaProductos)
        {
            tablaProductos.Rows.Clear();
            try
            {
                string query = "SELECT Producto.ID_Producto, Producto.Nombre, Producto.Precio, Producto.Descripcion, Proveedor.Nombre AS NombreProveedor " +
                               "FROM Producto " +
                               "JOIN Proveedor ON Producto.ID_Proveedor = Proveedor.ID_Proveedor " +
                               "WHERE Producto.ID_Producto LIKE @Busqueda OR Producto.Nombre LIKE @Busqueda";

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tablaProductos.Rows.Add(reader["ID_Producto"], reader["Nombre"], reader["Precio"], reader["Descripcion"], reader["NombreProveedor"]);
                        }
                    }
                }

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error buscando el producto: {ex.Message}");
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public Dictionary<int, string> ObtenerProductos()
        {

            Dictionary<int, string> productos = new Dictionary<int, string>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT ID_Producto, Nombre FROM Producto";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(reader.GetInt32(0), reader.GetString(1));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener productos: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return productos;
        }





        public bool ObtenerProductoDetalle(int ID_Producto, out string Nombre, out double Precio)
        {
            Nombre = string.Empty;
            Precio = 0.0;

            try
            {
                string query = "SELECT Nombre, Precio FROM Producto WHERE ID_Producto = @ID_Producto";

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Producto", ID_Producto);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Nombre = reader["Nombre"].ToString();
                            Precio = Convert.ToDouble(reader["Precio"]);
                            return true;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error obteniendo el detalle del producto: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return false;
        }


        public void CargarProductosPorProveedor(int idProveedor, System.Windows.Forms.ComboBox comboBoxProductos)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT ID_Producto, Nombre FROM Producto WHERE ID_Proveedor = @ID_Proveedor";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Proveedor", idProveedor);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Dictionary<int, string> productos = new Dictionary<int, string>();
                        while (reader.Read())
                        {
                            productos.Add(reader.GetInt32(0), reader.GetString(1));
                        }
                        comboBoxProductos.DataSource = new BindingSource(productos, null);
                        comboBoxProductos.DisplayMember = "Value";
                        comboBoxProductos.ValueMember = "Key";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }






        public void ObtenerPrecioProducto(int idProducto, System.Windows.Forms.TextBox textBoxPrecio)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT Precio FROM Producto WHERE ID_Producto = @ID_Producto";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Producto", idProducto);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        textBoxPrecio.Text = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener precio del producto: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }



        public bool BuscarProductoporNombreYCantidad(DataGridView tablaProductos)
        {
            tablaProductos.Rows.Clear();
            try
            {
                string query = "SELECT Producto.Nombre, Saldos.Cantidad_Disponible " +
                               "FROM Producto " +
                               "JOIN Saldos ON Producto.ID_Producto = Saldos.ID_Producto";

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tablaProductos.Rows.Add(reader["Nombre"], reader["Cantidad_Disponible"]);
                        }
                    }
                }

                return true;
            }
            catch (SqlException ex)
            {
              
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        //////                                                      /////////////
        //////ss                     PRVEEDORES                     /////////////
        //////s                                                      /
        /////////ss
        public bool AgregarProveedor(int ID_Proveedor, string Nombre, string Telefono, string Direccion)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                string query = "INSERT INTO Proveedor (ID_Proveedor, Nombre, Telefono, Direccion) " +
                    "VALUES (@ID_Proveedor, @Nombre, @Telefono, @Direccion)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Direccion", Direccion);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error al agregar el Proveedor: {ex.Message}");
            }
        }
        public Dictionary<int, string> ObtenerProveedores()
        {
            Dictionary<int, string> proveedores = new Dictionary<int, string>();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                string query = "SELECT ID_Proveedor, Nombre FROM Proveedor";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["ID_Proveedor"];
                            string nombre = reader["Nombre"].ToString();

                            proveedores.Add(id, nombre);
                        }
                    }
                }

                return proveedores;
            }
            catch
            {
                return proveedores;
            }
        }
        public bool ObtenerProveedoresEnTabla(DataGridView tablaProveedores)
        {
            tablaProveedores.Rows.Clear();
            try
            {
                string query = "SELECT * FROM Proveedor";


                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tablaProveedores.Rows.Add(reader["ID_Proveedor"], reader["Nombre"], reader["Telefono"], reader["Direccion"]);
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EliminarProveedor(int ID_Proveedor)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                // Eliminar registros relacionados en la tabla DetalleVenta
                string deleteDetalleVentaQuery = "DELETE FROM DetalleVenta WHERE ID_Producto IN (SELECT ID_Producto FROM Producto WHERE ID_Proveedor = @ID_Proveedor)";
                using (SqlCommand deleteDetalleVentaCommand = new SqlCommand(deleteDetalleVentaQuery, connection))
                {
                    deleteDetalleVentaCommand.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);
                    deleteDetalleVentaCommand.ExecuteNonQuery();
                }

                // Eliminar registros relacionados en la tabla DetalleInventario
                string deleteDetalleInventarioQuery = "DELETE FROM DetalleInventario WHERE ID_Inventario IN (SELECT ID_Inventario FROM Inventario WHERE ID_Proveedor = @ID_Proveedor)";
                using (SqlCommand deleteDetalleInventarioCommand = new SqlCommand(deleteDetalleInventarioQuery, connection))
                {
                    deleteDetalleInventarioCommand.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);
                    deleteDetalleInventarioCommand.ExecuteNonQuery();
                }

                // Eliminar registros relacionados en la tabla Inventario
                string deleteInventarioQuery = "DELETE FROM Inventario WHERE ID_Proveedor = @ID_Proveedor";
                using (SqlCommand deleteInventarioCommand = new SqlCommand(deleteInventarioQuery, connection))
                {
                    deleteInventarioCommand.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);
                    deleteInventarioCommand.ExecuteNonQuery();
                }
                // Eliminar registros relacionados en la tabla Saldos
                string deleteSaldosQuery = "DELETE FROM Saldos WHERE ID_Producto IN (SELECT ID_Producto FROM Producto WHERE ID_Proveedor = @ID_Proveedor)";
                using (SqlCommand deleteSaldosCommand = new SqlCommand(deleteSaldosQuery, connection))
                {
                    deleteSaldosCommand.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);
                    deleteSaldosCommand.ExecuteNonQuery();
                }

                // Eliminar registros relacionados en la tabla Producto
                string deleteProductoQuery = "DELETE FROM Producto WHERE ID_Proveedor = @ID_Proveedor";
                using (SqlCommand deleteProductoCommand = new SqlCommand(deleteProductoQuery, connection))
                {
                    deleteProductoCommand.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);
                    deleteProductoCommand.ExecuteNonQuery();
                }


                // Eliminar el proveedor
                string deleteProveedorQuery = "DELETE FROM Proveedor WHERE ID_Proveedor = @ID_Proveedor";
                using (SqlCommand deleteProveedorCommand = new SqlCommand(deleteProveedorQuery, connection))
                {
                    deleteProveedorCommand.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);
                    int rowsAffected = deleteProveedorCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al eliminar el Proveedor: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public bool BuscarProveedor(string busqueda, DataGridView tablaProveedores)
        {
            tablaProveedores.Rows.Clear();
            try
            {
                string query = "SELECT * FROM Proveedor WHERE ID_Proveedor LIKE @Busqueda OR Nombre LIKE @Busqueda";


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tablaProveedores.Rows.Add(reader["ID_Proveedor"], reader["Nombre"], reader["Telefono"], reader["Direccion"]);
                        }
                    }
                }

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error buscando el proveedor: {ex.Message}");
                return false;
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public bool ModificarProveedor(int ID_Proveedor, string Nombre, string Telefono, string Direccion)
        {
            try
            {

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "UPDATE Proveedor SET Nombre = @Nombre, Telefono = @Telefono, Direccion = @Direccion WHERE ID_Proveedor = @ID_Proveedor";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Direccion", Direccion);


                    int rowsAffected = command.ExecuteNonQuery();


                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"Error al modificar el Proveedor: {ex.Message}");
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        //////                                                      /////////////
        //////ss                     CLIENTES                     /////////////
        //////s                                                      /
        /////////ss
        public bool AgregarCliente(string Nombre, string Telefono, string Direccion, out int nuevoID)
        {
            nuevoID = 0;

            try
            {

                string query = "INSERT INTO Cliente (Nombre, Telefono, Direccion) " +
                               "VALUES (@Nombre, @Telefono, @Direccion); " +
                               "SELECT SCOPE_IDENTITY();"; // Obtener el último ID insertado

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Direccion", Direccion);

                    // Ejecutar el comando y obtener el nuevo ID
                    nuevoID = Convert.ToInt32(command.ExecuteScalar());

                    return nuevoID > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente: " + ex.Message);
                return false;
            }
        }
        public int ObtenerSiguienteIDCliente()
        {
            try
            {
                string query = "SELECT ISNULL(MAX(ID_Cliente), 0) + 1 FROM Cliente";

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int siguienteID = (int)command.ExecuteScalar();
                    return siguienteID;
                }
            }
            catch (Exception ex)
            {
              
                return -1;
            }
        }





        public Dictionary<int, string> ObtenerClientes()
        {
            Dictionary<int, string> clientes = new Dictionary<int, string>();

            try
            {
                string query = "SELECT ID_Cliente, Nombre FROM Cliente";


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["ID_Cliente"];
                            string nombre = reader["Nombre"].ToString();

                            clientes.Add(id, nombre);
                        }
                    }
                }

                return clientes;
            }
            catch
            {
                return clientes;
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }




        public bool ObtenerClientesEnTabla(DataGridView tablaClientes)
        {
            tablaClientes.Rows.Clear();
            try
            {
                string query = "SELECT * FROM Cliente";


                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tablaClientes.Rows.Add(reader["ID_Cliente"], reader["Nombre"], reader["Telefono"], reader["Direccion"]);
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarCliente(int ID_Cliente)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Eliminar primero los registros relacionados en DetalleVenta
                string deleteDetalleVentaQuery = "DELETE FROM DetalleVenta WHERE ID_Venta IN (SELECT ID_Venta FROM Venta WHERE ID_Cliente = @ID_Cliente)";
                using (SqlCommand deleteDetalleVentaCommand = new SqlCommand(deleteDetalleVentaQuery, connection))
                {
                    deleteDetalleVentaCommand.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                    deleteDetalleVentaCommand.ExecuteNonQuery();
                }

                // Eliminar los registros relacionados en Venta
                string deleteVentaQuery = "DELETE FROM Venta WHERE ID_Cliente = @ID_Cliente";
                using (SqlCommand deleteVentaCommand = new SqlCommand(deleteVentaQuery, connection))
                {
                    deleteVentaCommand.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                    deleteVentaCommand.ExecuteNonQuery();
                }

                // Ahora eliminar el registro de Cliente
                string deleteClienteQuery = "DELETE FROM Cliente WHERE ID_Cliente = @ID_Cliente";
                using (SqlCommand deleteClienteCommand = new SqlCommand(deleteClienteQuery, connection))
                {
                    deleteClienteCommand.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                    int rowsAffected = deleteClienteCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
               
                throw new Exception($"Error al eliminar al cliente: {ex.Message}");
               
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        public bool ModificarCliente(int ID_Cliente, string Nombre, string Telefono, string Direccion)
        {
            try
            {

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "UPDATE Cliente SET Nombre = @Nombre, Telefono = @Telefono, Direccion = @Direccion WHERE ID_Cliente = @ID_Cliente";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Direccion", Direccion);


                    int rowsAffected = command.ExecuteNonQuery();


                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine($"Error modificando el cliente: {ex.Message}");
                return false;
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public bool BuscarCliente(string busqueda, DataGridView tablaClientes)
        {
            tablaClientes.Rows.Clear();
            try
            {
                string query = "SELECT * FROM Cliente WHERE ID_Cliente LIKE @Busqueda OR Nombre LIKE @Busqueda";


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tablaClientes.Rows.Add(reader["ID_Cliente"], reader["Nombre"], reader["Telefono"], reader["Direccion"]);
                        }
                    }
                }

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error buscando el cliente: {ex.Message}");
                return false;
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        //////                                                      /////////////
        //////ss                     SALDO                     /////////////
        //////s                                                      /
        /////////ss

        // Métodos para la tabla Saldos
        public bool AgregarSaldo(int ID_Producto, double Cantidad_Entrante, double Cantidad_Salida)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Verificar si el producto ya existe en la tabla Saldos
                string queryExistencia = "SELECT COUNT(*) FROM Saldos WHERE ID_Producto = @ID_Producto";
                using (SqlCommand commandExistencia = new SqlCommand(queryExistencia, connection))
                {
                    commandExistencia.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                    int count = (int)commandExistencia.ExecuteScalar();

                    if (count > 0)
                    {
                        // Si existe, actualizamos la cantidad entrante sumando la nueva cantidad
                        string queryActualizar = "UPDATE Saldos SET Cantidad_Entrante = Cantidad_Entrante + @Cantidad_Entrante WHERE ID_Producto = @ID_Producto";
                        using (SqlCommand commandActualizar = new SqlCommand(queryActualizar, connection))
                        {
                            commandActualizar.Parameters.AddWithValue("@Cantidad_Entrante", Cantidad_Entrante);
                            commandActualizar.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                            int rowsAffected = commandActualizar.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                    }
                    else
                    {
                        // Si no existe, insertamos un nuevo registro en Saldos
                        string queryInsertar = "INSERT INTO Saldos (ID_Producto, Cantidad_Entrante, Cantidad_Salida) " +
                                               "VALUES (@ID_Producto, @Cantidad_Entrante, @Cantidad_Salida)";
                        using (SqlCommand commandInsertar = new SqlCommand(queryInsertar, connection))
                        {
                            commandInsertar.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                            commandInsertar.Parameters.AddWithValue("@Cantidad_Entrante", Cantidad_Entrante);
                            commandInsertar.Parameters.AddWithValue("@Cantidad_Salida", Cantidad_Salida);

                            int rowsAffected = commandInsertar.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool BuscarSaldosEnTabla(DataGridView tablaSaldos)
        {
            tablaSaldos.Rows.Clear();
            try
            {
                // Consulta modificada con JOIN para obtener el nombre del producto
                string query = @"SELECT s.ID_Saldo, p.Nombre, s.Cantidad_Entrante, 
                         s.Cantidad_Salida, s.Cantidad_Disponible 
                         FROM Saldos s
                         INNER JOIN Producto p ON s.ID_Producto = p.ID_Producto";

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Aquí se añade el nombre del producto en lugar del ID
                            tablaSaldos.Rows.Add(reader["ID_Saldo"], reader["Nombre"],
                                                 reader["Cantidad_Entrante"],
                                                 reader["Cantidad_Salida"],
                                                 reader["Cantidad_Disponible"]);
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }



        //////                                                      /////////////
        //////ss                     VENTAS                     /////////////
        //////s                                                      /
        /////////ss
        public bool RegistrarVenta(DateTime Fecha, decimal Importe, decimal IVA, decimal Total, string Metodo_Pago, int ID_Cliente, List<Tuple<int, decimal, decimal>> detallesVenta)
        {
            SqlTransaction transaction = null;

            try
            {

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                transaction = connection.BeginTransaction();

                // Verificar la existencia del producto y su stock
                foreach (var detalle in detallesVenta)
                {
                    int ID_Producto = detalle.Item1;
                    decimal cantidadVendida = detalle.Item2;

                    // Obtener el stock del producto
                    string queryStock = "SELECT Cantidad_Disponible FROM Saldos WHERE ID_Producto = @ID_Producto";
                    SqlCommand cmdStock = new SqlCommand(queryStock, connection, transaction);
                    cmdStock.Parameters.AddWithValue("@ID_Producto", ID_Producto);

                    object result = cmdStock.ExecuteScalar();
                    if (result == null)
                    {
                        Console.WriteLine($"No se encontró información de stock para el producto con ID {ID_Producto}");
                        transaction.Rollback();
                        return false;
                    }

                    decimal stockActual = Convert.ToDecimal(result);

                    // Obtener el nombre del producto
                    string queryNombre = "SELECT Nombre FROM Producto WHERE ID_Producto = @ID_Producto";
                    SqlCommand cmdNombre = new SqlCommand(queryNombre, connection, transaction);
                    cmdNombre.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                    string nombreProducto = cmdNombre.ExecuteScalar() as string;

                    if (stockActual < cantidadVendida)
                    {
                        throw new Exception($"Stock insuficiente para el producto '{nombreProducto}'. Stock actual: {stockActual}");
                    }
                }

                // Registrar la venta 
                string queryVenta = "INSERT INTO Venta (Fecha, Importe, IVA, Total, Metodo_Pago, ID_Cliente) " +
                                    "VALUES (@Fecha, @Importe, @IVA, @Total, @Metodo_Pago, @ID_Cliente); " +
                                    "SELECT SCOPE_IDENTITY();";
                SqlCommand cmdVenta = new SqlCommand(queryVenta, connection, transaction);
                cmdVenta.Parameters.AddWithValue("@Fecha", Fecha);
                cmdVenta.Parameters.AddWithValue("@Importe", Importe);
                cmdVenta.Parameters.AddWithValue("@IVA", IVA);
                cmdVenta.Parameters.AddWithValue("@Total", Total);
                cmdVenta.Parameters.AddWithValue("@Metodo_Pago", Metodo_Pago);
                cmdVenta.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);

                // Obtener el ID Venta recien agregsdo
                int ID_Venta = Convert.ToInt32(cmdVenta.ExecuteScalar());

                // Registrar los detalles de la venta en la tabla Detalle Venta
                foreach (var detalle in detallesVenta)
                {
                    int ID_Producto = detalle.Item1;
                    decimal cantidadVendida = detalle.Item2;
                    decimal precioUnitario = detalle.Item3;
                    decimal subtotal = cantidadVendida * precioUnitario;

                    // Insertar los detalles en la tabla Detalle Venta 
                    string queryDetalleVenta = "INSERT INTO DetalleVenta (ID_Venta, ID_Producto, Cantidad, Precio_Unitario, Subtotal) " +
                                               "VALUES (@ID_Venta, @ID_Producto, @Cantidad, @Precio_Unitario, @Subtotal)";
                    SqlCommand cmdDetalleVenta = new SqlCommand(queryDetalleVenta, connection, transaction);
                    cmdDetalleVenta.Parameters.AddWithValue("@ID_Venta", ID_Venta);
                    cmdDetalleVenta.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                    cmdDetalleVenta.Parameters.AddWithValue("@Cantidad", cantidadVendida);
                    cmdDetalleVenta.Parameters.AddWithValue("@Precio_Unitario", precioUnitario);
                    cmdDetalleVenta.Parameters.AddWithValue("@Subtotal", subtotal);
                    cmdDetalleVenta.ExecuteNonQuery();

                    // Actualizar el stock de Saldos
                    string queryUpdateStock = "UPDATE Saldos SET Cantidad_Salida = Cantidad_Salida + @Cantidad WHERE ID_Producto = @ID_Producto";
                    SqlCommand cmdUpdateStock = new SqlCommand(queryUpdateStock, connection, transaction);
                    cmdUpdateStock.Parameters.AddWithValue("@Cantidad", cantidadVendida);
                    cmdUpdateStock.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                    cmdUpdateStock.ExecuteNonQuery();
                }


                transaction.Commit();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                throw new Exception($"Error al registrar la venta: {ex.Message}");
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public int ObtenerProximoIDVenta()
        {
            int proximoID = 1;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT ISNULL(MAX(ID_Venta), 0) + 1 FROM Venta";
                SqlCommand command = new SqlCommand(query, connection);

                // Obtiene el siguiente ID de venta
                proximoID = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
              
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return proximoID;
        }

        public bool BuscarIDVenta(int ID_Venta, DataGridView tablaFolios)
        {
            tablaFolios.Rows.Clear();
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Consulta SQL con JOIN para obtener el nombre del cliente
                string query = @"
            SELECT v.ID_Venta, v.Fecha, v.Importe, v.IVA, v.Total, v.Metodo_Pago, c.Nombre AS Nombre_Cliente
            FROM Venta v
            JOIN Cliente c ON v.ID_Cliente = c.ID_Cliente
            WHERE v.ID_Venta = @ID_Venta";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Venta", ID_Venta);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tablaFolios.Rows.Add(
                                reader["ID_Venta"],
                                reader["Fecha"],
                                reader["Importe"],
                                reader["IVA"],
                                reader["Total"],
                                reader["Metodo_Pago"],
                                reader["Nombre_Cliente"] 
                            );
                        }
                    }
                }

                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al buscar la venta: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }





        //////                                                      /////////////
        //////ss                   INVENTARIO                /////////////
        //////s                                                      /
        /////////ss


        public int AgregarInventario(DateTime fechaRegistro, string observaciones, decimal importe, decimal iva, decimal total, int idProveedor)
        {
            try
            {
                string query = "INSERT INTO Inventario (Fecha_Registro, Observaciones, Importe, IVA, Total, ID_Proveedor) " +
                "OUTPUT INSERTED.ID_Inventario " +
                "VALUES (@FechaRegistro, @Observaciones, @Importe, @IVA, @Total, @ID_Proveedor)";

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);
                    command.Parameters.AddWithValue("@Observaciones", observaciones);
                    command.Parameters.AddWithValue("@Importe", importe);
                    command.Parameters.AddWithValue("@IVA", iva);
                    command.Parameters.AddWithValue("@Total", total);
                    command.Parameters.AddWithValue("@ID_Proveedor", idProveedor);

                    int idInventario = (int)command.ExecuteScalar();
                    return idInventario;
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"Error al agregar el inventario: {ex.Message}");
            }
        }



        public bool AgregarDetalleInventario(int ID_Inventario, List<Tuple<int, decimal, decimal>> productos)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var producto in productos)
                        {
                            int ID_Producto = producto.Item1;
                            decimal Cantidad_Entrante = producto.Item2;
                            decimal Costo_Unitario = producto.Item3;

                            decimal Subtotal = Cantidad_Entrante * Costo_Unitario; // Calculo correcto del subtotal para cada producto

                            // Verificar si el producto ya existe en la tabla Saldos
                            string queryExistencia = "SELECT COUNT(*) FROM Saldos WHERE ID_Producto = @ID_Producto";
                            using (SqlCommand commandExistencia = new SqlCommand(queryExistencia, connection, transaction))
                            {
                                commandExistencia.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                                int count = (int)commandExistencia.ExecuteScalar();

                                if (count > 0)
                                {
                                    // Si existe se actualiza la cantidad
                                    string queryActualizar = "UPDATE Saldos SET Cantidad_Entrante = Cantidad_Entrante + @Cantidad_Entrante WHERE ID_Producto = @ID_Producto";
                                    using (SqlCommand commandActualizar = new SqlCommand(queryActualizar, connection, transaction))
                                    {
                                        commandActualizar.Parameters.AddWithValue("@Cantidad_Entrante", Cantidad_Entrante);
                                        commandActualizar.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                                        commandActualizar.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    // Si no existe, se inserta un nuevo registro en Saldos
                                    string queryInsertar = "INSERT INTO Saldos (ID_Producto, Cantidad_Entrante, Cantidad_Salida) " +
                                                           "VALUES (@ID_Producto, @Cantidad_Entrante, 0)";
                                    using (SqlCommand commandInsertar = new SqlCommand(queryInsertar, connection, transaction))
                                    {
                                        commandInsertar.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                                        commandInsertar.Parameters.AddWithValue("@Cantidad_Entrante", Cantidad_Entrante);
                                        commandInsertar.ExecuteNonQuery();
                                    }
                                }
                            }

                            string query = "INSERT INTO DetalleInventario (ID_Inventario, ID_Producto, Cantidad_Entrante, Costo_Unitario, Subtotal) " +
                                           "VALUES (@ID_Inventario, @ID_Producto, @Cantidad_Entrante, @Costo_Unitario, @Subtotal)";

                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ID_Inventario", ID_Inventario);
                                command.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                                command.Parameters.AddWithValue("@Cantidad_Entrante", Cantidad_Entrante);
                                command.Parameters.AddWithValue("@Costo_Unitario", Costo_Unitario);
                                command.Parameters.AddWithValue("@Subtotal", Subtotal);

                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error al agregar detalles de inventario: {ex.Message}");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }







        //////////////////////////////////                         FILTRAR                   //////////////////////////////////   
        /// //////////////////////////////////                                              //////////////////////////////////
        public bool FiltrarInventario(DataGridView tablaInventario, DateTime? fechaInicio = null, DateTime? fechaFin = null, int? idProveedor = null)
        {
            try
            {
                // Consulta con JOIN para obtener el nombre del proveedor
                StringBuilder query = new StringBuilder(@"
        SELECT i.ID_Inventario, i.Fecha_Registro, i.Observaciones, i.Importe, i.IVA, i.Total, 
               p.Nombre AS Nombre_Proveedor
        FROM Inventario i
        JOIN Proveedor p ON i.ID_Proveedor = p.ID_Proveedor
        WHERE 1=1");

                // Filtrar por rango de fechas
                if (fechaInicio.HasValue && fechaFin.HasValue)
                {
                    query.Append(" AND i.Fecha_Registro >= @Fecha_Inicio AND i.Fecha_Registro < @Fecha_Fin");
                }

                // Filtrar por ID del proveedor
                if (idProveedor.HasValue)
                {
                    query.Append(" AND i.ID_Proveedor = @ID_Proveedor");
                }

                using (SqlCommand command = new SqlCommand(query.ToString(), connection))
                {
                    // Añadir parámetros para el rango de fechas
                    if (fechaInicio.HasValue && fechaFin.HasValue)
                    {
                        command.Parameters.AddWithValue("@Fecha_Inicio", fechaInicio.Value.Date);
                        command.Parameters.AddWithValue("@Fecha_Fin", fechaFin.Value.Date.AddDays(1)); // Incluye el fin del rango
                    }

                    // Añadir el parametro para el  ID del proveedor
                    if (idProveedor.HasValue)
                    {
                        command.Parameters.AddWithValue("@ID_Proveedor", idProveedor.Value);
                    }

                    // Llenar el DataGridView
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    tablaInventario.DataSource = dataTable;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar inventario: " + ex.Message);
                return false;
            }
        }


        public bool FiltrarVentas(DataGridView tablaVentas, DateTime? fechaInicio = null, DateTime? fechaFin = null, int? idCliente = null)
        {
            tablaVentas.Rows.Clear();
            try
            {
                // consulta  con JOIN para obtener el nombre del cliente
                StringBuilder queryBuilder = new StringBuilder(@"
        SELECT v.ID_Venta, v.Fecha, v.Importe, v.IVA, v.Total, v.Metodo_Pago, 
              c.Nombre AS Nombre_Cliente 
        FROM Venta v
        JOIN Cliente c ON v.ID_Cliente = c.ID_Cliente
        WHERE 1=1");

                if (fechaInicio.HasValue)
                {
                    queryBuilder.Append(" AND v.Fecha >= @FechaInicio"); // fecha de inicio
                }

                if (fechaFin.HasValue)
                {
                    queryBuilder.Append(" AND v.Fecha <= @FechaFin"); // fecha de fin
                }

                if (idCliente.HasValue)
                {
                    queryBuilder.Append(" AND v.ID_Cliente = @ID_Cliente"); //por ID del cliente
                }

                string query = queryBuilder.ToString();

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (fechaInicio.HasValue)
                    {
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio.Value.Date); // fecha de inicio
                    }

                    if (fechaFin.HasValue)
                    {
                        command.Parameters.AddWithValue("@FechaFin", fechaFin.Value.Date); //  fecha de fin
                    }

                    if (idCliente.HasValue)
                    {
                        command.Parameters.AddWithValue("@ID_Cliente", idCliente.Value); // ID del cliente
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tablaVentas.Rows.Add(
                                reader["ID_Venta"],
                                reader["Fecha"],
                                reader["Importe"],
                                reader["IVA"],
                                reader["Total"],
                                reader["Metodo_Pago"],
                                reader["Nombre_Cliente"]
                            );
                        }
                    }
                }

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error filtrando ventas: {ex.Message}");
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public bool BuscarInventarioEnTabla(DataGridView tablaInventario)
        {
            tablaInventario.Rows.Clear();
            try
            {
                string query = "SELECT Inventario.ID_Inventario, Inventario.Fecha_Registro, Inventario.Observaciones, Inventario.Importe, Inventario.IVA, Inventario.Total, Proveedor.Nombre AS NombreProveedor " +
                               "FROM Inventario " +
                               "JOIN Proveedor ON Inventario.ID_Proveedor = Proveedor.ID_Proveedor";

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tablaInventario.Rows.Add(reader["ID_Inventario"], reader["Fecha_Registro"], reader["Observaciones"], reader["Importe"], reader["IVA"], reader["Total"], reader["NombreProveedor"]);
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
