namespace ABARROTES
{
    partial class FormInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProveedores = new System.Windows.Forms.ComboBox();
            this.btnRegistrarInventario = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidadEntrante = new System.Windows.Forms.TextBox();
            this.tablaInventario = new System.Windows.Forms.DataGridView();
            this.ID_Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obeservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarProductoATabla = new System.Windows.Forms.Button();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(607, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "INVENTARIOS";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(1094, 60);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(254, 22);
            this.dtpFechaRegistro.TabIndex = 2;
            // 
            // comboBoxProveedores
            // 
            this.comboBoxProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBoxProveedores.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProveedores.ForeColor = System.Drawing.Color.White;
            this.comboBoxProveedores.FormattingEnabled = true;
            this.comboBoxProveedores.Location = new System.Drawing.Point(250, 130);
            this.comboBoxProveedores.Name = "comboBoxProveedores";
            this.comboBoxProveedores.Size = new System.Drawing.Size(214, 35);
            this.comboBoxProveedores.TabIndex = 8;
            this.comboBoxProveedores.SelectedIndexChanged += new System.EventHandler(this.comboBoxProveedores_SelectedIndexChanged);
            // 
            // btnRegistrarInventario
            // 
            this.btnRegistrarInventario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarInventario.Location = new System.Drawing.Point(269, 574);
            this.btnRegistrarInventario.Name = "btnRegistrarInventario";
            this.btnRegistrarInventario.Size = new System.Drawing.Size(173, 50);
            this.btnRegistrarInventario.TabIndex = 9;
            this.btnRegistrarInventario.Text = "REGISTRAR INVENTARIO";
            this.btnRegistrarInventario.UseVisualStyleBackColor = true;
            this.btnRegistrarInventario.Click += new System.EventHandler(this.btnRegistrarInventario_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(250, 196);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(210, 87);
            this.txtObservaciones.TabIndex = 15;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(203, 173);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(117, 33);
            this.txtTotal.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Observaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Proveedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 26);
            this.label7.TabIndex = 28;
            this.label7.Text = "Total";
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(203, 102);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(117, 33);
            this.txtIVA.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 26);
            this.label6.TabIndex = 27;
            this.label6.Text = "iva";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProductos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(250, 327);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(210, 32);
            this.comboBoxProductos.TabIndex = 31;
            this.comboBoxProductos.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductos_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "Cantidad Entrante";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(150, 478);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(250, 475);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(210, 30);
            this.textBoxPrecio.TabIndex = 33;
            // 
            // txtCantidadEntrante
            // 
            this.txtCantidadEntrante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadEntrante.Location = new System.Drawing.Point(250, 401);
            this.txtCantidadEntrante.Name = "txtCantidadEntrante";
            this.txtCantidadEntrante.Size = new System.Drawing.Size(210, 30);
            this.txtCantidadEntrante.TabIndex = 32;
            // 
            // tablaInventario
            // 
            this.tablaInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.tablaInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Inventario,
            this.fecha_Registro,
            this.Obeservaciones,
            this.Importe,
            this.IVA,
            this.TOTAL,
            this.ID_Proveedor});
            this.tablaInventario.Location = new System.Drawing.Point(558, 136);
            this.tablaInventario.Name = "tablaInventario";
            this.tablaInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.tablaInventario.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaInventario.RowTemplate.Height = 24;
            this.tablaInventario.Size = new System.Drawing.Size(1166, 326);
            this.tablaInventario.TabIndex = 36;
            // 
            // ID_Inventario
            // 
            this.ID_Inventario.HeaderText = "ID Inventario";
            this.ID_Inventario.MinimumWidth = 6;
            this.ID_Inventario.Name = "ID_Inventario";
            this.ID_Inventario.Width = 110;
            // 
            // fecha_Registro
            // 
            this.fecha_Registro.HeaderText = "fecha Registro";
            this.fecha_Registro.MinimumWidth = 6;
            this.fecha_Registro.Name = "fecha_Registro";
            this.fecha_Registro.Width = 123;
            // 
            // Obeservaciones
            // 
            this.Obeservaciones.HeaderText = "Obeservaciones";
            this.Obeservaciones.MinimumWidth = 6;
            this.Obeservaciones.Name = "Obeservaciones";
            this.Obeservaciones.Width = 136;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.Width = 81;
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.MinimumWidth = 6;
            this.IVA.Name = "IVA";
            this.IVA.Width = 57;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 6;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Width = 80;
            // 
            // ID_Proveedor
            // 
            this.ID_Proveedor.HeaderText = "Proveedor";
            this.ID_Proveedor.MinimumWidth = 6;
            this.ID_Proveedor.Name = "ID_Proveedor";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.nombreProducto,
            this.Cantidad,
            this.Precio,
            this.SubTotal});
            this.dgvProductos.Location = new System.Drawing.Point(558, 135);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(1166, 327);
            this.dgvProductos.TabIndex = 37;
            this.dgvProductos.Visible = false;
            this.dgvProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellValueChanged);
            // 
            // btnAgregarProductoATabla
            // 
            this.btnAgregarProductoATabla.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductoATabla.Location = new System.Drawing.Point(269, 699);
            this.btnAgregarProductoATabla.Name = "btnAgregarProductoATabla";
            this.btnAgregarProductoATabla.Size = new System.Drawing.Size(173, 50);
            this.btnAgregarProductoATabla.TabIndex = 38;
            this.btnAgregarProductoATabla.Text = "agregar a tabla";
            this.btnAgregarProductoATabla.UseVisualStyleBackColor = true;
            this.btnAgregarProductoATabla.Click += new System.EventHandler(this.btnAgregarProductoATabla_Click);
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubtotal.Location = new System.Drawing.Point(203, 31);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.ReadOnly = true;
            this.textBoxSubtotal.Size = new System.Drawing.Size(117, 33);
            this.textBoxSubtotal.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Subtotal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIVA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.textBoxSubtotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(763, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 247);
            this.panel1.TabIndex = 41;
            this.panel1.Visible = false;
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID producto";
            this.ID_Producto.MinimumWidth = 6;
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.Visible = false;
            this.ID_Producto.Width = 105;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "nombre";
            this.nombreProducto.MinimumWidth = 6;
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Width = 82;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 90;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 75;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 91;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1855, 860);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregarProductoATabla);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.tablaInventario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.txtCantidadEntrante);
            this.Controls.Add(this.comboBoxProductos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnRegistrarInventario);
            this.Controls.Add(this.comboBoxProveedores);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventario";
            this.Text = "FormInventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.ComboBox comboBoxProveedores;
        private System.Windows.Forms.Button btnRegistrarInventario;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox txtCantidadEntrante;
        private System.Windows.Forms.DataGridView tablaInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obeservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Proveedor;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregarProductoATabla;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}