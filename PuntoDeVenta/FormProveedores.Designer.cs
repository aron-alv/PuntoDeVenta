namespace ABARROTES
{
    partial class FormProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.IDProveedor = new System.Windows.Forms.TextBox();
            this.DireccionProveedor = new System.Windows.Forms.TextBox();
            this.NumTelefono = new System.Windows.Forms.TextBox();
            this.NombreProveedor = new System.Windows.Forms.TextBox();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.BtnEliminarProveedores = new System.Windows.Forms.Button();
            this.txtBuscarProveedores = new System.Windows.Forms.TextBox();
            this.TablaProveedores = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(437, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROVEEDORES";
            // 
            // IDProveedor
            // 
            this.IDProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IDProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDProveedor.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProveedor.ForeColor = System.Drawing.Color.White;
            this.IDProveedor.Location = new System.Drawing.Point(65, 101);
            this.IDProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDProveedor.Multiline = true;
            this.IDProveedor.Name = "IDProveedor";
            this.IDProveedor.Size = new System.Drawing.Size(221, 61);
            this.IDProveedor.TabIndex = 9;
            // 
            // DireccionProveedor
            // 
            this.DireccionProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DireccionProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DireccionProveedor.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionProveedor.ForeColor = System.Drawing.Color.White;
            this.DireccionProveedor.Location = new System.Drawing.Point(65, 466);
            this.DireccionProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DireccionProveedor.Multiline = true;
            this.DireccionProveedor.Name = "DireccionProveedor";
            this.DireccionProveedor.Size = new System.Drawing.Size(221, 61);
            this.DireccionProveedor.TabIndex = 8;
            // 
            // NumTelefono
            // 
            this.NumTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NumTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumTelefono.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTelefono.ForeColor = System.Drawing.Color.White;
            this.NumTelefono.Location = new System.Drawing.Point(65, 343);
            this.NumTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumTelefono.Multiline = true;
            this.NumTelefono.Name = "NumTelefono";
            this.NumTelefono.Size = new System.Drawing.Size(221, 61);
            this.NumTelefono.TabIndex = 7;
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreProveedor.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProveedor.ForeColor = System.Drawing.Color.White;
            this.NombreProveedor.Location = new System.Drawing.Point(65, 230);
            this.NombreProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombreProveedor.Multiline = true;
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.Size = new System.Drawing.Size(221, 61);
            this.NombreProveedor.TabIndex = 6;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(53, 601);
            this.BtnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(131, 103);
            this.BtnAgregarProducto.TabIndex = 10;
            this.BtnAgregarProducto.Text = "AGREGAR O MODIFICAR";
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // BtnEliminarProveedores
            // 
            this.BtnEliminarProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnEliminarProveedores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProveedores.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarProveedores.Location = new System.Drawing.Point(389, 618);
            this.BtnEliminarProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarProveedores.Name = "BtnEliminarProveedores";
            this.BtnEliminarProveedores.Size = new System.Drawing.Size(221, 68);
            this.BtnEliminarProveedores.TabIndex = 11;
            this.BtnEliminarProveedores.Text = "ELIMINAR";
            this.BtnEliminarProveedores.UseVisualStyleBackColor = false;
            this.BtnEliminarProveedores.Click += new System.EventHandler(this.BtnEliminarProveedores_Click);
            // 
            // txtBuscarProveedores
            // 
            this.txtBuscarProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBuscarProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProveedores.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProveedores.ForeColor = System.Drawing.Color.White;
            this.txtBuscarProveedores.Location = new System.Drawing.Point(641, 116);
            this.txtBuscarProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarProveedores.Multiline = true;
            this.txtBuscarProveedores.Name = "txtBuscarProveedores";
            this.txtBuscarProveedores.Size = new System.Drawing.Size(317, 46);
            this.txtBuscarProveedores.TabIndex = 19;
            this.txtBuscarProveedores.Text = "BUSCAR PROVEEDORES";
            this.txtBuscarProveedores.TextChanged += new System.EventHandler(this.txtBuscarProveedores_TextChanged);
            this.txtBuscarProveedores.Enter += new System.EventHandler(this.txtBuscarProveedores_Enter);
            this.txtBuscarProveedores.Leave += new System.EventHandler(this.txtBuscarProveedores_Leave);
            // 
            // TablaProveedores
            // 
            this.TablaProveedores.AllowDrop = true;
            this.TablaProveedores.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablaProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.TablaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtNombre,
            this.txtTelefono,
            this.txtDireccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaProveedores.Location = new System.Drawing.Point(445, 183);
            this.TablaProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TablaProveedores.MultiSelect = false;
            this.TablaProveedores.Name = "TablaProveedores";
            this.TablaProveedores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaProveedores.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.TablaProveedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaProveedores.RowTemplate.Height = 24;
            this.TablaProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaProveedores.Size = new System.Drawing.Size(681, 357);
            this.TablaProveedores.TabIndex = 18;
            this.TablaProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaProveedores_CellClick);
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
            // txtTelefono
            // 
            this.txtTelefono.HeaderText = "Telefono";
            this.txtTelefono.MinimumWidth = 6;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.HeaderText = "Direccion";
            this.txtDireccion.MinimumWidth = 6;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(70, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(70, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "DIRECCION";
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1253, 764);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBuscarProveedores);
            this.Controls.Add(this.TablaProveedores);
            this.Controls.Add(this.BtnEliminarProveedores);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.IDProveedor);
            this.Controls.Add(this.DireccionProveedor);
            this.Controls.Add(this.NumTelefono);
            this.Controls.Add(this.NombreProveedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProveedores";
            this.Text = "FormProveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            this.Click += new System.EventHandler(this.FormProveedores_Click);
            ((System.ComponentModel.ISupportInitialize)(this.TablaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDProveedor;
        private System.Windows.Forms.TextBox DireccionProveedor;
        private System.Windows.Forms.TextBox NumTelefono;
        private System.Windows.Forms.TextBox NombreProveedor;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button BtnEliminarProveedores;
        private System.Windows.Forms.TextBox txtBuscarProveedores;
        private System.Windows.Forms.DataGridView TablaProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}