namespace Proyecto_1.Avisos
{
    partial class Avisos_login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnmensaje = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 79);
            this.panel1.TabIndex = 0;
            // 
            // btncerrar
            // 
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = global::Proyecto_1.Properties.Resources.Icono_cerrar_FN;
            this.btncerrar.Location = new System.Drawing.Point(378, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(56, 55);
            this.btncerrar.TabIndex = 4;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(79, 143);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(81, 20);
            this.lblmensaje.TabIndex = 1;
            this.lblmensaje.Text = "label1";
            this.lblmensaje.Click += new System.EventHandler(this.lblmensaje_Click);
            // 
            // btnmensaje
            // 
            this.btnmensaje.FlatAppearance.BorderSize = 0;
            this.btnmensaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnmensaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnmensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmensaje.Image = global::Proyecto_1.Properties.Resources.check;
            this.btnmensaje.Location = new System.Drawing.Point(0, 232);
            this.btnmensaje.Name = "btnmensaje";
            this.btnmensaje.Size = new System.Drawing.Size(446, 59);
            this.btnmensaje.TabIndex = 2;
            this.btnmensaje.Text = "Aceptar";
            this.btnmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmensaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmensaje.UseVisualStyleBackColor = true;
            this.btnmensaje.Click += new System.EventHandler(this.btnmensaje_Click);
            // 
            // Avisos_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 337);
            this.Controls.Add(this.btnmensaje);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Avisos_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avisos_login";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnmensaje;
        public System.Windows.Forms.Label lblmensaje;
    }
}