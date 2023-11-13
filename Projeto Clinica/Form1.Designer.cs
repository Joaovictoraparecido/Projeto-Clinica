namespace Projeto_Clinica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CADASTRAR_PACIENTES = new System.Windows.Forms.Button();
            this.ListaPacientes1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CADASTRAR_PACIENTES
            // 
            this.CADASTRAR_PACIENTES.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.CADASTRAR_PACIENTES.FlatAppearance.BorderSize = 2;
            this.CADASTRAR_PACIENTES.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.CADASTRAR_PACIENTES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CADASTRAR_PACIENTES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CADASTRAR_PACIENTES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CADASTRAR_PACIENTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CADASTRAR_PACIENTES.Location = new System.Drawing.Point(317, 356);
            this.CADASTRAR_PACIENTES.Name = "CADASTRAR_PACIENTES";
            this.CADASTRAR_PACIENTES.Size = new System.Drawing.Size(221, 62);
            this.CADASTRAR_PACIENTES.TabIndex = 1;
            this.CADASTRAR_PACIENTES.Text = "CADASTRAR PACIENTES";
            this.CADASTRAR_PACIENTES.UseVisualStyleBackColor = true;
            this.CADASTRAR_PACIENTES.Click += new System.EventHandler(this.CADASTRAR_PACIENTES_Click);
            // 
            // ListaPacientes1
            // 
            this.ListaPacientes1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ListaPacientes1.FlatAppearance.BorderSize = 2;
            this.ListaPacientes1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ListaPacientes1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ListaPacientes1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ListaPacientes1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListaPacientes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaPacientes1.Location = new System.Drawing.Point(632, 356);
            this.ListaPacientes1.Name = "ListaPacientes1";
            this.ListaPacientes1.Size = new System.Drawing.Size(221, 62);
            this.ListaPacientes1.TabIndex = 4;
            this.ListaPacientes1.Text = "LISTA DE PACIENTES";
            this.ListaPacientes1.UseVisualStyleBackColor = true;
            this.ListaPacientes1.Click += new System.EventHandler(this.ListaPacientes1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Clinica.Properties.Resources.cl9inica;
            this.pictureBox1.Location = new System.Drawing.Point(394, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 545);
            this.Controls.Add(this.ListaPacientes1);
            this.Controls.Add(this.CADASTRAR_PACIENTES);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CADASTRAR_PACIENTES;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ListaPacientes1;
    }
}

