using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaga
{
    internal class Jugador
    {
        private PointF centro;
        private float velocidad = 10, velocidadDisparo = 15;

        private Graphics mGraph;
        private Pen mPen;

        private bool disparado;
        private PointF disparo;

        public Jugador()
        {
            centro.X = 0;
            centro.Y = 0;
        }

        public PointF Centro
        {
            get { return centro; }
            set { centro = value; }
        }

        public void PlotJugador(PictureBox picCanvas, PointF puntoInicial = new PointF())
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.LightGreen, 2);

            if (centro.X == 0 && centro.Y == 0)
            {
                centro.X = puntoInicial.X;
                centro.Y = puntoInicial.Y;
            }

            mGraph.DrawRectangle(mPen, centro.X - 10, centro.Y - 10, 20, 20);
        }

        public void Mover(PictureBox picCanvas, string direccion, float limiteIzq, float limiteDer)
        {
            switch (direccion)
            {
                case "izquierda":
                    if(centro.X - velocidad > limiteIzq)
                        centro.X -= velocidad;
                    PlotJugador(picCanvas);
                    break;
                case "derecha":
                    if(centro.X + velocidad < limiteDer)
                        centro.X += velocidad;
                    PlotJugador(picCanvas);
                    break;
                case " ":
                    PlotJugador(picCanvas);
                    break;
            }
        }

        public int Disparar(PictureBox picCanvas, float limiteSup, PointF[] enemigos)
        {
            bool colision = false;
            int enemigoGolpeado = -1;
            mGraph = picCanvas.CreateGraphics();

            if (!disparado)
            {
                disparo = new PointF(centro.X, centro.Y);
                disparado = true;
            }
            else
            {
                disparo.Y -= velocidadDisparo;

                for (int i = 0; i < enemigos.Length; i++)
                {
                    if (disparo.X >= enemigos[i].X - 10 && disparo.X <= enemigos[i].X + 10 &&
                        disparo.Y - 10 >= enemigos[i].Y - 10 && disparo.Y - 10 <= enemigos[i].Y + 10)
                    {
                        colision = true;
                        enemigoGolpeado = i;
                    }
                }

                if (disparo.Y < limiteSup || colision)
                {
                    disparado = false;
                }
            }

            mGraph.DrawLine(mPen, disparo.X, disparo.Y, disparo.X, disparo.Y - 10);

            return enemigoGolpeado;
        }
    }
}
