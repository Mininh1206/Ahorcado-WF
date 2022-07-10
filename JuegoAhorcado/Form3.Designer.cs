
namespace JuegoAhorcado
{
    partial class Perdido
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
            this.perdedor = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // perdedor
            // 
            this.perdedor.AutoSize = true;
            this.perdedor.BackColor = System.Drawing.Color.Transparent;
            this.perdedor.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold);
            this.perdedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.perdedor.Location = new System.Drawing.Point(178, 131);
            this.perdedor.Name = "perdedor";
            this.perdedor.Size = new System.Drawing.Size(448, 53);
            this.perdedor.TabIndex = 5;
            this.perdedor.Text = "¡¡Has perdido!! -5 puntos";
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.Transparent;
            this.menu.Location = new System.Drawing.Point(310, 269);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(166, 63);
            this.menu.TabIndex = 6;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = false;
            // 
            // Perdido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoAhorcado.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.perdedor);
            this.Name = "Perdido";
            this.Text = "Ahorcado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label perdedor;
        private System.Windows.Forms.Button menu;
    }
}