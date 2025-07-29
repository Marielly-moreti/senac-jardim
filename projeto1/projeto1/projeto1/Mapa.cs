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



        public Vector2 pos = new Vector2(2, 2);
        public override void Start() 
        {
            iniciarmapa();
        }
        private void iniciarmapa()
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



        private void EscolherEPlantar()
        {
            Console.Clear();
            int i = 0;
            foreach (var item in GameManager.Instancia.jardim.armazem)
            {
                Console.WriteLine("" + i + " - " + item.Nome + " (" + item.Quantidade + ")");
                i++;
            }
            Console.WriteLine("Escolha uma semente para plantar (ou pressione 'E' para voltar):");
            var tecla = Console.ReadKey(true).Key;
            switch (tecla)
            {
                case ConsoleKey.E: return;
                default:
                    int index = TransformeEmNumero(tecla);
                    if (index < 0 || index >= GameManager.Instancia.jardim.armazem.Count)
                    {
                        Console.WriteLine("Opção inválida. Tente novamente. \n Aperte qualquer tecla para voltar");
                        Console.ReadKey(true);
                        return;
                    }
                    if (GameManager.Instancia.jardim.armazem[index].Quantidade < 1)
                    {
                        Console.WriteLine("Você não tem sementes suficientes para plantar.\n Aperte qualquer tecla para voltar");
                        Console.ReadKey(true);
                        return;
                    }
                    GameManager.Instancia.jardim.armazem[index].Quantidade--;
                    GameManager.Instancia.jardim.armazem[index].x = pos.x;
                    GameManager.Instancia.jardim.armazem[index].y = pos.y;
                    GameManager.Instancia.jardim.armazem[index].Run();
                    break;
            }
            Console.Clear();
            visible = true;
            input = true;
        }




        public int TransformeEmNumero(ConsoleKey tecla)
        {
            if (tecla >= ConsoleKey.D0 && tecla <= ConsoleKey.D9)
            {
                return (int)tecla - (int)ConsoleKey.D0;
            }
            else if (tecla >= ConsoleKey.NumPad0 && tecla <= ConsoleKey.NumPad9)
            {
                return (int)tecla - (int)ConsoleKey.NumPad0;
            }
            return -1;
        }


        public void AtualizarPosicao(ConsoleKey tecla)
        {
            int oldX = pos.x;
            int oldY = pos.y;
            int x = pos.x;
            int y = pos.y;

            switch (tecla)
            {
                case ConsoleKey.A: x = pos.Left; break;
                case ConsoleKey.D: x = pos.Right; break;
                case ConsoleKey.W: y = pos.Up; break;
                case ConsoleKey.S: y = pos.Down; break;
                case ConsoleKey.E:
                    visible = false;
                    input = false;
                    EscolherEPlantar(); 
                    break;
            }

            if (Mapa.Instancia.mapa[x, y] == '#')
            {
                pos.x = oldX;
                pos.y = oldY;
            }

            if (pos.x == 1 && pos.y == 1)
            {
                visible = false;
                input = false;

                GameManager.Instancia.jardim = Jardim.Instancia;
                GameManager.Instancia.jardim.visible = true;
                GameManager.Instancia.jardim.input = true;
            }
        }
        public override void Update() 
        {
            if (!input) return;
            ConsoleKey tecla = Console.ReadKey(true).Key;

            AtualizarPosicao(tecla);

        }

        public override void Draw()
        {
            Console.SetCursorPosition(0,0);
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    Console.Write(mapa[x, y]);
                }

                Console.WriteLine();
            }

            foreach (var item in GameManager.Instancia.jardim.armazem)
            {
                item.Draw();
            }

            Console.SetCursorPosition(GameManager.Instancia.mapa.pos.x, GameManager.Instancia.mapa.pos.y);
            Console.Write('@');
        }
    }
}
