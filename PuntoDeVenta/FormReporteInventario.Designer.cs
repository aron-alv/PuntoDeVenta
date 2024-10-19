namespace ABARROTES
{
    partial class FormReporteInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewInventario = new System.Windows.Forms.DataGridView();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.IDProveedor = new System.Windows.Forms.ComboBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.checkBoxFechaInicio = new System.Windows.Forms.CheckBox();
            this.checkBoxFechaFin = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "REPORTE INVENTARIO";
            // 
            // dataGridViewInventario
            // 
            this.dataGridViewInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.dataGridViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInventario.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewInventario.Location = new System.Drawing.Point(137, 329);
            this.dataGridViewInventario.Name = "dataGridViewInventario";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dataGridViewInventario.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewInventario.RowTemplate.Height = 24;
            this.dataGridViewInventario.Size = new System.Drawing.Size(1151, 426);
            this.dataGridViewInventario.TabIndex = 3;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(219, 136);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerInicio.TabIndex = 4;
            // 
            // IDProveedor
            // 
            this.IDProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IDProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.IDProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IDProveedor.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProveedor.ForeColor = System.Drawing.Color.White;
            this.IDProveedor.FormattingEnabled = true;
            this.IDProveedor.Location = new System.Drawing.Point(204, 203);
            this.IDProveedor.Name = "IDProveedor";
            this.IDProveedor.Size = new System.Drawing.Size(230, 35);
            this.IDProveedor.TabIndex = 8;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(288, 270);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 9;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // checkBoxFechaInicio
            // 
            this.checkBoxFechaInicio.AutoSize = true;
            this.checkBoxFechaInicio.Location = new System.Drawing.Point(181, 140);
            this.checkBoxFechaInicio.Name = "checkBoxFechaInicio";
            this.checkBoxFechaInicio.Size = new System.Drawing.Size(32, 20);
            this.checkBoxFechaInicio.TabIndex = 10;
            this.checkBoxFechaInicio.Text = " ";
            this.checkBoxFechaInicio.UseVisualStyleBackColor = true;
            // 
            // checkBoxFechaFin
            // 
            this.checkBoxFechaFin.AutoSize = true;
            this.checkBoxFechaFin.Location = new System.Drawing.Point(843, 144);
            this.checkBoxFechaFin.Name = "checkBoxFechaFin";
            this.checkBoxFechaFin.Size = new System.Drawing.Size(32, 20);
            this.checkBoxFechaFin.TabIndex = 12;
            this.checkBoxFechaFin.Text = " ";
            this.checkBoxFechaFin.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(622, 140);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFin.TabIndex = 11;
            // 
            // FormReporteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1647, 798);
            this.Controls.Add(this.checkBoxFechaFin);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.checkBoxFechaInicio);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.IDProveedor);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.dataGridViewInventario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteInventario";
            this.Text = "FormReporteInventario";
            this.Load += new System.EventHandler(this.FormReporteInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewInventario;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.ComboBox IDProveedor;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.CheckBox checkBoxFechaInicio;
        private System.Windows.Forms.CheckBox checkBoxFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
    }
}