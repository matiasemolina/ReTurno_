﻿namespace EjemploABM
{
    partial class FormCalendario
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
            this.tabControlCalendario = new MaterialSkin.Controls.MaterialTabControl();
            this.tab_calendario = new System.Windows.Forms.TabPage();
            this.tab_abm = new System.Windows.Forms.TabPage();
            this.panel_contenedor_calendario = new System.Windows.Forms.Panel();
            this.panel_control = new System.Windows.Forms.Panel();
            this.panel_actividad = new System.Windows.Forms.Panel();
            this.panel_calendario = new System.Windows.Forms.Panel();
            this.panel_semana0 = new System.Windows.Forms.Panel();
            this.panel_semana1 = new System.Windows.Forms.Panel();
            this.panel_semana2 = new System.Windows.Forms.Panel();
            this.panel_semana3 = new System.Windows.Forms.Panel();
            this.panel_semana4 = new System.Windows.Forms.Panel();
            this.panel_semana5 = new System.Windows.Forms.Panel();
            this.panel_dia_semana = new System.Windows.Forms.Panel();
            this.tabControlCalendario.SuspendLayout();
            this.tab_calendario.SuspendLayout();
            this.panel_contenedor_calendario.SuspendLayout();
            this.panel_calendario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCalendario
            // 
            this.tabControlCalendario.Controls.Add(this.tab_calendario);
            this.tabControlCalendario.Controls.Add(this.tab_abm);
            this.tabControlCalendario.Depth = 0;
            this.tabControlCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCalendario.Location = new System.Drawing.Point(3, 64);
            this.tabControlCalendario.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlCalendario.Multiline = true;
            this.tabControlCalendario.Name = "tabControlCalendario";
            this.tabControlCalendario.SelectedIndex = 0;
            this.tabControlCalendario.Size = new System.Drawing.Size(1087, 588);
            this.tabControlCalendario.TabIndex = 0;
            // 
            // tab_calendario
            // 
            this.tab_calendario.Controls.Add(this.panel_contenedor_calendario);
            this.tab_calendario.Location = new System.Drawing.Point(4, 22);
            this.tab_calendario.Name = "tab_calendario";
            this.tab_calendario.Padding = new System.Windows.Forms.Padding(3);
            this.tab_calendario.Size = new System.Drawing.Size(1079, 562);
            this.tab_calendario.TabIndex = 0;
            this.tab_calendario.Text = "Calendario";
            this.tab_calendario.UseVisualStyleBackColor = true;
            // 
            // tab_abm
            // 
            this.tab_abm.Location = new System.Drawing.Point(4, 22);
            this.tab_abm.Name = "tab_abm";
            this.tab_abm.Padding = new System.Windows.Forms.Padding(3);
            this.tab_abm.Size = new System.Drawing.Size(701, 523);
            this.tab_abm.TabIndex = 1;
            this.tab_abm.Text = "ABM";
            this.tab_abm.UseVisualStyleBackColor = true;
            // 
            // panel_contenedor_calendario
            // 
            this.panel_contenedor_calendario.Controls.Add(this.panel_calendario);
            this.panel_contenedor_calendario.Controls.Add(this.panel_actividad);
            this.panel_contenedor_calendario.Controls.Add(this.panel_control);
            this.panel_contenedor_calendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor_calendario.Location = new System.Drawing.Point(3, 3);
            this.panel_contenedor_calendario.Name = "panel_contenedor_calendario";
            this.panel_contenedor_calendario.Size = new System.Drawing.Size(1073, 556);
            this.panel_contenedor_calendario.TabIndex = 0;
            // 
            // panel_control
            // 
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_control.Location = new System.Drawing.Point(0, 0);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(1073, 44);
            this.panel_control.TabIndex = 0;
            // 
            // panel_actividad
            // 
            this.panel_actividad.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_actividad.Location = new System.Drawing.Point(797, 44);
            this.panel_actividad.Name = "panel_actividad";
            this.panel_actividad.Size = new System.Drawing.Size(276, 512);
            this.panel_actividad.TabIndex = 1;
            // 
            // panel_calendario
            // 
            this.panel_calendario.Controls.Add(this.panel_dia_semana);
            this.panel_calendario.Controls.Add(this.panel_semana5);
            this.panel_calendario.Controls.Add(this.panel_semana4);
            this.panel_calendario.Controls.Add(this.panel_semana3);
            this.panel_calendario.Controls.Add(this.panel_semana2);
            this.panel_calendario.Controls.Add(this.panel_semana1);
            this.panel_calendario.Controls.Add(this.panel_semana0);
            this.panel_calendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_calendario.Location = new System.Drawing.Point(0, 44);
            this.panel_calendario.Name = "panel_calendario";
            this.panel_calendario.Size = new System.Drawing.Size(797, 512);
            this.panel_calendario.TabIndex = 2;
            // 
            // panel_semana0
            // 
            this.panel_semana0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_semana0.Location = new System.Drawing.Point(0, 439);
            this.panel_semana0.Name = "panel_semana0";
            this.panel_semana0.Size = new System.Drawing.Size(797, 73);
            this.panel_semana0.TabIndex = 0;
            // 
            // panel_semana1
            // 
            this.panel_semana1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_semana1.Location = new System.Drawing.Point(0, 366);
            this.panel_semana1.Name = "panel_semana1";
            this.panel_semana1.Size = new System.Drawing.Size(797, 73);
            this.panel_semana1.TabIndex = 1;
            // 
            // panel_semana2
            // 
            this.panel_semana2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_semana2.Location = new System.Drawing.Point(0, 293);
            this.panel_semana2.Name = "panel_semana2";
            this.panel_semana2.Size = new System.Drawing.Size(797, 73);
            this.panel_semana2.TabIndex = 2;
            // 
            // panel_semana3
            // 
            this.panel_semana3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_semana3.Location = new System.Drawing.Point(0, 220);
            this.panel_semana3.Name = "panel_semana3";
            this.panel_semana3.Size = new System.Drawing.Size(797, 73);
            this.panel_semana3.TabIndex = 3;
            // 
            // panel_semana4
            // 
            this.panel_semana4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_semana4.Location = new System.Drawing.Point(0, 147);
            this.panel_semana4.Name = "panel_semana4";
            this.panel_semana4.Size = new System.Drawing.Size(797, 73);
            this.panel_semana4.TabIndex = 4;
            // 
            // panel_semana5
            // 
            this.panel_semana5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_semana5.Location = new System.Drawing.Point(0, 74);
            this.panel_semana5.Name = "panel_semana5";
            this.panel_semana5.Size = new System.Drawing.Size(797, 73);
            this.panel_semana5.TabIndex = 5;
            // 
            // panel_dia_semana
            // 
            this.panel_dia_semana.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_dia_semana.Location = new System.Drawing.Point(0, 1);
            this.panel_dia_semana.Name = "panel_dia_semana";
            this.panel_dia_semana.Size = new System.Drawing.Size(797, 73);
            this.panel_dia_semana.TabIndex = 6;
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 655);
            this.Controls.Add(this.tabControlCalendario);
            this.Name = "FormCalendario";
            this.Text = "FormCalendario";
            this.Load += new System.EventHandler(this.FormCalendario_Load);
            this.tabControlCalendario.ResumeLayout(false);
            this.tab_calendario.ResumeLayout(false);
            this.panel_contenedor_calendario.ResumeLayout(false);
            this.panel_calendario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControlCalendario;
        private System.Windows.Forms.TabPage tab_calendario;
        private System.Windows.Forms.TabPage tab_abm;
        private System.Windows.Forms.Panel panel_contenedor_calendario;
        private System.Windows.Forms.Panel panel_actividad;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Panel panel_calendario;
        private System.Windows.Forms.Panel panel_semana0;
        private System.Windows.Forms.Panel panel_semana5;
        private System.Windows.Forms.Panel panel_semana4;
        private System.Windows.Forms.Panel panel_semana3;
        private System.Windows.Forms.Panel panel_semana2;
        private System.Windows.Forms.Panel panel_semana1;
        private System.Windows.Forms.Panel panel_dia_semana;
    }
}