
namespace JuegoAhorcado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categorias = new System.Windows.Forms.ComboBox();
            this.jugar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.reiniciar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nRonda = new System.Windows.Forms.Label();
            this.nPuntos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(61, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "A h o r c a d o";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(63, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoría:";
            // 
            // categorias
            // 
            this.categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorias.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorias.FormattingEnabled = true;
            this.categorias.Location = new System.Drawing.Point(215, 152);
            this.categorias.Name = "categorias";
            this.categorias.Size = new System.Drawing.Size(152, 39);
            this.categorias.Sorted = true;
            this.categorias.TabIndex = 2;
            this.categorias.SelectedValueChanged += new System.EventHandler(this.categorias_SelectedValueChanged);
            // 
            // jugar
            // 
            this.jugar.BackColor = System.Drawing.Color.Transparent;
            this.jugar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.jugar.Enabled = false;
            this.jugar.FlatAppearance.BorderSize = 0;
            this.jugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.jugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.jugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jugar.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.jugar.Location = new System.Drawing.Point(70, 288);
            this.jugar.Name = "jugar";
            this.jugar.Size = new System.Drawing.Size(117, 55);
            this.jugar.TabIndex = 3;
            this.jugar.Text = "Jugar";
            this.jugar.UseVisualStyleBackColor = false;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.salir.FlatAppearance.BorderSize = 0;
            this.salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.salir.Location = new System.Drawing.Point(443, 288);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(117, 55);
            this.salir.TabIndex = 4;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            // 
            // reiniciar
            // 
            this.reiniciar.BackColor = System.Drawing.Color.Transparent;
            this.reiniciar.FlatAppearance.BorderSize = 0;
            this.reiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reiniciar.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reiniciar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reiniciar.Location = new System.Drawing.Point(215, 288);
            this.reiniciar.Name = "reiniciar";
            this.reiniciar.Size = new System.Drawing.Size(193, 55);
            this.reiniciar.TabIndex = 5;
            this.reiniciar.Text = "Reiniciar";
            this.reiniciar.UseVisualStyleBackColor = false;
            this.reiniciar.Click += new System.EventHandler(this.reiniciar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(494, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 53);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ronda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(494, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 53);
            this.label3.TabIndex = 9;
            this.label3.Text = "Puntos:";
            // 
            // nRonda
            // 
            this.nRonda.AutoSize = true;
            this.nRonda.BackColor = System.Drawing.Color.Transparent;
            this.nRonda.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold);
            this.nRonda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nRonda.Location = new System.Drawing.Point(636, 83);
            this.nRonda.Name = "nRonda";
            this.nRonda.Size = new System.Drawing.Size(46, 53);
            this.nRonda.TabIndex = 10;
            this.nRonda.Text = "1";
            // 
            // nPuntos
            // 
            this.nPuntos.AutoSize = true;
            this.nPuntos.BackColor = System.Drawing.Color.Transparent;
            this.nPuntos.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold);
            this.nPuntos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nPuntos.Location = new System.Drawing.Point(636, 163);
            this.nPuntos.Name = "nPuntos";
            this.nPuntos.Size = new System.Drawing.Size(46, 53);
            this.nPuntos.TabIndex = 11;
            this.nPuntos.Text = "0";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoAhorcado.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nPuntos);
            this.Controls.Add(this.nRonda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reiniciar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.jugar);
            this.Controls.Add(this.categorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Ahorcado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox categorias;
        private System.Windows.Forms.Button jugar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button reiniciar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nRonda;
        private System.Windows.Forms.Label nPuntos;
    }
}