namespace ABARROTES
{
    partial class FormVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.BtnAgregarATabla = new System.Windows.Forms.Button();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRealizarVenta = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSubtotal = new System.Windows.Forms.Label();
            this.textBoxIVA = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SUBTOTAL = new System.Windows.Forms.Label();
            this.SubMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eLIMINARPRODUCTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbmMetododePago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BuscarIDVenta = new System.Windows.Forms.Button();
            this.tablaFolios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDashBoards = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFolios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENTAS";
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxClientes.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(223, 129);
            this.comboBoxClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(247, 35);
            this.comboBoxClientes.TabIndex = 2;
            // 
            // BtnAgregarATabla
            // 
            this.BtnAgregarATabla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarATabla.Location = new System.Drawing.Point(659, 215);
            this.BtnAgregarATabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarATabla.Name = "BtnAgregarATabla";
            this.BtnAgregarATabla.Size = new System.Drawing.Size(159, 78);
            this.BtnAgregarATabla.TabIndex = 4;
            this.BtnAgregarATabla.Text = "Agregar";
            this.BtnAgregarATabla.UseVisualStyleBackColor = true;
            this.BtnAgregarATabla.Click += new System.EventHandler(this.BtnAgregarATabla_Click);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.dataGridViewProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductos.ColumnHeadersHeight = 60;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Producto,
            this.Cantidad,
            this.Importe,
            this.Total});
            this.dataGridViewProductos.Location = new System.Drawing.Point(24, 338);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dataGridViewProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1075, 281);
            this.dataGridViewProductos.TabIndex = 5;
            this.dataGridViewProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellValueChanged);
            this.dataGridViewProductos.SelectionChanged += new System.EventHandler(this.dataGridViewProductos_SelectionChanged);
            this.dataGridViewProductos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewProductos_MouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "PRODUCTO";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Precio Unitario";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "TOTAL";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // BtnRealizarVenta
            // 
            this.BtnRealizarVenta.Location = new System.Drawing.Point(351, 693);
            this.BtnRealizarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRealizarVenta.Name = "BtnRealizarVenta";
            this.BtnRealizarVenta.Size = new System.Drawing.Size(177, 82);
            this.BtnRealizarVenta.TabIndex = 6;
            this.BtnRealizarVenta.Text = "VENDER";
            this.BtnRealizarVenta.UseVisualStyleBackColor = true;
            this.BtnRealizarVenta.Click += new System.EventHandler(this.BtnRealizarVenta_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(722, 65);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProductos.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(223, 188);
            this.comboBoxProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(247, 35);
            this.comboBoxProductos.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "CLIENTE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "PRODUCTOS:";
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.AutoSize = true;
            this.textBoxSubtotal.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubtotal.ForeColor = System.Drawing.Color.White;
            this.textBoxSubtotal.Location = new System.Drawing.Point(987, 651);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.Size = new System.Drawing.Size(22, 32);
            this.textBoxSubtotal.TabIndex = 14;
            this.textBoxSubtotal.Text = "-";
            // 
            // textBoxIVA
            // 
            this.textBoxIVA.AutoSize = true;
            this.textBoxIVA.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIVA.ForeColor = System.Drawing.Color.White;
            this.textBoxIVA.Location = new System.Drawing.Point(987, 694);
            this.textBoxIVA.Name = "textBoxIVA";
            this.textBoxIVA.Size = new System.Drawing.Size(22, 32);
            this.textBoxIVA.TabIndex = 15;
            this.textBoxIVA.Text = "-";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.AutoSize = true;
            this.textBoxTotal.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.White;
            this.textBoxTotal.Location = new System.Drawing.Point(987, 745);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(22, 32);
            this.textBoxTotal.TabIndex = 16;
            this.textBoxTotal.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(763, 745);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "TOTAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(832, 694);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "IVA:";
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.AutoSize = true;
            this.SUBTOTAL.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBTOTAL.ForeColor = System.Drawing.Color.White;
            this.SUBTOTAL.Location = new System.Drawing.Point(740, 651);
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.Size = new System.Drawing.Size(158, 32);
            this.SUBTOTAL.TabIndex = 17;
            this.SUBTOTAL.Text = "SUBTOTAL:";
            // 
            // SubMenu
            // 
            this.SubMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SubMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eLIMINARPRODUCTOToolStripMenuItem});
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(225, 28);
            // 
            // eLIMINARPRODUCTOToolStripMenuItem
            // 
            this.eLIMINARPRODUCTOToolStripMenuItem.Name = "eLIMINARPRODUCTOToolStripMenuItem";
            this.eLIMINARPRODUCTOToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.eLIMINARPRODUCTOToolStripMenuItem.Text = "ELIMINAR PRODUCTO";
            this.eLIMINARPRODUCTOToolStripMenuItem.Click += new System.EventHandler(this.eLIMINARPRODUCTOToolStripMenuItem_Click);
            // 
            // CbmMetododePago
            // 
            this.CbmMetododePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbmMetododePago.FormattingEnabled = true;
            this.CbmMetododePago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA"});
            this.CbmMetododePago.Location = new System.Drawing.Point(787, 129);
            this.CbmMetododePago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbmMetododePago.Name = "CbmMetododePago";
            this.CbmMetododePago.Size = new System.Drawing.Size(159, 24);
            this.CbmMetododePago.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 32);
            this.label6.TabIndex = 21;
            this.label6.Text = "FORMA DE PAGO:";
            // 
            // txtIDVenta
            // 
            this.txtIDVenta.Location = new System.Drawing.Point(153, 38);
            this.txtIDVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDVenta.Name = "txtIDVenta";
            this.txtIDVenta.Size = new System.Drawing.Size(99, 22);
            this.txtIDVenta.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "FOLIO:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(223, 263);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(247, 30);
            this.txtCantidad.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 32);
            this.label8.TabIndex = 25;
            this.label8.Text = "CANTIDAD:";
            // 
            // BuscarIDVenta
            // 
            this.BuscarIDVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarIDVenta.Location = new System.Drawing.Point(309, 30);
            this.BuscarIDVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuscarIDVenta.Name = "BuscarIDVenta";
            this.BuscarIDVenta.Size = new System.Drawing.Size(87, 34);
            this.BuscarIDVenta.TabIndex = 26;
            this.BuscarIDVenta.Text = "folio";
            this.BuscarIDVenta.UseVisualStyleBackColor = true;
            this.BuscarIDVenta.Visible = false;
            this.BuscarIDVenta.Click += new System.EventHandler(this.BuscarIDVenta_Click);
            // 
            // tablaFolios
            // 
            this.tablaFolios.AllowUserToAddRows = false;
            this.tablaFolios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaFolios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaFolios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.tablaFolios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaFolios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tablaFolios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaFolios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaFolios.ColumnHeadersHeight = 60;
            this.tablaFolios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaFolios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column1,
            this.ID_Cliente});
            this.tablaFolios.Location = new System.Drawing.Point(24, 338);
            this.tablaFolios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaFolios.Name = "tablaFolios";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaFolios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaFolios.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.tablaFolios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaFolios.RowTemplate.Height = 24;
            this.tablaFolios.Size = new System.Drawing.Size(1323, 281);
            this.tablaFolios.TabIndex = 27;
            this.tablaFolios.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "FOLIO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "FECHA";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 121;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "IMPORTE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 145;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 76;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "TOTAL";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 118;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "METODO DE PAGO";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 171;
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_Cliente.HeaderText = "CLIENTE";
            this.ID_Cliente.MinimumWidth = 6;
            this.ID_Cliente.Name = "ID_Cliente";
            this.ID_Cliente.Width = 139;
            // 
            // BtnDashBoards
            // 
            this.BtnDashBoards.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashBoards.Location = new System.Drawing.Point(1159, 91);
            this.BtnDashBoards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDashBoards.Name = "BtnDashBoards";
            this.BtnDashBoards.Size = new System.Drawing.Size(159, 70);
            this.BtnDashBoards.TabIndex = 29;
            this.BtnDashBoards.Text = "DashBoard";
            this.BtnDashBoards.UseVisualStyleBackColor = true;
            this.BtnDashBoards.Click += new System.EventHandler(this.BtnDashBoards_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1404, 795);
            this.Controls.Add(this.BtnDashBoards);
            this.Controls.Add(this.tablaFolios);
            this.Controls.Add(this.BuscarIDVenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIDVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbmMetododePago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SUBTOTAL);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxIVA);
            this.Controls.Add(this.textBoxSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxProductos);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnRealizarVenta);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.BtnAgregarATabla);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.SubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaFolios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Button BtnAgregarATabla;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button BtnRealizarVenta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textBoxSubtotal;
        private System.Windows.Forms.Label textBoxIVA;
        private System.Windows.Forms.Label textBoxTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SUBTOTAL;
        private System.Windows.Forms.ContextMenuStrip SubMenu;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARPRODUCTOToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox CbmMetododePago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BuscarIDVenta;
        private System.Windows.Forms.DataGridView tablaFolios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.Button BtnDashBoards;
    }
}