
namespace JuegoAhorcado
{
    partial class Juego
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
            this.palabraOculta = new System.Windows.Forms.Label();
            this.imgAhorcado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nIntentos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nPuntos = new System.Windows.Forms.Label();
            this.sigRonda = new System.Windows.Forms.Button();
            this.letraPulsada = new System.Windows.Forms.Label();
            this.palabraResolver = new System.Windows.Forms.TextBox();
            this.resolver = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // palabraOculta
            // 
            this.palabraOculta.BackColor = System.Drawing.Color.Transparent;
            this.palabraOculta.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palabraOculta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.palabraOculta.Location = new System.Drawing.Point(61, 31);
            this.palabraOculta.Name = "palabraOculta";
            this.palabraOculta.Size = new System.Drawing.Size(693, 54);
            this.palabraOculta.TabIndex = 1;
            this.palabraOculta.Text = "A h o r c a d o";
            // 
            // imgAhorcado
            // 
            this.imgAhorcado.BackColor = System.Drawing.Color.Transparent;
            this.imgAhorcado.Location = new System.Drawing.Point(70, 120);
            this.imgAhorcado.Name = "imgAhorcado";
            this.imgAhorcado.Size = new System.Drawing.Size(300, 300);
            this.imgAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAhorcado.TabIndex = 2;
            this.imgAhorcado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(380, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "Intentos restantes:";
            // 
            // nIntentos
            // 
            this.nIntentos.AutoSize = true;
            this.nIntentos.BackColor = System.Drawing.Color.Transparent;
            this.nIntentos.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold);
            this.nIntentos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nIntentos.Location = new System.Drawing.Point(708, 120);
            this.nIntentos.Name = "nIntentos";
            this.nIntentos.Size = new System.Drawing.Size(46, 53);
            this.nIntentos.TabIndex = 4;
            this.nIntentos.Text = "7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(380, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 53);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puntos:";
            // 
            // nPuntos
            // 
            this.nPuntos.AutoSize = true;
            this.nPuntos.BackColor = System.Drawing.Color.Transparent;
            this.nPuntos.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold);
            this.nPuntos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nPuntos.Location = new System.Drawing.Point(535, 173);
            this.nPuntos.Name = "nPuntos";
            this.nPuntos.Size = new System.Drawing.Size(46, 53);
            this.nPuntos.TabIndex = 6;
            this.nPuntos.Text = "0";
            // 
            // sigRonda
            // 
            this.sigRonda.AutoSize = true;
            this.sigRonda.BackColor = System.Drawing.Color.Transparent;
            this.sigRonda.FlatAppearance.BorderSize = 0;
            this.sigRonda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sigRonda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sigRonda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sigRonda.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigRonda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sigRonda.Location = new System.Drawing.Point(544, 357);
            this.sigRonda.Name = "sigRonda";
            this.sigRonda.Size = new System.Drawing.Size(234, 63);
            this.sigRonda.TabIndex = 7;
            this.sigRonda.TabStop = false;
            this.sigRonda.Text = "Siguiente ronda";
            this.sigRonda.UseVisualStyleBackColor = true;
            this.sigRonda.Visible = false;
            this.sigRonda.Click += new System.EventHandler(this.sigRonda_Click);
            // 
            // letraPulsada
            // 
            this.letraPulsada.AutoSize = true;
            this.letraPulsada.BackColor = System.Drawing.Color.Transparent;
            this.letraPulsada.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letraPulsada.ForeColor = System.Drawing.Color.Red;
            this.letraPulsada.Location = new System.Drawing.Point(397, 80);
            this.letraPulsada.Name = "letraPulsada";
            this.letraPulsada.Size = new System.Drawing.Size(327, 40);
            this.letraPulsada.TabIndex = 8;
            this.letraPulsada.Text = "Ya has pulsado esa letra";
            this.letraPulsada.Visible = false;
            // 
            // palabraResolver
            // 
            this.palabraResolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.palabraResolver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palabraResolver.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palabraResolver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.palabraResolver.Location = new System.Drawing.Point(546, 307);
            this.palabraResolver.Margin = new System.Windows.Forms.Padding(10);
            this.palabraResolver.Name = "palabraResolver";
            this.palabraResolver.Size = new System.Drawing.Size(178, 46);
            this.palabraResolver.TabIndex = 10;
            this.palabraResolver.TabStop = false;
            this.palabraResolver.Visible = false;
            // 
            // resolver
            // 
            this.resolver.AutoSize = true;
            this.resolver.BackColor = System.Drawing.Color.Transparent;
            this.resolver.FlatAppearance.BorderSize = 0;
            this.resolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.resolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.resolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolver.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.resolver.Location = new System.Drawing.Point(389, 229);
            this.resolver.Name = "resolver";
            this.resolver.Size = new System.Drawing.Size(140, 63);
            this.resolver.TabIndex = 9;
            this.resolver.TabStop = false;
            this.resolver.Text = "Resolver";
            this.resolver.UseVisualStyleBackColor = true;
            this.resolver.Click += new System.EventHandler(this.resolver_Click);
            this.resolver.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Juego_KeyDown);
            // 
            // cancelar
            // 
            this.cancelar.AutoSize = true;
            this.cancelar.BackColor = System.Drawing.Color.Transparent;
            this.cancelar.FlatAppearance.BorderSize = 0;
            this.cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cancelar.Location = new System.Drawing.Point(389, 298);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(141, 63);
            this.cancelar.TabIndex = 11;
            this.cancelar.TabStop = false;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Visible = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            this.cancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Juego_KeyDown);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoAhorcado.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.resolver);
            this.Controls.Add(this.palabraResolver);
            this.Controls.Add(this.letraPulsada);
            this.Controls.Add(this.sigRonda);
            this.Controls.Add(this.nPuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nIntentos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgAhorcado);
            this.Controls.Add(this.palabraOculta);
            this.Name = "Juego";
            this.Text = "Ahorcado";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Juego_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label palabraOculta;
        private System.Windows.Forms.PictureBox imgAhorcado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nIntentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nPuntos;
        private System.Windows.Forms.Button sigRonda;
        private System.Windows.Forms.Label letraPulsada;
        private System.Windows.Forms.TextBox palabraResolver;
        private System.Windows.Forms.Button resolver;
        private System.Windows.Forms.Button cancelar;
    }
}

