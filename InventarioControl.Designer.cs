namespace ProyectoParcial
{
    partial class InventarioControl
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
            label11 = new Label();
            label10 = new Label();
            txtCantidad = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            fecha = new DateTimePicker();
            txtUbicacion = new TextBox();
            cmbEstante = new ComboBox();
            cmbPasillo = new ComboBox();
            cmbMarca = new ComboBox();
            cmbCategoria = new ComboBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            lblAlertaStock = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            dgvInventario = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(fecha);
            panel1.Controls.Add(txtUbicacion);
            panel1.Controls.Add(cmbEstante);
            panel1.Controls.Add(cmbPasillo);
            panel1.Controls.Add(cmbMarca);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblAlertaStock);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(dgvInventario);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1406, 815);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label11
            // 
            label11.Location = new Point(19, 667);
            label11.Name = "label11";
            label11.Size = new Size(139, 25);
            label11.TabIndex = 39;
            label11.Text = "Fecha Vencimiento";
            // 
            // label10
            // 
            label10.Location = new Point(19, 334);
            label10.Name = "label10";
            label10.Size = new Size(121, 25);
            label10.TabIndex = 38;
            label10.Text = "Stock:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(146, 334);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(151, 27);
            txtCantidad.TabIndex = 37;
            // 
            // label9
            // 
            label9.Location = new Point(19, 611);
            label9.Name = "label9";
            label9.Size = new Size(121, 25);
            label9.TabIndex = 36;
            label9.Text = "Ubicación";
            // 
            // label8
            // 
            label8.Location = new Point(19, 561);
            label8.Name = "label8";
            label8.Size = new Size(121, 25);
            label8.TabIndex = 35;
            label8.Text = "Estante:";
            // 
            // label7
            // 
            label7.Location = new Point(19, 499);
            label7.Name = "label7";
            label7.Size = new Size(121, 25);
            label7.TabIndex = 34;
            label7.Text = "Pasillo:";
            // 
            // label6
            // 
            label6.Location = new Point(19, 442);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 33;
            label6.Text = "Marca:";
            // 
            // label5
            // 
            label5.Location = new Point(19, 388);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 32;
            label5.Text = "Categoría:";
            // 
            // label4
            // 
            label4.Location = new Point(19, 280);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 31;
            label4.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.Location = new Point(19, 220);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 30;
            label3.Text = "CÓDIGO:";
            // 
            // label1
            // 
            label1.Location = new Point(19, 164);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 29;
            label1.Text = "ID:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(468, 146);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(368, 148);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 27;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // fecha
            // 
            fecha.Location = new Point(94, 695);
            fecha.Name = "fecha";
            fecha.Size = new Size(250, 27);
            fecha.TabIndex = 26;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(146, 608);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(151, 27);
            txtUbicacion.TabIndex = 25;
            // 
            // cmbEstante
            // 
            cmbEstante.FormattingEnabled = true;
            cmbEstante.Location = new Point(146, 558);
            cmbEstante.Name = "cmbEstante";
            cmbEstante.Size = new Size(151, 28);
            cmbEstante.TabIndex = 24;
            // 
            // cmbPasillo
            // 
            cmbPasillo.FormattingEnabled = true;
            cmbPasillo.Location = new Point(146, 496);
            cmbPasillo.Name = "cmbPasillo";
            cmbPasillo.Size = new Size(151, 28);
            cmbPasillo.TabIndex = 23;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(146, 439);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(151, 28);
            cmbMarca.TabIndex = 22;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(146, 385);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(146, 280);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 20;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(146, 217);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(151, 27);
            txtCodigo.TabIndex = 19;
            // 
            // txtId
            // 
            txtId.Location = new Point(146, 164);
            txtId.Name = "txtId";
            txtId.Size = new Size(151, 27);
            txtId.TabIndex = 18;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 43);
            label2.Name = "label2";
            label2.Size = new Size(364, 42);
            label2.TabIndex = 17;
            label2.Text = "GESTIÓN DE INVENTARIO";
            // 
            // lblAlertaStock
            // 
            lblAlertaStock.Location = new Point(934, 150);
            lblAlertaStock.Name = "lblAlertaStock";
            lblAlertaStock.Size = new Size(428, 25);
            lblAlertaStock.TabIndex = 3;
            lblAlertaStock.Click += lblAlertaStock_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(788, 150);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(618, 150);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(164, 27);
            txtBuscar.TabIndex = 1;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(368, 213);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(994, 509);
            dgvInventario.TabIndex = 0;
            dgvInventario.SelectionChanged += dgvInventario_SelectionChanged;
            // 
            // InventarioControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "InventarioControl";
            Size = new Size(1406, 815);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblAlertaStock;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvInventario;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private TextBox txtId;
        private ComboBox cmbEstante;
        private ComboBox cmbPasillo;
        private ComboBox cmbMarca;
        private ComboBox cmbCategoria;
        private TextBox txtUbicacion;
        private DateTimePicker fecha;
        private Button btnEliminar;
        private Button btnModificar;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label10;
        private TextBox txtCantidad;
        private Label label11;
    }
}
