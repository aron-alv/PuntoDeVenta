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
            this.label1 = new System.Windows.Forms.Label();
            this.IDCliente = new System.Windows.Forms.TextBox();
            this.DireccionCliente = new System.Windows.Forms.TextBox();
            this.NumTelefono = new System.Windows.Forms.TextBox();
            this.NombreCliente = new System.Windows.Forms.TextBox();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            this.TablaClientes = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.txtBuscarCliebte = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.IDCliente.Location = new System.Drawing.Point(69, 103);
            this.IDCliente.Multiline = true;
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.Size = new System.Drawing.Size(221, 34);
            this.IDCliente.TabIndex = 13;
            this.IDCliente.Text = "ID";
            
            // 
            // DireccionCliente
            // 
            this.DireccionCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DireccionCliente.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionCliente.ForeColor = System.Drawing.Color.White;
            this.DireccionCliente.Location = new System.Drawing.Point(69, 318);
            this.DireccionCliente.Multiline = true;
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.Size = new System.Drawing.Size(221, 34);
            this.DireccionCliente.TabIndex = 12;
            this.DireccionCliente.Text = "DIRECCION";
            this.DireccionCliente.Enter += new System.EventHandler(this.DireccionCliente_Enter);
            this.DireccionCliente.Leave += new System.EventHandler(this.DireccionCliente_Leave);
            // 
            // NumTelefono
            // 
            this.NumTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NumTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumTelefono.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTelefono.ForeColor = System.Drawing.Color.White;
            this.NumTelefono.Location = new System.Drawing.Point(69, 241);
            this.NumTelefono.Multiline = true;
            this.NumTelefono.Name = "NumTelefono";
            this.NumTelefono.Size = new System.Drawing.Size(221, 34);
            this.NumTelefono.TabIndex = 11;
            this.NumTelefono.Text = "TELEFONO";
            this.NumTelefono.Enter += new System.EventHandler(this.NumTelefono_Enter);
            this.NumTelefono.Leave += new System.EventHandler(this.NumTelefono_Leave);
            // 
            // NombreCliente
            // 
            this.NombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreCliente.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCliente.ForeColor = System.Drawing.Color.White;
            this.NombreCliente.Location = new System.Drawing.Point(69, 164);
            this.NombreCliente.Multiline = true;
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(221, 34);
            this.NombreCliente.TabIndex = 10;
            this.NombreCliente.Text = "NOMBRE";
            this.NombreCliente.Enter += new System.EventHandler(this.NombreCliente_Enter);
            this.NombreCliente.Leave += new System.EventHandler(this.NombreCliente_Leave);
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAgregarCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarCliente.Location = new System.Drawing.Point(109, 546);
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
            this.TablaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtNombre,
            this.txtTelefono,
            this.txtDireccion});
            this.TablaClientes.Location = new System.Drawing.Point(441, 127);
            this.TablaClientes.MultiSelect = false;
            this.TablaClientes.Name = "TablaClientes";
            this.TablaClientes.ReadOnly = true;
            this.TablaClientes.RowHeadersWidth = 51;
            this.TablaClientes.RowTemplate.Height = 24;
            this.TablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaClientes.Size = new System.Drawing.Size(681, 363);
            this.TablaClientes.TabIndex = 15;
            this.TablaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaClientes_CellClick);
            this.TablaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaClientes_CellContentClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(425, 561);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(221, 68);
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
            this.txtBuscarCliebte.Multiline = true;
            this.txtBuscarCliebte.Name = "txtBuscarCliebte";
            this.txtBuscarCliebte.Size = new System.Drawing.Size(250, 46);
            this.txtBuscarCliebte.TabIndex = 17;
            this.txtBuscarCliebte.Text = "BUSCAR CLIENTE";
            this.txtBuscarCliebte.TextChanged += new System.EventHandler(this.txtBuscarCliebte_TextChanged);
            this.txtBuscarCliebte.Enter += new System.EventHandler(this.txtBuscarCliebte_Enter);
            this.txtBuscarCliebte.Leave += new System.EventHandler(this.txtBuscarCliebte_Leave);
            // 
            // txtID
            // 
            this.txtID.HeaderText = "ID";
            this.txtID.MinimumWidth = 6;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
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
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1236, 756);
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
    }
}