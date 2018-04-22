using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimo_Grafo_MA
{
    public class Grafo
    {
        private int[,] MA;
        private int qtVertices;

        //Metodo construtor que inicializa a matriz.
        public Grafo(int qtVertices)
        {
            this.qtVertices = qtVertices;
        }

        //Método que retorna a ordem do grafo.
        public int Ordem()
        {
            return qtVertices;
        }
        //Método que imprime a matriz.
        public void ShowMA(int l, int c)
        {
            for (int i = 0;i < l; l++)
            {
                for (int j = 0; j < c; c++)
                {
                    Console.WriteLine(c.ToString(),l);
                }
            }
        }

    }
}
