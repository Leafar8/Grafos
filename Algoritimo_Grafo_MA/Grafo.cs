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

        public Grafo(int qtVertices)
        {
            this.qtVertices = qtVertices;
        }

        public int Ordem()
        {
            return qtVertices;
        }


    }
}
