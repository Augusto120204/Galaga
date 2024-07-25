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
        private float velocidad = 10, frecuenciaDisparo = 27, velocidadDisparo = 15;
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

            //mGraph.DrawRectangle(new Pen(Color.White, 2), centro.X - 20, centro.Y - 10, 40, 20); <- hitbox

            //Dibujar los lados del enemigo
            mGraph.DrawLine(mPen, centro.X - 20, centro.Y - 6, centro.X - 20, centro.Y - 3);
            mGraph.DrawLine(mPen, centro.X + 20, centro.Y - 6, centro.X + 20, centro.Y - 3);

            //Dibuja la base del enemigo
            mGraph.DrawLine(mPen, centro.X - 20, centro.Y - 6, centro.X - 16, centro.Y - 10);
            mGraph.DrawLine(mPen, centro.X + 20, centro.Y - 6, centro.X + 16, centro.Y - 10);
            mGraph.DrawLine(mPen, centro.X - 16, centro.Y - 10, centro.X + 17, centro.Y - 10);

            //Dibuja la base de los cuernos del enemigo
            mGraph.DrawLine(mPen, centro.X - 20, centro.Y - 1, centro.X - 20, centro.Y + 4);
            mGraph.DrawLine(mPen, centro.X + 20, centro.Y - 1, centro.X + 20, centro.Y + 4);
            mGraph.DrawLine(mPen, centro.X - 18, centro.Y - 2, centro.X - 10, centro.Y - 2);
            mGraph.DrawLine(mPen, centro.X + 18, centro.Y - 2, centro.X + 10, centro.Y - 2);
            mGraph.DrawLine(mPen, centro.X - 9, centro.Y - 1, centro.X - 9, centro.Y + 4);
            mGraph.DrawLine(mPen, centro.X + 9, centro.Y - 1, centro.X + 9, centro.Y + 4);

            //Dibuja los cuernos del enemigo
            mGraph.DrawLine(mPen, centro.X - 13, centro.Y + 10, centro.X - 9, centro.Y + 3);
            mGraph.DrawLine(mPen, centro.X + 13, centro.Y + 10, centro.X + 8, centro.Y + 3);
            mGraph.DrawLine(mPen, centro.X - 13, centro.Y + 10, centro.X - 20, centro.Y + 3);
            mGraph.DrawLine(mPen, centro.X + 13, centro.Y + 10, centro.X + 20, centro.Y + 3);

            //Dibuja el centro del enemigo
            mGraph.DrawLine(mPen, centro.X - 7, centro.Y - 1, centro.X - 5, centro.Y + 1);
            mGraph.DrawLine(mPen, centro.X + 7, centro.Y - 1, centro.X + 5, centro.Y + 1);
            mGraph.DrawLine(mPen, centro.X - 5, centro.Y + 1, centro.X + 5, centro.Y + 1);

        }

        public void Mover(PictureBox picCanvas, float limiteIzq, float limiteDer)
        {
            if (vivo)
            {
                if (moverDerecha)
                {
                    //Mueve al enemigo hacia la derecha hasta que llegue al limete derecho
                    centro.X += velocidad;
                    if (centro.X > limiteDer)
                    {
                        moverDerecha = false;
                    }
                }
                else
                {
                    //Mueve al enemigo hacia la izquierda hasta que llegue al limete izquierdo
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
                //Recorre el Array de disparos
                for (int i = 0; i < disparos.Length; i++)
                {
                    if (!disparado[i] && tick >= frecuenciaDisparo * i) //Comparar si aun no a sido disparado y si es el momento de disparar
                    {
                        disparos[i] = new PointF(centro.X, centro.Y);
                        disparado[i] = true;
                    }
                    else
                    {
                        disparos[i].Y += velocidadDisparo;

                        //Comprueba si el disparo golpeo al jugador
                        bool colision = disparos[i].X >= jugador.X - 10 && disparos[i].X <= jugador.X + 10
                            && disparos[i].Y + 25 >= jugador.Y - 10 && disparos[i].Y + 25 <= jugador.Y + 10;

                        //Reinicia el disparo si llega al limite inferior o si golpeo al jugaodr
                        if (disparos[i].Y + 25 > limiteInf || colision)
                        {
                            disparado[i] = false;
                        }

                        if (colision)
                        {
                            return true;
                        }
                    }
                    mGraph = picCanvas.CreateGraphics();
                    mGraph.DrawLine(mPen, disparos[i].X, disparos[i].Y, disparos[i].X, disparos[i].Y + 25);
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
