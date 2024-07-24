namespace Galaga
{
    partial class Form1
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
            this.grbGame = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbVidasJugador = new System.Windows.Forms.GroupBox();
            this.picVidasJugador = new System.Windows.Forms.PictureBox();
            this.grbVidasEnemigos = new System.Windows.Forms.GroupBox();
            this.picVidasEnemigos = new System.Windows.Forms.PictureBox();
            this.grbGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbVidasJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVidasJugador)).BeginInit();
            this.grbVidasEnemigos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVidasEnemigos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbGame
            // 
            this.grbGame.Controls.Add(this.picCanvas);
            this.grbGame.ForeColor = System.Drawing.Color.White;
            this.grbGame.Location = new System.Drawing.Point(185, 12);
            this.grbGame.Name = "grbGame";
            this.grbGame.Size = new System.Drawing.Size(600, 729);
            this.grbGame.TabIndex = 0;
            this.grbGame.TabStop = false;
            this.grbGame.Text = "Galaga";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picCanvas.Location = new System.Drawing.Point(7, 22);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(587, 701);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbVidasJugador
            // 
            this.grbVidasJugador.Controls.Add(this.picVidasJugador);
            this.grbVidasJugador.ForeColor = System.Drawing.Color.White;
            this.grbVidasJugador.Location = new System.Drawing.Point(12, 641);
            this.grbVidasJugador.Name = "grbVidasJugador";
            this.grbVidasJugador.Size = new System.Drawing.Size(167, 100);
            this.grbVidasJugador.TabIndex = 1;
            this.grbVidasJugador.TabStop = false;
            this.grbVidasJugador.Text = "Jugador";
            // 
            // picVidasJugador
            // 
            this.picVidasJugador.Location = new System.Drawing.Point(6, 30);
            this.picVidasJugador.Name = "picVidasJugador";
            this.picVidasJugador.Size = new System.Drawing.Size(155, 50);
            this.picVidasJugador.TabIndex = 0;
            this.picVidasJugador.TabStop = false;
            // 
            // grbVidasEnemigos
            // 
            this.grbVidasEnemigos.Controls.Add(this.picVidasEnemigos);
            this.grbVidasEnemigos.ForeColor = System.Drawing.Color.White;
            this.grbVidasEnemigos.Location = new System.Drawing.Point(803, 12);
            this.grbVidasEnemigos.Name = "grbVidasEnemigos";
            this.grbVidasEnemigos.Size = new System.Drawing.Size(167, 138);
            this.grbVidasEnemigos.TabIndex = 2;
            this.grbVidasEnemigos.TabStop = false;
            this.grbVidasEnemigos.Text = "Enemigos";
            // 
            // picVidasEnemigos
            // 
            this.picVidasEnemigos.Location = new System.Drawing.Point(6, 30);
            this.picVidasEnemigos.Name = "picVidasEnemigos";
            this.picVidasEnemigos.Size = new System.Drawing.Size(155, 100);
            this.picVidasEnemigos.TabIndex = 0;
            this.picVidasEnemigos.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.grbVidasEnemigos);
            this.Controls.Add(this.grbVidasJugador);
            this.Controls.Add(this.grbGame);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.grbGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbVidasJugador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVidasJugador)).EndInit();
            this.grbVidasEnemigos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVidasEnemigos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGame;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbVidasJugador;
        private System.Windows.Forms.PictureBox picVidasJugador;
        private System.Windows.Forms.GroupBox grbVidasEnemigos;
        private System.Windows.Forms.PictureBox picVidasEnemigos;
    }
}

