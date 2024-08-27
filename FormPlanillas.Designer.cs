namespace ProyectoParcial
{
    partial class FormPlanillas
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
            txtSalarioBase = new TextBox();
            txtHorasExtras = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblEmpleado = new Label();
            txtDeduccionesExtras = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtSalarioBase
            // 
            txtSalarioBase.Location = new Point(198, 110);
            txtSalarioBase.Name = "txtSalarioBase";
            txtSalarioBase.Size = new Size(154, 27);
            txtSalarioBase.TabIndex = 0;
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Location = new Point(198, 168);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(154, 27);
            txtHorasExtras.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(95, 310);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(228, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // lblEmpleado
            // 
            lblEmpleado.Location = new Point(51, 49);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(314, 30);
            lblEmpleado.TabIndex = 4;
            lblEmpleado.Text = "label1";
            lblEmpleado.Click += lblEmpleado_Click;
            // 
            // txtDeduccionesExtras
            // 
            txtDeduccionesExtras.Location = new Point(198, 240);
            txtDeduccionesExtras.Name = "txtDeduccionesExtras";
            txtDeduccionesExtras.Size = new Size(154, 27);
            txtDeduccionesExtras.TabIndex = 5;
            // 
            // label1
            // 
            label1.Location = new Point(79, 113);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 6;
            label1.Text = "SUELDO BASE";
            // 
            // label2
            // 
            label2.Location = new Point(73, 171);
            label2.Name = "label2";
            label2.Size = new Size(116, 24);
            label2.TabIndex = 7;
            label2.Text = "HORAS EXTRAS";
            // 
            // label3
            // 
            label3.Location = new Point(26, 240);
            label3.Name = "label3";
            label3.Size = new Size(166, 24);
            label3.TabIndex = 8;
            label3.Text = "DEDUCCIONES EXTRAS";
            label3.Click += label3_Click;
            // 
            // FormPlanillas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 383);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDeduccionesExtras);
            Controls.Add(lblEmpleado);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtHorasExtras);
            Controls.Add(txtSalarioBase);
            Name = "FormPlanillas";
            Text = "FormPlanillas";
            Load += FormPlanillas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSalarioBase;
        private TextBox txtHorasExtras;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblEmpleado;
        private TextBox txtDeduccionesExtras;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}