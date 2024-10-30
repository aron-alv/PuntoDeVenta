namespace ABARROTES
{
    partial class FormProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDProducto = new System.Windows.Forms.TextBox();
            this.NombreProducto = new System.Windows.Forms.TextBox();
            this.DescripcionProducto = new System.Windows.Forms.TextBox();
            this.PrecioProducto = new System.Windows.Forms.TextBox();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.IDProveedor = new System.Windows.Forms.ComboBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.TablaProductos = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTOS";
            // 
            // IDProducto
            // 
            this.IDProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IDProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDProducto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProducto.ForeColor = System.Drawing.Color.White;
            this.IDProducto.Location = new System.Drawing.Point(100, 131);
            this.IDProducto.Multiline = true;
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.Size = new System.Drawing.Size(221, 61);
            this.IDProducto.TabIndex = 1;
            this.IDProducto.Text = "ID";
            this.IDProducto.Click += new System.EventHandler(this.IDProducto_Click);
            this.IDProducto.Leave += new System.EventHandler(this.IDProducto_Leave);
            // 
            // NombreProducto
            // 
            this.NombreProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreProducto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProducto.ForeColor = System.Drawing.Color.White;
            this.NombreProducto.Location = new System.Drawing.Point(100, 238);
            this.NombreProducto.Multiline = true;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Size = new System.Drawing.Size(221, 61);
            this.NombreProducto.TabIndex = 2;
            this.NombreProducto.Text = "NOMBRE";
            this.NombreProducto.Enter += new System.EventHandler(this.NombreProducto_Enter);
            this.NombreProducto.Leave += new System.EventHandler(this.NombreProducto_Leave);
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DescripcionProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescripcionProducto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionProducto.ForeColor = System.Drawing.Color.White;
            this.DescripcionProducto.Location = new System.Drawing.Point(100, 441);
            this.DescripcionProducto.Multiline = true;
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.Size = new System.Drawing.Size(221, 98);
            this.DescripcionProducto.TabIndex = 4;
            this.DescripcionProducto.Text = "DESCRIPCION";
            this.DescripcionProducto.Enter += new System.EventHandler(this.DescripcionProducto_Enter);
            this.DescripcionProducto.Leave += new System.EventHandler(this.DescripcionProducto_Leave);
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PrecioProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrecioProducto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioProducto.ForeColor = System.Drawing.Color.White;
            this.PrecioProducto.Location = new System.Drawing.Point(100, 349);
            this.PrecioProducto.Multiline = true;
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.Size = new System.Drawing.Size(221, 61);
            this.PrecioProducto.TabIndex = 3;
            this.PrecioProducto.Text = "PRECIO";
            this.PrecioProducto.Enter += new System.EventHandler(this.PrecioProducto_Enter);
            this.PrecioProducto.Leave += new System.EventHandler(this.PrecioProducto_Leave);
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(113, 647);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(180, 84);
            this.BtnAgregarProducto.TabIndex = 6;
            this.BtnAgregarProducto.Text = "     AGREGAR            O       MODIFICAR";
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // IDProveedor
            // 
            this.IDProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IDProveedor.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProveedor.ForeColor = System.Drawing.Color.White;
            this.IDProveedor.FormattingEnabled = true;
            this.IDProveedor.Location = new System.Drawing.Point(100, 566);
            this.IDProveedor.Name = "IDProveedor";
            this.IDProveedor.Size = new System.Drawing.Size(230, 35);
            this.IDProveedor.TabIndex = 7;
            this.IDProveedor.Enter += new System.EventHandler(this.IDProveedor_Enter_1);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProducto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.txtBuscarProducto.Location = new System.Drawing.Point(689, 131);
            this.txtBuscarProducto.Multiline = true;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(244, 46);
            this.txtBuscarProducto.TabIndex = 22;
            this.txtBuscarProducto.Text = "BUSCAR";
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            this.txtBuscarProducto.Enter += new System.EventHandler(this.txtBuscarProducto_Enter);
            this.txtBuscarProducto.Leave += new System.EventHandler(this.txtBuscarProducto_Leave);
            // 
            // TablaProductos
            // 
            this.TablaProductos.AllowDrop = true;
            this.TablaProductos.AllowUserToAddRows = false;
            this.TablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtNombre,
            this.txtPrecio,
            this.txtDescripcion,
            this.txtProveedor});
            this.TablaProductos.Location = new System.Drawing.Point(494, 198);
            this.TablaProductos.MultiSelect = false;
            this.TablaProductos.Name = "TablaProductos";
            this.TablaProductos.ReadOnly = true;
            this.TablaProductos.RowHeadersWidth = 51;
            this.TablaProductos.RowTemplate.Height = 24;
            this.TablaProductos.Size = new System.Drawing.Size(721, 357);
            this.TablaProductos.TabIndex = 21;
            this.TablaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaProductos_CellClick);
            // 
            // txtID
            // 
            this.txtID.HeaderText = "ID";
            this.txtID.MinimumWidth = 6;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.HeaderText = "Nombre";
            this.txtNombre.MinimumWidth = 6;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.HeaderText = "Precio";
            this.txtPrecio.MinimumWidth = 6;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.HeaderText = "Descripcion";
            this.txtDescripcion.MinimumWidth = 6;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            // 
            // txtProveedor
            // 
            this.txtProveedor.HeaderText = "Proveedor";
            this.txtProveedor.MinimumWidth = 6;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnEliminarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarProducto.Location = new System.Drawing.Point(458, 623);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(221, 68);
            this.BtnEliminarProducto.TabIndex = 20;
            this.BtnEliminarProducto.Text = "ELIMINAR";
            this.BtnEliminarProducto.UseVisualStyleBackColor = false;
            this.BtnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1471, 799);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.TablaProductos);
            this.Controls.Add(this.BtnEliminarProducto);
            this.Controls.Add(this.IDProveedor);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.DescripcionProducto);
            this.Controls.Add(this.PrecioProducto);
            this.Controls.Add(this.NombreProducto);
            this.Controls.Add(this.IDProducto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.Click += new System.EventHandler(this.FormProductos_Click);
            this.Enter += new System.EventHandler(this.FormProductos_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDProducto;
        private System.Windows.Forms.TextBox NombreProducto;
        private System.Windows.Forms.TextBox DescripcionProducto;
        private System.Windows.Forms.TextBox PrecioProducto;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.ComboBox IDProveedor;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.DataGridView TablaProductos;
        private System.Windows.Forms.Button BtnEliminarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProveedor;
    }
}