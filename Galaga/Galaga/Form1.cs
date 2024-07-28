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

        private string direccionJugador = " ", dificultad = "normal";
        private Color colorJugador = Color.White;

        public Form1()
        {
            InitializeComponent();
            cbxDificultad.SelectedIndex = 0;
            cbxColor.SelectedIndex = 0;

            gameTimer.Interval = 120;
            gameTimer.Tick += new EventHandler(GameLoop);

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            this.KeyPreview = true;
        }

        private void GameLoop(object sender, EventArgs e)
        {
            juego.Jugar(picCanvas, picVidasJugador, picVidasEnemigos, direccionJugador, lblJuego, btnReintentar, btnSalir
                , cbxDificultad, cbxColor);
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
                    //Para el Timer y muestra el mensaje de pausa siempre y cuando el juego este corriendo y no haya terminado
                    gameTimer.Stop();
                    if(lblJuego.Visible == false)
                    {
                        lblJuego.Visible = true;
                        lblJuego.Text = "Pausa";
                        lblJuego.ForeColor = Color.DarkGray;
                    }
                    break;
                case Keys.Enter:
                    //Inicia el juego si no ha sido iniciado
                    if(juego == null)
                    {
                        juego = new Juego(picCanvas, colorJugador, dificultad);
                        grbVidasEnemigos.Visible = true;
                        grbVidasJugador.Visible = true;
                        lblPausa.Visible = true;
                        cbxDificultad.Enabled = false;
                        cbxColor.Enabled = false;
                    }
                    //Reanuda el juego
                    lblJuego.Visible = false;
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
            juego = new Juego(picCanvas, colorJugador, dificultad);
            lblJuego.Visible = false;
            btnReintentar.Visible = false;
            btnReintentar.Enabled = false;
            btnSalir.Visible = false;
            btnSalir.Enabled = false;
            cbxDificultad.Enabled = false;
            cbxColor.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxDificultad.SelectedIndex)
            {
                case 0:
                    dificultad = "normal";
                    break;
                case 1:
                    dificultad = "dificil";
                    break;
            }
        }

        private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxColor.SelectedIndex)
            {
                case 0:
                    colorJugador = Color.White;
                    break;
                case 1:
                    colorJugador = Color.LightSkyBlue;
                    break;
                case 2:
                    colorJugador = Color.LightGreen;
                    break;
            }
        }
    }
}
