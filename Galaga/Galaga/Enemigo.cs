using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaga
{
    internal class Enemigo
    {
        private PointF centro;
        private float velocidad = 7, frecuenciaDisparo = 27, velocidadDisparo = 7;
        private bool vivo = true;

        private Graphics mGraph;
        private Pen mPen;
        private bool moverDerecha;

        private PointF[] disparos = new PointF[3];
        private bool[] disparado = new bool[3];

        public Enemigo(Color color)
        {
            centro = new PointF(0,0);
            mPen = new Pen(color, 2);
        }

        public PointF Centro
        {
            get { return centro; }
            set { centro = value; }
        }

        public void PlotEnemigo(PictureBox picCanvas, PointF puntoInicial = new PointF())
        {
            mGraph = picCanvas.CreateGraphics();
            if (centro.X == 0 && centro.Y == 0)
            {
                centro.X = puntoInicial.X;
                centro.Y = puntoInicial.Y;
            }

            mGraph.DrawRectangle(mPen, centro.X - 20, centro.Y - 10, 40, 20);
            mGraph.DrawLine(mPen, centro.X - 20, centro.Y - 6, centro.X - 20, centro.Y - 2);
            mGraph.DrawLine(mPen, centro.X + 20, centro.Y - 6, centro.X + 20, centro.Y - 2);
        }

        public void Mover(PictureBox picCanvas, float limiteIzq, float limiteDer)
        {
            if (vivo)
            {
                if (moverDerecha)
                {
                    centro.X += velocidad;
                    if (centro.X > limiteDer)
                    {
                        moverDerecha = false;
                    }
                }
                else
                {
                    centro.X -= velocidad;
                    if (centro.X < limiteIzq)
                    {
                        moverDerecha = true;
                    }
                }
                PlotEnemigo(picCanvas);
            }
        }

        public bool Disparar(PictureBox picCanvas, float limiteInf, int tick, PointF jugador)
        {
            if (vivo)
            {
                for (int i = 0; i < disparos.Length; i++)
                {
                    if (!disparado[i] && tick >= frecuenciaDisparo * i) //comparar si aun no a sido disparado y si es el momento de disparar
                    {
                        disparos[i] = new PointF(centro.X, centro.Y);
                        disparado[i] = true;
                    }
                    else
                    {
                        bool colision = disparos[i].X >= jugador.X - 10 && disparos[i].X <= jugador.X + 10
                            && disparos[i].Y + 10 >= jugador.Y - 10 && disparos[i].Y + 10 <= jugador.Y + 10;

                        disparos[i].Y += velocidadDisparo;

                        if (disparos[i].Y > limiteInf || colision)
                        {
                            disparado[i] = false;

                            if (i == disparos.Length - 1)
                            {
                                tick = 0;
                            }
                        }
                        if (colision)
                        {
                            return true;
                        }
                    }
                    mGraph = picCanvas.CreateGraphics();
                    mGraph.DrawLine(mPen, disparos[i].X, disparos[i].Y, disparos[i].X, disparos[i].Y + 10);
                }
            }
            return false;
        }

        public void Morir()
        {
            vivo = false;
        }
    }
}
