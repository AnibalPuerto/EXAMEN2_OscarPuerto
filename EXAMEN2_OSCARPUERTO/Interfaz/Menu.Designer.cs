﻿namespace Interfaz
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiposDeSoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarUnNuevoTipoDeSoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeSoporteToolStripMenuItem,
            this.ticketsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiposDeSoporteToolStripMenuItem
            // 
            this.tiposDeSoporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarUnNuevoTipoDeSoporteToolStripMenuItem});
            this.tiposDeSoporteToolStripMenuItem.Name = "tiposDeSoporteToolStripMenuItem";
            this.tiposDeSoporteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.tiposDeSoporteToolStripMenuItem.Text = "Tipos de Soporte";
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarTicketToolStripMenuItem});
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // ingresarUnNuevoTipoDeSoporteToolStripMenuItem
            // 
            this.ingresarUnNuevoTipoDeSoporteToolStripMenuItem.Name = "ingresarUnNuevoTipoDeSoporteToolStripMenuItem";
            this.ingresarUnNuevoTipoDeSoporteToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.ingresarUnNuevoTipoDeSoporteToolStripMenuItem.Text = "Ingresar un nuevo tipo de soporte...";
            this.ingresarUnNuevoTipoDeSoporteToolStripMenuItem.Click += new System.EventHandler(this.ingresarUnNuevoTipoDeSoporteToolStripMenuItem_Click);
            // 
            // generarTicketToolStripMenuItem
            // 
            this.generarTicketToolStripMenuItem.Name = "generarTicketToolStripMenuItem";
            this.generarTicketToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generarTicketToolStripMenuItem.Text = "Generar Ticket..";
            this.generarTicketToolStripMenuItem.Click += new System.EventHandler(this.generarTicketToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 299);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiposDeSoporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarUnNuevoTipoDeSoporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarTicketToolStripMenuItem;
    }
}