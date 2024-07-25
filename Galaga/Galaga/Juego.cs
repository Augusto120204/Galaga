using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaga
{
    internal class Juego
    {
        private Jugador jugador;
        private Enemigo[] enemigos;
        private PointF EnemigoDañado;

        public int tickDisparosEnemigos = 0, tickDañoRecibido = 0, tickDisparosJugador = 0, tickDañoRealizado = 0;
        public bool dañoRecibido = false, dañoRealizado = false;

        private int vidasJugador;
        private int[] vidasEnemigos;

        private Graphics mGraph, mGraphVidasJugador, mGraphVidasEnemigos;

        public Juego(PictureBox picCanvas)
        {
            jugador = new Jugador();
            enemigos = new Enemigo[2];

            enemigos[0] = new Enemigo(Color.LightPink);
            enemigos[1] = new Enemigo(Color.LightSkyBlue);

            vidasJugador = 3;
            vidasEnemigos = new int[] { 3, 3 };

            enemigos[0].PlotEnemigo(picCanvas, new PointF(60, 50));
            enemigos[1].PlotEnemigo(picCanvas, new PointF(picCanvas.Width - 60, 100));
            jugador.PlotJugador(picCanvas, new PointF(picCanvas.Width / 2, picCanvas.Height - 50));
        }

        private void DibujarCorazon(Graphics graph, PointF centroCorazon)
        {
            graph.FillRectangle(new SolidBrush(Color.Red), centroCorazon.X - 5, centroCorazon.Y - 3, 10, 5);
            graph.FillRectangle(new SolidBrush(Color.Red), centroCorazon.X - 4, centroCorazon.Y - 5, 3, 2);
            graph.FillRectangle(new SolidBrush(Color.Red), centroCorazon.X + 1, centroCorazon.Y - 5, 3, 2);
            graph.FillRectangle(new SolidBrush(Color.Red), centroCorazon.X - 4, centroCorazon.Y + 2, 8, 1);
            graph.FillRectangle(new SolidBrush(Color.Red), centroCorazon.X - 3, centroCorazon.Y + 3, 6, 1);
            graph.FillRectangle(new SolidBrush(Color.Red), centroCorazon.X - 2, centroCorazon.Y + 4, 4, 1);
        }

        private void DibujarVidasJugador(PictureBox picVidas)
        {
            picVidas.Refresh();
            mGraphVidasJugador = picVidas.CreateGraphics();
            mGraphVidasJugador.DrawRectangle(new Pen(Color.White, 2), 1, 1, picVidas.Width - 2, picVidas.Height - 2);
            PointF centroPic = new PointF(picVidas.Width / 2, picVidas.Height / 2);
            for (int i = -1; i < vidasJugador - 1; i++)
            {
                DibujarCorazon(mGraphVidasJugador, new PointF(centroPic.X + i * 15, centroPic.Y));
            }
        }

        private void DibujarVidasEnemigos(PictureBox picVidas)
        {
            picVidas.Refresh();
            mGraphVidasEnemigos = picVidas.CreateGraphics();
            mGraphVidasEnemigos.DrawRectangle(new Pen(Color.White, 2), 1, 1, picVidas.Width - 2, picVidas.Height - 2);
            PointF[] centrosPic = new PointF[2] { new PointF(picVidas.Width / 2, picVidas.Height / 4), new PointF(picVidas.Width / 2, picVidas.Height * 3 / 4) };
            for(int j = 0; j < enemigos.Length; j++)
            {
                for (int i = -1; i < vidasEnemigos[j] - 1; i++)
                {
                    DibujarCorazon(mGraphVidasEnemigos, new PointF(centrosPic[j].X + i * 15, centrosPic[j].Y));
                }
            }
        }

        public void Jugar(PictureBox picCanvas, PictureBox picVidasJugador, PictureBox picVidasEnemigos, string direccionJugador)
        {
            picCanvas.Refresh();
            mGraph = picCanvas.CreateGraphics();

            DibujarVidasJugador(picVidasJugador);
            DibujarVidasEnemigos(picVidasEnemigos);

            //Comprobar si los enemigos siguen vivos
            for (int i = 0; i < enemigos.Length; i++)
            {
                if (vidasEnemigos[i] == 0)
                {
                    enemigos[i].Morir();
                }
            }

            //Comprobar si el jugador sigue vivo
            if (vidasJugador == 0)
            {
                mGraph.DrawRectangle(new Pen(Color.Red, 2), 10, 10, picCanvas.Width - 20, picCanvas.Height - 20);
                mGraph.DrawString("GAME OVER", new Font("Arial", 20), new SolidBrush(Color.White), picCanvas.Width / 2 - 90, picCanvas.Height / 2 - 10);
            }
            else
            {
                //Dibujar el marco rojo si recibe daño, el marco roja dura 3 ticks
                if (dañoRecibido)
                {
                    mGraph.DrawRectangle(new Pen(Color.Red, 2), 10, 10, picCanvas.Width - 20, picCanvas.Height - 20);
                    tickDañoRecibido += 1;
                    if (tickDañoRecibido == 3)
                    {
                        dañoRecibido = false;
                        tickDañoRecibido = 0;
                    }
                }
                else
                {
                    mGraph.DrawRectangle(new Pen(Color.White, 2), 10, 10, picCanvas.Width - 20, picCanvas.Height - 20);
                }

                //Mover enemigos y detectar si los enemigos golpearon al jugador
                enemigos[0].Mover(picCanvas, 60, picCanvas.Width - 60);
                enemigos[1].Mover(picCanvas, 60, picCanvas.Width - 60);

                bool dañoRecibido1 = enemigos[0].Disparar(picCanvas, picCanvas.Height - 50, tickDisparosEnemigos, jugador.Centro);
                bool dañoRecibido2 = enemigos[1].Disparar(picCanvas, picCanvas.Height - 50, tickDisparosEnemigos, jugador.Centro);
                tickDisparosEnemigos += 1;

                if (dañoRecibido1 || dañoRecibido2)
                {
                    dañoRecibido = true;
                    vidasJugador -= 1;
                }

                //Mover jugador y detectar si el jugador golpeo a los enemigos
                jugador.Mover(picCanvas, direccionJugador, 50, picCanvas.Width - 50);
                PointF[] posicionesEnemigos = { enemigos[0].Centro, enemigos[1].Centro };

                int enemigoGolpeado = jugador.Disparar(picCanvas, 50, tickDisparosJugador, posicionesEnemigos);
                tickDisparosJugador += 1;

                if (enemigoGolpeado != -1)
                {
                    vidasEnemigos[enemigoGolpeado] -= 1;
                    dañoRealizado = true;
                    EnemigoDañado = enemigos[enemigoGolpeado].Centro;
                }

                //Si el jugador golpeo a un enemigo dibuja un circulo que dura 3 ticks
                if (dañoRealizado)
                {
                    mGraph.FillEllipse(new SolidBrush(Color.Yellow), EnemigoDañado.X - 10, EnemigoDañado.Y - 10, 20, 20);
                    tickDañoRealizado += 1;
                    if(tickDañoRealizado == 3)
                    {
                        dañoRealizado = false;
                        tickDañoRealizado = 0;
                    }
                }

            }

            
        }
    }
}
