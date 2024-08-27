namespace ProyectoParcial
{
    partial class EmpleadoGestion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            txtBuscar = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEliminarEmpleado = new Button();
            btnModificarEmpleado = new Button();
            btnAgregarEmpleado = new Button();
            cmbCargo = new ComboBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            txtCodigo = new TextBox();
            dgvEmpleados = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEliminarEmpleado);
            panel1.Controls.Add(btnModificarEmpleado);
            panel1.Controls.Add(btnAgregarEmpleado);
            panel1.Controls.Add(cmbCargo);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtApellidos);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(dgvEmpleados);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1623, 703);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(37, 65);
            label9.Name = "label9";
            label9.Size = new Size(378, 42);
            label9.TabIndex = 29;
            label9.Text = "GESTIÓN DE EMPLEADOS";
            // 
            // label8
            // 
            label8.Location = new Point(1025, 211);
            label8.Name = "label8";
            label8.Size = new Size(103, 27);
            label8.TabIndex = 28;
            label8.Text = "BUSCAR POR: ";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(1158, 211);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(425, 27);
            txtBuscar.TabIndex = 27;
            txtBuscar.TextChanged += txtBuscar_TextChanged_1;
            // 
            // label7
            // 
            label7.Location = new Point(37, 517);
            label7.Name = "label7";
            label7.Size = new Size(103, 27);
            label7.TabIndex = 26;
            label7.Text = "TELÉFONO";
            // 
            // label6
            // 
            label6.Location = new Point(37, 569);
            label6.Name = "label6";
            label6.Size = new Size(103, 27);
            label6.TabIndex = 25;
            label6.Text = "DIRRECION";
            // 
            // label5
            // 
            label5.Location = new Point(37, 459);
            label5.Name = "label5";
            label5.Size = new Size(103, 27);
            label5.TabIndex = 24;
            label5.Text = "CORREO";
            // 
            // label4
            // 
            label4.Location = new Point(37, 403);
            label4.Name = "label4";
            label4.Size = new Size(103, 27);
            label4.TabIndex = 23;
            label4.Text = "CARGO";
            // 
            // label3
            // 
            label3.Location = new Point(37, 350);
            label3.Name = "label3";
            label3.Size = new Size(103, 27);
            label3.TabIndex = 22;
            label3.Text = "APELLIDOS";
            // 
            // label2
            // 
            label2.Location = new Point(37, 297);
            label2.Name = "label2";
            label2.Size = new Size(103, 27);
            label2.TabIndex = 21;
            label2.Text = "NOMBRES";
            // 
            // label1
            // 
            label1.Location = new Point(37, 244);
            label1.Name = "label1";
            label1.Size = new Size(103, 27);
            label1.TabIndex = 20;
            label1.Text = "CÓDIGO";
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Location = new Point(723, 209);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(94, 29);
            btnEliminarEmpleado.TabIndex = 10;
            btnEliminarEmpleado.Text = "Eliminar";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // btnModificarEmpleado
            // 
            btnModificarEmpleado.Location = new Point(585, 209);
            btnModificarEmpleado.Name = "btnModificarEmpleado";
            btnModificarEmpleado.Size = new Size(94, 29);
            btnModificarEmpleado.TabIndex = 9;
            btnModificarEmpleado.Text = "Modificar";
            btnModificarEmpleado.UseVisualStyleBackColor = true;
            btnModificarEmpleado.Click += btnModificarEmpleado_Click;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(457, 209);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(94, 29);
            btnAgregarEmpleado.TabIndex = 8;
            btnAgregarEmpleado.Text = "Agregar";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(170, 403);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(125, 28);
            cmbCargo.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(170, 517);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(170, 566);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(240, 27);
            txtDireccion.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(170, 459);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(240, 27);
            txtCorreo.TabIndex = 4;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(170, 347);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(240, 27);
            txtApellidos.TabIndex = 3;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(170, 294);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(240, 27);
            txtNombres.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(170, 244);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 1;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(457, 262);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(1126, 331);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged_1;
            // 
            // EmpleadoGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "EmpleadoGestion";
            Size = new Size(1623, 703);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvEmpleados;
        private ComboBox cmbCargo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private TextBox txtCodigo;
        private Button btnEliminarEmpleado;
        private Button btnModificarEmpleado;
        private Button btnAgregarEmpleado;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private TextBox txtBuscar;
        private Label label9;
    }
}
