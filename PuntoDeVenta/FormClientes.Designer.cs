namespace ABARROTES
{
    partial class FormClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDCliente = new System.Windows.Forms.TextBox();
            this.DireccionCliente = new System.Windows.Forms.TextBox();
            this.NumTelefono = new System.Windows.Forms.TextBox();
            this.NombreCliente = new System.Windows.Forms.TextBox();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            this.TablaClientes = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.txtBuscarCliebte = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLIENTES";
            // 
            // IDCliente
            // 
            this.IDCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IDCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDCliente.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCliente.ForeColor = System.Drawing.Color.White;
            this.IDCliente.Location = new System.Drawing.Point(69, 127);
            this.IDCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDCliente.Multiline = true;
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.ReadOnly = true;
            this.IDCliente.Size = new System.Drawing.Size(221, 54);
            this.IDCliente.TabIndex = 13;
            // 
            // DireccionCliente
            // 
            this.DireccionCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DireccionCliente.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionCliente.ForeColor = System.Drawing.Color.White;
            this.DireccionCliente.Location = new System.Drawing.Point(69, 422);
            this.DireccionCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DireccionCliente.Multiline = true;
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.Size = new System.Drawing.Size(221, 54);
            this.DireccionCliente.TabIndex = 12;
            // 
            // NumTelefono
            // 
            this.NumTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NumTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumTelefono.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTelefono.ForeColor = System.Drawing.Color.White;
            this.NumTelefono.Location = new System.Drawing.Point(69, 321);
            this.NumTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumTelefono.Multiline = true;
            this.NumTelefono.Name = "NumTelefono";
            this.NumTelefono.Size = new System.Drawing.Size(221, 54);
            this.NumTelefono.TabIndex = 11;
            // 
            // NombreCliente
            // 
            this.NombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreCliente.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCliente.ForeColor = System.Drawing.Color.White;
            this.NombreCliente.Location = new System.Drawing.Point(69, 217);
            this.NombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombreCliente.Multiline = true;
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(221, 54);
            this.NombreCliente.TabIndex = 10;
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAgregarCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarCliente.Location = new System.Drawing.Point(109, 546);
            this.BtnAgregarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(137, 98);
            this.BtnAgregarCliente.TabIndex = 14;
            this.BtnAgregarCliente.Text = "AGREGAR O MODIFICAR";
            this.BtnAgregarCliente.UseVisualStyleBackColor = false;
            this.BtnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarCliente_Click);
            // 
            // TablaClientes
            // 
            this.TablaClientes.AllowDrop = true;
            this.TablaClientes.AllowUserToAddRows = false;
            this.TablaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.TablaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtNombre,
            this.txtTelefono,
            this.txtDireccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaClientes.Location = new System.Drawing.Point(522, 127);
            this.TablaClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TablaClientes.MultiSelect = false;
            this.TablaClientes.Name = "TablaClientes";
            this.TablaClientes.ReadOnly = true;
            this.TablaClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TablaClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.TablaClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.TablaClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaClientes.RowTemplate.Height = 24;
            this.TablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaClientes.Size = new System.Drawing.Size(788, 363);
            this.TablaClientes.TabIndex = 15;
            this.TablaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaClientes_CellClick);
            this.TablaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaClientes_CellContentClick);
            // 
            // txtID
            // 
            this.txtID.HeaderText = "ID";
            this.txtID.MinimumWidth = 6;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Visible = false;
            this.txtID.Width = 43;
            // 
            // txtNombre
            // 
            this.txtNombre.HeaderText = "Nombre";
            this.txtNombre.MinimumWidth = 6;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Width = 87;
            // 
            // txtTelefono
            // 
            this.txtTelefono.HeaderText = "Telefono";
            this.txtTelefono.MinimumWidth = 6;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Width = 93;
            // 
            // txtDireccion
            // 
            this.txtDireccion.HeaderText = "Direccion";
            this.txtDireccion.MinimumWidth = 6;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Width = 96;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(376, 546);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(221, 80);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // txtBuscarCliebte
            // 
            this.txtBuscarCliebte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBuscarCliebte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCliebte.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliebte.ForeColor = System.Drawing.Color.White;
            this.txtBuscarCliebte.Location = new System.Drawing.Point(627, 44);
            this.txtBuscarCliebte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCliebte.Multiline = true;
            this.txtBuscarCliebte.Name = "txtBuscarCliebte";
            this.txtBuscarCliebte.Size = new System.Drawing.Size(250, 46);
            this.txtBuscarCliebte.TabIndex = 17;
            this.txtBuscarCliebte.Text = "BUSCAR CLIENTE";
            this.txtBuscarCliebte.TextChanged += new System.EventHandler(this.txtBuscarCliebte_TextChanged);
            this.txtBuscarCliebte.Leave += new System.EventHandler(this.txtBuscarCliebte_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(75, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(75, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "DIRECCION";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1241, 756);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBuscarCliebte);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TablaClientes);
            this.Controls.Add(this.BtnAgregarCliente);
            this.Controls.Add(this.IDCliente);
            this.Controls.Add(this.DireccionCliente);
            this.Controls.Add(this.NumTelefono);
            this.Controls.Add(this.NombreCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.Click += new System.EventHandler(this.FormClientes_Click);
            ((System.ComponentModel.ISupportInitialize)(this.TablaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDCliente;
        private System.Windows.Forms.TextBox DireccionCliente;
        private System.Windows.Forms.TextBox NumTelefono;
        private System.Windows.Forms.TextBox NombreCliente;
        private System.Windows.Forms.Button BtnAgregarCliente;
        private System.Windows.Forms.DataGridView TablaClientes;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox txtBuscarCliebte;
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