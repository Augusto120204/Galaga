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
            
            juego = new Juego(picCanvas);

            gameTimer.Interval = 32;
            gameTimer.Tick += new EventHandler(GameLoop);

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            this.KeyPreview = true;
        }

        private void GameLoop(object sender, EventArgs e)
        {
            juego.Jugar(picCanvas, picVidasJugador, picVidasEnemigos, direccionJugador);
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
    }
}
