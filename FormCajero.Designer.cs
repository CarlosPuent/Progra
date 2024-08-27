namespace ProyectoParcial
{
    partial class FormCajero
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
            panelContenido = new Panel();
            menuStripCajero = new MenuStrip();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            menuStripCajero.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 28);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1011, 555);
            panelContenido.TabIndex = 0;
            panelContenido.Paint += panelContenido_Paint;
            // 
            // menuStripCajero
            // 
            menuStripCajero.ImageScalingSize = new Size(20, 20);
            menuStripCajero.Items.AddRange(new ToolStripItem[] { ventasToolStripMenuItem });
            menuStripCajero.Location = new Point(0, 0);
            menuStripCajero.Name = "menuStripCajero";
            menuStripCajero.Size = new Size(1011, 28);
            menuStripCajero.TabIndex = 1;
            menuStripCajero.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(66, 24);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // FormCajero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 583);
            Controls.Add(panelContenido);
            Controls.Add(menuStripCajero);
            MainMenuStrip = menuStripCajero;
            Name = "FormCajero";
            Text = "FormCajero";
            Load += FormCajero_Load;
            menuStripCajero.ResumeLayout(false);
            menuStripCajero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelContenido;
        private MenuStrip menuStripCajero;
        private ToolStripMenuItem ventasToolStripMenuItem;
    }
}