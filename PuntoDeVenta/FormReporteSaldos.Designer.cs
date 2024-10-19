namespace ABARROTES
{
    partial class FormReporteSaldos
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
            this.tablaSaldos = new System.Windows.Forms.DataGridView();
            this.ID_Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Entrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSaldos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(479, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = " SALDO";
            // 
            // tablaSaldos
            // 
            this.tablaSaldos.AllowUserToAddRows = false;
            this.tablaSaldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaSaldos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaSaldos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSaldos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Saldo,
            this.ID_Producto,
            this.Cantidad_Entrante,
            this.Cantidad_Salida,
            this.Cantidad_Disponible});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaSaldos.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaSaldos.Location = new System.Drawing.Point(88, 136);
            this.tablaSaldos.Name = "tablaSaldos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaSaldos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaSaldos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.tablaSaldos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaSaldos.RowTemplate.Height = 24;
            this.tablaSaldos.Size = new System.Drawing.Size(889, 362);
            this.tablaSaldos.TabIndex = 17;
            // 
            // ID_Saldo
            // 
            this.ID_Saldo.HeaderText = "ID";
            this.ID_Saldo.MinimumWidth = 6;
            this.ID_Saldo.Name = "ID_Saldo";
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "Producto";
            this.ID_Producto.MinimumWidth = 6;
            this.ID_Producto.Name = "ID_Producto";
            // 
            // Cantidad_Entrante
            // 
            this.Cantidad_Entrante.HeaderText = "Cantidad Entrante";
            this.Cantidad_Entrante.MinimumWidth = 6;
            this.Cantidad_Entrante.Name = "Cantidad_Entrante";
            // 
            // Cantidad_Salida
            // 
            this.Cantidad_Salida.HeaderText = "Cantidad Salida";
            this.Cantidad_Salida.MinimumWidth = 6;
            this.Cantidad_Salida.Name = "Cantidad_Salida";
            // 
            // Cantidad_Disponible
            // 
            this.Cantidad_Disponible.HeaderText = "Cantidad Disponible";
            this.Cantidad_Disponible.MinimumWidth = 6;
            this.Cantidad_Disponible.Name = "Cantidad_Disponible";
            // 
            // FormReporteSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1048, 774);
            this.Controls.Add(this.tablaSaldos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteSaldos";
            this.Text = "FormReporteSaldos";
            this.Load += new System.EventHandler(this.FormReporteSaldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSaldos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaSaldos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Entrante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Disponible;
    }
}