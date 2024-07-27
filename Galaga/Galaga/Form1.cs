using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaga
{
    public partial class Form1 : Form
    {
        private Timer gameTimer = new Timer();

        private Juego juego;

        private string direccionJugador = " ";

        public Form1()
        {
            InitializeComponent();
            cbxDificultad.SelectedIndex = 0;
            cbxColor.SelectedIndex = 0;
            
            juego = new Juego(picCanvas, Color.White);

            gameTimer.Interval = 64;
            gameTimer.Tick += new EventHandler(GameLoop);

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            this.KeyPreview = true;
        }

        private void GameLoop(object sender, EventArgs e)
        {
            juego.Jugar(picCanvas, picVidasJugador, picVidasEnemigos, direccionJugador, lblJuego, btnReintentar, btnSalir);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    direccionJugador = "izquierda";
                    break;
                case Keys.D:
                    direccionJugador = "derecha";
                    break;
                case Keys.Escape:
                    gameTimer.Stop();
                    break;
                case Keys.Enter:
                    lblJuego.Visible = false;
                    grbVidasEnemigos.Visible = true;
                    grbVidasJugador.Visible = true;
                    lblPausa.Visible = true;
                    gameTimer.Start();
                    break;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    direccionJugador = " ";
                    break;
                case Keys.D:
                    direccionJugador = " ";
                    break;
            }
        }

        private void btnReintentar_Click(object sender, EventArgs e)
        {
            juego = new Juego(picCanvas, Color.White);
            lblJuego.Visible = false;
            btnReintentar.Visible = false;
            btnReintentar.Enabled = false;
            btnSalir.Visible = false;
            btnSalir.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
