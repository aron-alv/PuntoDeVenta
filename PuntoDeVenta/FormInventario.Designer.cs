﻿namespace ABARROTES
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarProductoATabla = new System.Windows.Forms.Button();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEliminarInventario = new System.Windows.Forms.Button();
            this.txtBuscarDetalleInventario = new System.Windows.Forms.TextBox();
            this.BtnBuscarDetalleInventario = new System.Windows.Forms.Button();
            this.TablaDetalleInventario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnActualizarInventario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDetalleInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(492, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "INVENTARIOS";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Enabled = false;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(897, 50);
            this.dtpFechaRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(311, 22);
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
            this.comboBoxProveedores.Location = new System.Drawing.Point(27, 52);
            this.comboBoxProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProveedores.Name = "comboBoxProveedores";
            this.comboBoxProveedores.Size = new System.Drawing.Size(209, 35);
            this.comboBoxProveedores.TabIndex = 8;
            this.comboBoxProveedores.SelectedIndexChanged += new System.EventHandler(this.comboBoxProveedores_SelectedIndexChanged);
            // 
            // btnRegistrarInventario
            // 
            this.btnRegistrarInventario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarInventario.Location = new System.Drawing.Point(48, 535);
            this.btnRegistrarInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarInventario.Name = "btnRegistrarInventario";
            this.btnRegistrarInventario.Size = new System.Drawing.Size(173, 50);
            this.btnRegistrarInventario.TabIndex = 9;
            this.btnRegistrarInventario.Text = "REGISTRAR INVENTARIO";
            this.btnRegistrarInventario.UseVisualStyleBackColor = true;
            this.btnRegistrarInventario.Click += new System.EventHandler(this.btnRegistrarInventario_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservaciones.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.White;
            this.txtObservaciones.Location = new System.Drawing.Point(27, 133);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(209, 86);
            this.txtObservaciones.TabIndex = 15;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTotal.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(203, 174);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(117, 33);
            this.txtTotal.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Observaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Proveedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(113, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 26);
            this.label7.TabIndex = 28;
            this.label7.Text = "Total";
            // 
            // txtIVA
            // 
            this.txtIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtIVA.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.ForeColor = System.Drawing.Color.White;
            this.txtIVA.Location = new System.Drawing.Point(203, 102);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(117, 33);
            this.txtIVA.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(133, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 26);
            this.label6.TabIndex = 27;
            this.label6.Text = "iva";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBoxProductos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductos.ForeColor = System.Drawing.Color.White;
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(27, 272);
            this.comboBoxProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(209, 32);
            this.comboBoxProductos.TabIndex = 31;
            this.comboBoxProductos.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductos_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(77, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(40, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "Cantidad Entrante";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(77, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBoxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.ForeColor = System.Drawing.Color.White;
            this.textBoxPrecio.Location = new System.Drawing.Point(27, 454);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrecio.Multiline = true;
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(209, 42);
            this.textBoxPrecio.TabIndex = 33;
            // 
            // txtCantidadEntrante
            // 
            this.txtCantidadEntrante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCantidadEntrante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadEntrante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadEntrante.ForeColor = System.Drawing.Color.White;
            this.txtCantidadEntrante.Location = new System.Drawing.Point(27, 373);
            this.txtCantidadEntrante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadEntrante.Multiline = true;
            this.txtCantidadEntrante.Name = "txtCantidadEntrante";
            this.txtCantidadEntrante.Size = new System.Drawing.Size(208, 39);
            this.txtCantidadEntrante.TabIndex = 32;
            // 
            // tablaInventario
            // 
            this.tablaInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.tablaInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Inventario,
            this.fecha_Registro,
            this.Obeservaciones,
            this.Importe,
            this.IVA,
            this.TOTAL,
            this.ID_Proveedor});
            this.tablaInventario.Location = new System.Drawing.Point(321, 246);
            this.tablaInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaInventario.Name = "tablaInventario";
            this.tablaInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.tablaInventario.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaInventario.RowTemplate.Height = 24;
            this.tablaInventario.Size = new System.Drawing.Size(1141, 326);
            this.tablaInventario.TabIndex = 36;
            this.tablaInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaInventario_CellContentClick);
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
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.nombreProducto,
            this.Cantidad,
            this.Precio,
            this.SubTotal});
            this.dgvProductos.Location = new System.Drawing.Point(321, 246);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(1141, 327);
            this.dgvProductos.TabIndex = 37;
            this.dgvProductos.Visible = false;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellValueChanged);
            this.dgvProductos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProductos_MouseClick);
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
            // btnAgregarProductoATabla
            // 
            this.btnAgregarProductoATabla.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductoATabla.Location = new System.Drawing.Point(44, 668);
            this.btnAgregarProductoATabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProductoATabla.Name = "btnAgregarProductoATabla";
            this.btnAgregarProductoATabla.Size = new System.Drawing.Size(173, 50);
            this.btnAgregarProductoATabla.TabIndex = 38;
            this.btnAgregarProductoATabla.Text = "agregar a tabla";
            this.btnAgregarProductoATabla.UseVisualStyleBackColor = true;
            this.btnAgregarProductoATabla.Click += new System.EventHandler(this.btnAgregarProductoATabla_Click);
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBoxSubtotal.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubtotal.ForeColor = System.Drawing.Color.White;
            this.textBoxSubtotal.Location = new System.Drawing.Point(203, 31);
            this.textBoxSubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.ReadOnly = true;
            this.textBoxSubtotal.Size = new System.Drawing.Size(117, 33);
            this.textBoxSubtotal.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
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
            this.panel1.Location = new System.Drawing.Point(952, 602);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 247);
            this.panel1.TabIndex = 41;
            this.panel1.Visible = false;
            // 
            // SubMenu
            // 
            this.SubMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SubMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarProductoToolStripMenuItem});
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(197, 28);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // BtnEliminarInventario
            // 
            this.BtnEliminarInventario.Location = new System.Drawing.Point(359, 678);
            this.BtnEliminarInventario.Name = "BtnEliminarInventario";
            this.BtnEliminarInventario.Size = new System.Drawing.Size(128, 52);
            this.BtnEliminarInventario.TabIndex = 42;
            this.BtnEliminarInventario.Text = "Eliminar";
            this.BtnEliminarInventario.UseVisualStyleBackColor = true;
            this.BtnEliminarInventario.Click += new System.EventHandler(this.BtnEliminarInventario_Click);
            // 
            // txtBuscarDetalleInventario
            // 
            this.txtBuscarDetalleInventario.Location = new System.Drawing.Point(539, 133);
            this.txtBuscarDetalleInventario.Multiline = true;
            this.txtBuscarDetalleInventario.Name = "txtBuscarDetalleInventario";
            this.txtBuscarDetalleInventario.Size = new System.Drawing.Size(160, 30);
            this.txtBuscarDetalleInventario.TabIndex = 43;
            // 
            // BtnBuscarDetalleInventario
            // 
            this.BtnBuscarDetalleInventario.Location = new System.Drawing.Point(758, 133);
            this.BtnBuscarDetalleInventario.Name = "BtnBuscarDetalleInventario";
            this.BtnBuscarDetalleInventario.Size = new System.Drawing.Size(210, 30);
            this.BtnBuscarDetalleInventario.TabIndex = 44;
            this.BtnBuscarDetalleInventario.Text = "Buscar Detalle Inventario";
            this.BtnBuscarDetalleInventario.UseVisualStyleBackColor = true;
            this.BtnBuscarDetalleInventario.Click += new System.EventHandler(this.BtnBuscarDetalleInventario_Click);
            // 
            // TablaDetalleInventario
            // 
            this.TablaDetalleInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaDetalleInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaDetalleInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.TablaDetalleInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaDetalleInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDetalleInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.TablaDetalleInventario.Location = new System.Drawing.Point(321, 247);
            this.TablaDetalleInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TablaDetalleInventario.Name = "TablaDetalleInventario";
            this.TablaDetalleInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.TablaDetalleInventario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaDetalleInventario.RowTemplate.Height = 24;
            this.TablaDetalleInventario.Size = new System.Drawing.Size(1141, 326);
            this.TablaDetalleInventario.TabIndex = 45;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Detalle Inventario";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 156;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Inventario";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad entrante";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 129;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "costo Unitario";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 109;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 85;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Proveedor";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // BtnActualizarInventario
            // 
            this.BtnActualizarInventario.Location = new System.Drawing.Point(593, 678);
            this.BtnActualizarInventario.Name = "BtnActualizarInventario";
            this.BtnActualizarInventario.Size = new System.Drawing.Size(92, 55);
            this.BtnActualizarInventario.TabIndex = 46;
            this.BtnActualizarInventario.Text = "Actualizar";
            this.BtnActualizarInventario.UseVisualStyleBackColor = true;
            this.BtnActualizarInventario.Click += new System.EventHandler(this.BtnActualizarInventario_Click);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1660, 860);
            this.Controls.Add(this.BtnActualizarInventario);
            this.Controls.Add(this.tablaInventario);
            this.Controls.Add(this.BtnBuscarDetalleInventario);
            this.Controls.Add(this.txtBuscarDetalleInventario);
            this.Controls.Add(this.BtnEliminarInventario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregarProductoATabla);
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
            this.Controls.Add(this.TablaDetalleInventario);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormInventario";
            this.Text = "FormInventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaDetalleInventario)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip SubMenu;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.Button BtnEliminarInventario;
        private System.Windows.Forms.TextBox txtBuscarDetalleInventario;
        private System.Windows.Forms.Button BtnBuscarDetalleInventario;
        private System.Windows.Forms.DataGridView TablaDetalleInventario;
        private System.Windows.Forms.Button BtnActualizarInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}