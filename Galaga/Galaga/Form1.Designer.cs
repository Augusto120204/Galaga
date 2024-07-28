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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReintentar = new System.Windows.Forms.Button();
            this.lblJuego = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbVidasJugador = new System.Windows.Forms.GroupBox();
            this.picVidasJugador = new System.Windows.Forms.PictureBox();
            this.grbVidasEnemigos = new System.Windows.Forms.GroupBox();
            this.picVidasEnemigos = new System.Windows.Forms.PictureBox();
            this.lblPausa = new System.Windows.Forms.Label();
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblDificultad = new System.Windows.Forms.Label();
            this.cbxDificultad = new System.Windows.Forms.ComboBox();
            this.grbGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbVidasJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVidasJugador)).BeginInit();
            this.grbVidasEnemigos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVidasEnemigos)).BeginInit();
            this.grbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGame
            // 
            this.grbGame.Controls.Add(this.btnSalir);
            this.grbGame.Controls.Add(this.btnReintentar);
            this.grbGame.Controls.Add(this.lblJuego);
            this.grbGame.Controls.Add(this.picCanvas);
            this.grbGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGame.ForeColor = System.Drawing.Color.White;
            this.grbGame.Location = new System.Drawing.Point(185, 12);
            this.grbGame.Name = "grbGame";
            this.grbGame.Size = new System.Drawing.Size(600, 729);
            this.grbGame.TabIndex = 0;
            this.grbGame.TabStop = false;
            this.grbGame.Text = "Galaga";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Enabled = false;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(325, 440);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 58);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReintentar
            // 
            this.btnReintentar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReintentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReintentar.Enabled = false;
            this.btnReintentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReintentar.Location = new System.Drawing.Point(140, 440);
            this.btnReintentar.Name = "btnReintentar";
            this.btnReintentar.Size = new System.Drawing.Size(138, 58);
            this.btnReintentar.TabIndex = 2;
            this.btnReintentar.Text = "Reintentar";
            this.btnReintentar.UseVisualStyleBackColor = false;
            this.btnReintentar.Visible = false;
            this.btnReintentar.Click += new System.EventHandler(this.btnReintentar_Click);
            // 
            // lblJuego
            // 
            this.lblJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuego.ForeColor = System.Drawing.Color.White;
            this.lblJuego.Location = new System.Drawing.Point(62, 303);
            this.lblJuego.Name = "lblJuego";
            this.lblJuego.Size = new System.Drawing.Size(477, 148);
            this.lblJuego.TabIndex = 1;
            this.lblJuego.Text = "Presiona ENTER\r\npara iniciar";
            this.lblJuego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.grbVidasJugador.Visible = false;
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
            this.grbVidasEnemigos.Visible = false;
            // 
            // picVidasEnemigos
            // 
            this.picVidasEnemigos.Location = new System.Drawing.Point(6, 30);
            this.picVidasEnemigos.Name = "picVidasEnemigos";
            this.picVidasEnemigos.Size = new System.Drawing.Size(155, 100);
            this.picVidasEnemigos.TabIndex = 0;
            this.picVidasEnemigos.TabStop = false;
            // 
            // lblPausa
            // 
            this.lblPausa.AutoSize = true;
            this.lblPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPausa.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPausa.Location = new System.Drawing.Point(9, 195);
            this.lblPausa.Name = "lblPausa";
            this.lblPausa.Size = new System.Drawing.Size(132, 32);
            this.lblPausa.TabIndex = 3;
            this.lblPausa.Text = "ESC: Pausa\r\nENTER: Continuar";
            this.lblPausa.Visible = false;
            // 
            // grbOpciones
            // 
            this.grbOpciones.Controls.Add(this.cbxColor);
            this.grbOpciones.Controls.Add(this.lblColor);
            this.grbOpciones.Controls.Add(this.lblDificultad);
            this.grbOpciones.Controls.Add(this.cbxDificultad);
            this.grbOpciones.ForeColor = System.Drawing.Color.White;
            this.grbOpciones.Location = new System.Drawing.Point(12, 12);
            this.grbOpciones.Name = "grbOpciones";
            this.grbOpciones.Size = new System.Drawing.Size(167, 168);
            this.grbOpciones.TabIndex = 4;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Opciones";
            // 
            // cbxColor
            // 
            this.cbxColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColor.ForeColor = System.Drawing.Color.White;
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Items.AddRange(new object[] {
            "Blanco",
            "Azul",
            "Verde"});
            this.cbxColor.Location = new System.Drawing.Point(20, 116);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(121, 24);
            this.cbxColor.TabIndex = 3;
            this.cbxColor.SelectedIndexChanged += new System.EventHandler(this.cbxColor_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(23, 97);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(42, 16);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // lblDificultad
            // 
            this.lblDificultad.AutoSize = true;
            this.lblDificultad.Location = new System.Drawing.Point(20, 30);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(65, 16);
            this.lblDificultad.TabIndex = 1;
            this.lblDificultad.Text = "Dificultad:";
            // 
            // cbxDificultad
            // 
            this.cbxDificultad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxDificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDificultad.ForeColor = System.Drawing.Color.White;
            this.cbxDificultad.FormattingEnabled = true;
            this.cbxDificultad.Items.AddRange(new object[] {
            "Normal",
            "Difícil"});
            this.cbxDificultad.Location = new System.Drawing.Point(20, 49);
            this.cbxDificultad.Name = "cbxDificultad";
            this.cbxDificultad.Size = new System.Drawing.Size(121, 24);
            this.cbxDificultad.TabIndex = 0;
            this.cbxDificultad.SelectedIndexChanged += new System.EventHandler(this.cbxDificultad_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.grbOpciones);
            this.Controls.Add(this.lblPausa);
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
            this.grbOpciones.ResumeLayout(false);
            this.grbOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGame;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbVidasJugador;
        private System.Windows.Forms.PictureBox picVidasJugador;
        private System.Windows.Forms.GroupBox grbVidasEnemigos;
        private System.Windows.Forms.PictureBox picVidasEnemigos;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.Button btnReintentar;
        private System.Windows.Forms.Label lblPausa;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.Label lblDificultad;
        private System.Windows.Forms.ComboBox cbxDificultad;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbxColor;
    }
}

