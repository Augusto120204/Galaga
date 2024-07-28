using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Galaga
{
    internal class Jugador
    {
        private PointF centro;
        private float velocidad = 15, frecuenciaDisparo = 5, velocidadDisparo = 19;
        private bool invulnerable = false; 

        private Graphics mGraph;
        private Pen mPen;

        private PointF[] disparos = new PointF[3];
        private bool[] disparado = new bool[3];

        public Jugador(Color color)
        {
            centro.X = 0;
            centro.Y = 0;
            mPen = new Pen(color, 2);
        }

        public PointF Centro
        {
            get { return centro; }
            set { centro = value; }
        }

        public bool Invulnerable
        {
            get { return invulnerable; }
            set { invulnerable = value; }
        }

        public void InvocarJugador(PictureBox picCanvas, PointF puntoInicial = new PointF())
        {
            mGraph = picCanvas.CreateGraphics();

            if (centro.X == 0 && centro.Y == 0)
            {
                centro.X = puntoInicial.X;
                centro.Y = puntoInicial.Y;
            }

            //mGraph.DrawRectangle(new Pen(Color.LightPink), centro.X - 10, centro.Y - 10, 20, 20); <- hitbox

            mGraph.DrawPolygon(mPen, new PointF[] { new PointF(centro.X - 10, centro.Y + 10), new PointF(centro.X, centro.Y - 10), new PointF(centro.X + 10, centro.Y + 10) });
            mGraph.DrawPolygon(mPen, new PointF[] { new PointF(centro.X - 4, centro.Y + 10), new PointF(centro.X, centro.Y), new PointF(centro.X + 4, centro.Y + 10) });

            mGraph.DrawRectangle(mPen, centro.X - 10, centro.Y, 4, 10);
            mGraph.DrawRectangle(mPen, centro.X + 6, centro.Y, 4, 10);
            mGraph.DrawRectangle(mPen, centro.X - 10, centro.Y - 7, 4, 17);
            mGraph.DrawRectangle(mPen, centro.X + 6, centro.Y - 7, 4, 17);

        }

        public void Mover(PictureBox picCanvas, string direccion, float limiteIzq, float limiteDer)
        {
            switch (direccion)
            {
                case "izquierda":
                    if(centro.X - velocidad > limiteIzq)
                        centro.X -= velocidad;
                    InvocarJugador(picCanvas);
                    break;
                case "derecha":
                    if(centro.X + velocidad < limiteDer)
                        centro.X += velocidad;
                    InvocarJugador(picCanvas);
                    break;
                case " ":
                    InvocarJugador(picCanvas);
                    break;
            }
        }

        public int Disparar(PictureBox picCanvas, float limiteSup, int tick, PointF[] enemigos)
        { 
            int enemigoGolpeado = -1;
            mGraph = picCanvas.CreateGraphics();

            //Recorre el Array de disparos
            for (int i = 0; i < disparos.Length; i++)
            {
                bool colision = false;
                if (!disparado[i] && tick > frecuenciaDisparo * i) //Comparar si aun no a sido disparado y si es el momento de disparar
                {
                    disparos[i] = new PointF(centro.X, centro.Y);
                    disparado[i] = true;
                }
                else
                {
                    disparos[i].Y -= velocidadDisparo;

                    //Comprueba si alguno de los disparo golpeo a un enemigo y regresa su indice
                    for (int j = 0; j < enemigos.Length; j++)
                    {
                        if (disparos[i].X >= enemigos[j].X - 20 && disparos[i].X <= enemigos[j].X + 20 &&
                            disparos[i].Y - 25 >= enemigos[j].Y - 10 && disparos[i].Y - 25 <= enemigos[j].Y + 10)
                        {
                            colision = true;
                            enemigoGolpeado = j;
                        }
                    }

                    //Reinicia el disparo si llega al limite superior o si golpeo a un enemigo
                    if (disparos[i].Y - 25 < limiteSup || colision)
                    {
                        disparado[i] = false;
                    }
                }
                mGraph = picCanvas.CreateGraphics();
                mGraph.DrawLine(mPen, disparos[i].X, disparos[i].Y, disparos[i].X, disparos[i].Y - 25);
            }

            return enemigoGolpeado;
        }
    }
}
