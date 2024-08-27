namespace ProyectoParcial
{
    partial class PlanillaGestion
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
            btnConfirmar = new Button();
            btnQuitar = new Button();
            label2 = new Label();
            btnAgregarPlanilla = new Button();
            dgvPlanillas = new DataGridView();
            dgvEmpleados = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlanillas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(btnQuitar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAgregarPlanilla);
            panel1.Controls.Add(dgvPlanillas);
            panel1.Controls.Add(dgvEmpleados);
            panel1.Location = new Point(0, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(1795, 632);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(650, 417);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 29;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(650, 349);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(94, 29);
            btnQuitar.TabIndex = 28;
            btnQuitar.Text = "Eliminar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(662, 68);
            label2.Name = "label2";
            label2.Size = new Size(339, 42);
            label2.TabIndex = 27;
            label2.Text = "GESTIÓN DE PLANILLAS";
            // 
            // btnAgregarPlanilla
            // 
            btnAgregarPlanilla.Location = new Point(650, 286);
            btnAgregarPlanilla.Name = "btnAgregarPlanilla";
            btnAgregarPlanilla.Size = new Size(94, 29);
            btnAgregarPlanilla.TabIndex = 2;
            btnAgregarPlanilla.Text = "Agregar";
            btnAgregarPlanilla.UseVisualStyleBackColor = true;
            btnAgregarPlanilla.Click += btnAgregarPlanilla_Click_1;
            // 
            // dgvPlanillas
            // 
            dgvPlanillas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanillas.Location = new Point(762, 200);
            dgvPlanillas.Name = "dgvPlanillas";
            dgvPlanillas.RowHeadersWidth = 51;
            dgvPlanillas.Size = new Size(995, 366);
            dgvPlanillas.TabIndex = 1;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(49, 200);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(582, 366);
            dgvEmpleados.TabIndex = 0;
            // 
            // PlanillaGestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "PlanillaGestion";
            Size = new Size(1795, 702);
            Load += PlanillaGestion_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPlanillas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvEmpleados;
        private DataGridView dgvPlanillas;
        private Button btnAgregarPlanilla;
        private Label label2;
        private Button btnConfirmar;
        private Button btnQuitar;
    }
}
