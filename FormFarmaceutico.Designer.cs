﻿namespace ProyectoParcial
{
    partial class FormFarmaceutico
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
            menuStrip1 = new MenuStrip();
            recepcionToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 28);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1064, 545);
            panelContenido.TabIndex = 0;
            panelContenido.Paint += panelContenido_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { recepcionToolStripMenuItem, inventarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1064, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // recepcionToolStripMenuItem
            // 
            recepcionToolStripMenuItem.Name = "recepcionToolStripMenuItem";
            recepcionToolStripMenuItem.Size = new Size(92, 24);
            recepcionToolStripMenuItem.Text = "Recepcion";
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(89, 24);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // FormFarmaceutico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 573);
            Controls.Add(panelContenido);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormFarmaceutico";
            Text = "FormFarmaceutico";
            Load += FormFarmaceutico_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelContenido;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem recepcionToolStripMenuItem;
        private ToolStripMenuItem inventarioToolStripMenuItem;
    }
}