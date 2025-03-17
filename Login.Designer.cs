namespace Proyecto_1
{
    partial class Login
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontra = new System.Windows.Forms.MaskedTextBox();
            this.btnlógin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 77);
            this.panel1.TabIndex = 0;
            // 
            // btncerrar
            // 
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = global::Proyecto_1.Properties.Resources.Icono_cerrar_FN;
            this.btncerrar.Location = new System.Drawing.Point(289, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(56, 55);
            this.btncerrar.TabIndex = 3;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.FlatAppearance.BorderSize = 0;
            this.btnminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimizar.Image = global::Proyecto_1.Properties.Resources.Icono_Minimizar;
            this.btnminimizar.Location = new System.Drawing.Point(209, 12);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(56, 55);
            this.btnminimizar.TabIndex = 1;
            this.btnminimizar.UseVisualStyleBackColor = true;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_1.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(110, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(110, 290);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(103, 27);
            this.txtusuario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(110, 377);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '♪';
            this.txtcontra.Size = new System.Drawing.Size(103, 27);
            this.txtcontra.TabIndex = 5;
            // 
            // btnlógin
            // 
            this.btnlógin.Location = new System.Drawing.Point(78, 442);
            this.btnlógin.Name = "btnlógin";
            this.btnlógin.Size = new System.Drawing.Size(209, 48);
            this.btnlógin.TabIndex = 6;
            this.btnlógin.Text = "Iniciar sección";
            this.btnlógin.UseVisualStyleBackColor = true;
            this.btnlógin.Click += new System.EventHandler(this.btnlógin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 775);
            this.Controls.Add(this.btnlógin);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtcontra;
        private System.Windows.Forms.Button btnlógin;
    }
}

