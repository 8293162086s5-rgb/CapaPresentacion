namespace AppModeloCapas
{
    partial class FormCuentasCobrar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarDeuda = new System.Windows.Forms.Button();
            this.btnGuardarDeuda = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dtpFechaDeuda = new System.Windows.Forms.DateTimePicker();
            this.nudMontoAdeudado = new System.Windows.Forms.NumericUpDown();
            this.cmbCliente = new System.Windows.Forms.TextBox();
            this.dataGridViewDeudas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalirDeuda = new System.Windows.Forms.Button();
            this.btnEliminarDeuda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoAdeudado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeudas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto Adeudado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de deuda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.btnCancelarDeuda);
            this.groupBox1.Controls.Add(this.btnGuardarDeuda);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.dtpFechaDeuda);
            this.groupBox1.Controls.Add(this.nudMontoAdeudado);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 412);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar deuda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCancelarDeuda
            // 
            this.btnCancelarDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelarDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDeuda.Location = new System.Drawing.Point(19, 336);
            this.btnCancelarDeuda.Name = "btnCancelarDeuda";
            this.btnCancelarDeuda.Size = new System.Drawing.Size(116, 43);
            this.btnCancelarDeuda.TabIndex = 11;
            this.btnCancelarDeuda.Text = "Cancelar";
            this.btnCancelarDeuda.UseVisualStyleBackColor = false;
            this.btnCancelarDeuda.Click += new System.EventHandler(this.btnCancelarDeuda_Click);
            // 
            // btnGuardarDeuda
            // 
            this.btnGuardarDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardarDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDeuda.Location = new System.Drawing.Point(155, 336);
            this.btnGuardarDeuda.Name = "btnGuardarDeuda";
            this.btnGuardarDeuda.Size = new System.Drawing.Size(116, 43);
            this.btnGuardarDeuda.TabIndex = 10;
            this.btnGuardarDeuda.Text = "Guardar";
            this.btnGuardarDeuda.UseVisualStyleBackColor = false;
            this.btnGuardarDeuda.Click += new System.EventHandler(this.btnGuardarDeuda_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(127, 256);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(138, 28);
            this.cmbEstado.TabIndex = 7;
            // 
            // dtpFechaDeuda
            // 
            this.dtpFechaDeuda.Location = new System.Drawing.Point(181, 190);
            this.dtpFechaDeuda.Name = "dtpFechaDeuda";
            this.dtpFechaDeuda.Size = new System.Drawing.Size(84, 26);
            this.dtpFechaDeuda.TabIndex = 6;
            // 
            // nudMontoAdeudado
            // 
            this.nudMontoAdeudado.Location = new System.Drawing.Point(181, 112);
            this.nudMontoAdeudado.Name = "nudMontoAdeudado";
            this.nudMontoAdeudado.Size = new System.Drawing.Size(84, 26);
            this.nudMontoAdeudado.TabIndex = 5;
            // 
            // cmbCliente
            // 
            this.cmbCliente.Location = new System.Drawing.Point(109, 48);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(156, 26);
            this.cmbCliente.TabIndex = 4;
            // 
            // dataGridViewDeudas
            // 
            this.dataGridViewDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeudas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewDeudas.Location = new System.Drawing.Point(48, 20);
            this.dataGridViewDeudas.Name = "dataGridViewDeudas";
            this.dataGridViewDeudas.RowHeadersWidth = 62;
            this.dataGridViewDeudas.RowTemplate.Height = 28;
            this.dataGridViewDeudas.Size = new System.Drawing.Size(660, 330);
            this.dataGridViewDeudas.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cliente";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Monto Adeudado";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.btnSalirDeuda);
            this.groupBox2.Controls.Add(this.btnEliminarDeuda);
            this.groupBox2.Controls.Add(this.dataGridViewDeudas);
            this.groupBox2.Location = new System.Drawing.Point(301, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 412);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deudas pendientes";
            // 
            // btnSalirDeuda
            // 
            this.btnSalirDeuda.BackColor = System.Drawing.Color.Red;
            this.btnSalirDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirDeuda.Location = new System.Drawing.Point(592, 359);
            this.btnSalirDeuda.Name = "btnSalirDeuda";
            this.btnSalirDeuda.Size = new System.Drawing.Size(116, 43);
            this.btnSalirDeuda.TabIndex = 10;
            this.btnSalirDeuda.Text = "Salir";
            this.btnSalirDeuda.UseVisualStyleBackColor = false;
            this.btnSalirDeuda.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEliminarDeuda
            // 
            this.btnEliminarDeuda.BackColor = System.Drawing.Color.Red;
            this.btnEliminarDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDeuda.Location = new System.Drawing.Point(209, 359);
            this.btnEliminarDeuda.Name = "btnEliminarDeuda";
            this.btnEliminarDeuda.Size = new System.Drawing.Size(116, 43);
            this.btnEliminarDeuda.TabIndex = 9;
            this.btnEliminarDeuda.Text = "Eliminar";
            this.btnEliminarDeuda.UseVisualStyleBackColor = false;
            this.btnEliminarDeuda.Click += new System.EventHandler(this.btnEliminarDeuda_Click);
            // 
            // FormCuentasCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1134, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCuentasCobrar";
            this.Text = "FormCuentasCobrar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoAdeudado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeudas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaDeuda;
        private System.Windows.Forms.NumericUpDown nudMontoAdeudado;
        private System.Windows.Forms.TextBox cmbCliente;
        private System.Windows.Forms.DataGridView dataGridViewDeudas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnGuardarDeuda;
        private System.Windows.Forms.Button btnCancelarDeuda;
        private System.Windows.Forms.Button btnEliminarDeuda;
        private System.Windows.Forms.Button btnSalirDeuda;
    }
}