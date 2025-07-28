using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    public class Mapa: MonoBehaviour
    {
        private Mapa() 
        {
            Run();
        }
        static private Mapa instancia;
        static public Mapa Instancia => instancia ??= new Mapa();

        public char[,] mapa;
        public int largura = 20;
        public int altura = 10;
        public override void Start() 
        {
        iniciarmapa();
        }
        public void iniciarmapa()
        {
            mapa = new char[largura, altura];
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    // ultima posição do vetor é tamanho -1
                    if (x == 0 || y == 0 || x == largura - 1 || y == altura - 1)
                    {
                        mapa[x, y] = '#';

                    }
                    else
                    {
                        mapa[x, y] = ' ';
                    }
                }

            }

            mapa[1, 1] = 'H';
        }
       public override void Update() 
       {

       }
       public override void Draw()
        {
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    Console.Write(mapa[x, y]);
                }

                Console.WriteLine();
            }

            foreach (var item in Jardim.Instancia.armazem)
            {
                item.Draw();
            }

            Console.SetCursorPosition(Jardim.Instancia.pos.x, Jardim.Instancia.pos.y);
            Console.Write('@');
        }
    }
}
