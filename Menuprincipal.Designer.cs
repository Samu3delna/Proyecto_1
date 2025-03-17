namespace Proyecto_1
{
    partial class Menu_principal
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAnimales = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btnReporteria = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnReporteria);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnVehiculos);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnAnimales);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 548);
            this.panel1.TabIndex = 0;
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.FlatAppearance.BorderSize = 0;
            this.btnVehiculos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.Image = global::Proyecto_1.Properties.Resources.insertcar24x24;
            this.btnVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.Location = new System.Drawing.Point(12, 184);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(124, 55);
            this.btnVehiculos.TabIndex = 8;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVehiculos.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Location = new System.Drawing.Point(3, 184);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 58);
            this.panel5.TabIndex = 7;
            // 
            // btnAnimales
            // 
            this.btnAnimales.FlatAppearance.BorderSize = 0;
            this.btnAnimales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnimales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btnAnimales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimales.Image = global::Proyecto_1.Properties.Resources.empleados;
            this.btnAnimales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnimales.Location = new System.Drawing.Point(12, 272);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(124, 55);
            this.btnAnimales.TabIndex = 6;
            this.btnAnimales.Text = "Animales";
            this.btnAnimales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnimales.UseVisualStyleBackColor = true;
            this.btnAnimales.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(3, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 58);
            this.panel3.TabIndex = 5;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Image = global::Proyecto_1.Properties.Resources.empleados;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 85);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(124, 55);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(3, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 58);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.btnminimizar);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.btncerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(139, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 79);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHora.Location = new System.Drawing.Point(6, 43);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(80, 24);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "label2";
            // 
            // btnminimizar
            // 
            this.btnminimizar.FlatAppearance.BorderSize = 0;
            this.btnminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimizar.Image = global::Proyecto_1.Properties.Resources.Icono_Minimizar;
            this.btnminimizar.Location = new System.Drawing.Point(640, 12);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(56, 55);
            this.btnminimizar.TabIndex = 4;
            this.btnminimizar.UseVisualStyleBackColor = true;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblFecha.Location = new System.Drawing.Point(3, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(80, 24);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "label1";
            // 
            // btncerrar
            // 
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = global::Proyecto_1.Properties.Resources.Icono_cerrar_FN;
            this.btncerrar.Location = new System.Drawing.Point(721, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(56, 55);
            this.btncerrar.TabIndex = 5;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(139, 79);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(774, 469);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint_1);
            // 
            // btnReporteria
            // 
            this.btnReporteria.FlatAppearance.BorderSize = 0;
            this.btnReporteria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReporteria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btnReporteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteria.Image = global::Proyecto_1.Properties.Resources.btnreportes;
            this.btnReporteria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteria.Location = new System.Drawing.Point(12, 360);
            this.btnReporteria.Name = "btnReporteria";
            this.btnReporteria.Size = new System.Drawing.Size(124, 55);
            this.btnReporteria.TabIndex = 10;
            this.btnReporteria.Text = "Reporteria";
            this.btnReporteria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteria.UseVisualStyleBackColor = true;
            this.btnReporteria.Click += new System.EventHandler(this.btnReporteria_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Location = new System.Drawing.Point(3, 360);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 58);
            this.panel6.TabIndex = 9;
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 548);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_principal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAnimales;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReporteria;
        private System.Windows.Forms.Panel panel6;
    }
}