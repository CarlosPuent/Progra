namespace ProyectoParcial
{
    partial class LoginForm
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
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIniciarSesion = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            chkMostrarContraseña = new CheckBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(184, 193);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(181, 27);
            txtNombreUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(184, 259);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(181, 27);
            txtContraseña.TabIndex = 1;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(123, 343);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(94, 29);
            btnIniciarSesion.TabIndex = 2;
            btnIniciarSesion.Text = "Iniciar";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(240, 343);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(83, 193);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.Location = new Point(83, 259);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // chkMostrarContraseña
            // 
            chkMostrarContraseña.AutoSize = true;
            chkMostrarContraseña.Location = new Point(381, 262);
            chkMostrarContraseña.Name = "chkMostrarContraseña";
            chkMostrarContraseña.Size = new Size(18, 17);
            chkMostrarContraseña.TabIndex = 6;
            chkMostrarContraseña.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 78);
            label3.Name = "label3";
            label3.Size = new Size(268, 42);
            label3.TabIndex = 27;
            label3.Text = "INICIO DE SESIÓN";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 430);
            Controls.Add(label3);
            Controls.Add(chkMostrarContraseña);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private Button btnIniciarSesion;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private CheckBox chkMostrarContraseña;
        private Label label3;
    }
}