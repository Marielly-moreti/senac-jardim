using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    class Jardim
    {
        public int carteira = 150;
        public int tomatin = 0;
        public int melaozin = 0;
        public int amoralina = 0;
        public List<Item> armazem = new List<Item>();

        public int tomatinPreço = 50;
        public int melaozinPreço = 100;
        public int amoralinaPreço = 200;

        public char[,] mapa;
        public int largura = 20;
        public int altura = 10;
        public int playerX = 2;
        public int playerY = 2;

        public Jardim()
        {
            iniciarmapa();
        }

        public void ComprarSemente()
        {
            Console.Clear();
            Console.WriteLine("Moedinhas: " + carteira);
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - tomatin = 50$");
            Console.WriteLine("2 - melaozin = 100$");
            Console.WriteLine("3 - amoralina = 200$");
            Console.WriteLine("--------------------");
            Console.WriteLine("4 - voltar");
            string comprinhas = Console.ReadLine();


            switch (comprinhas)
            {
                case "1":
                    comprarTomatin();
                    break;
                case "2":
                    comprarMelaozin();
                    break;
                case "3":
                    comprarAmoralina();
                    break;
                case "4":
                    Console.Clear();
                    break;

            }

        }

        void comprarTomatin()
        {
            if (carteira >= tomatinPreço)
            {
                Item semente_tomatin = new Item('.',"tomatin",50,ConsoleColor.Red);
                armazem.Add(semente_tomatin);
                int resultado = carteira - tomatinPreço;
                carteira = resultado;
            }
            else
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Você não tem moedinhas suficientes... (Faz o L ^_^)");
                Console.WriteLine("---------------------------------------------------");
                string comprinhas2 = Console.ReadLine();
            }
        }

        void comprarMelaozin()
        {
            if (carteira >= melaozinPreço)
            {
                Item semente_melaozin = new Item('.', "melaozin", 100, ConsoleColor.Yellow);
                armazem.Add(semente_melaozin);
                int resultado = carteira - melaozinPreço;
                carteira = resultado;
            }
            else
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Você não tem moedinhas suficientes... (Faz o L ^_^)");
                Console.WriteLine("---------------------------------------------------");
                string comprinhas2 = Console.ReadLine();
            }
        }

        void comprarAmoralina()
        {
            if (carteira >= amoralinaPreço)
            {
                Item semente_amoralina = new Item('.', "amoralina", 200, ConsoleColor.Magenta);
                armazem.Add(semente_amoralina);
                int resultado = carteira - amoralinaPreço;
                carteira = resultado;
            }
            else
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Você não tem moedinhas suficientes... (Faz o L ^_^)");
                Console.WriteLine("---------------------------------------------------");
                string comprinhas2 = Console.ReadLine();
            }
        }


        public void Plantar()
        {
            
            do { 
                Console.Clear();
                DesenharMapa();
                var tecla = Console.ReadKey(true).Key;
                AtualizarPosicao(tecla);
            } while (playerX != 1 && playerY != 1);

        }

        void AtualizarPosicao(ConsoleKey tecla)
        {
            int tempX = playerX;
            int tempY = playerY;

            switch (tecla)
            {
                case ConsoleKey.A: tempX--; break;
                case ConsoleKey.D: tempX++; break;
                case ConsoleKey.W: tempY--; break;
                case ConsoleKey.S: tempY++; break;
                case ConsoleKey.E: EscolherSemente(); break;
            }
            if (mapa[tempX, tempY] == ' ')
            {
                mapa[playerX, playerY] = ' ';
                mapa[tempX, tempY] = '@';

                playerX = tempX;
                playerY = tempY;
            }
        }
        void EscolherSemente()
        {
            Console.Clear();
            int i= 0;
            foreach (var item in armazem)
            {
                Console.WriteLine(""+i + " - " + item.Nome + " (" + item.Quantidade + ")");
                i++;
            }
            Console.WriteLine("Escolha uma semente para plantar (ou pressione 'E' para voltar):");
            var tecla = Console.ReadKey(true).Key;
            switch (tecla)
            {
                case ConsoleKey.E: return;
                default:
                    int index = TransformeEmNumero(tecla);
                    if (index < 0 || index >= armazem.Count)
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        return;
                    }
                    armazem[index].Quantidade--;
                    armazem[index].x = playerX;
                    armazem[index].y = playerY;
                    break;
            }
        }


        int TransformeEmNumero(ConsoleKey tecla)
        {
            if (tecla >= ConsoleKey.D0 && tecla <= ConsoleKey.D9)
            {
                return (int)tecla - (int)ConsoleKey.D0;
            }
            else if (tecla >= ConsoleKey.NumPad0 && tecla <= ConsoleKey.NumPad9) {
                return (int)tecla - (int)ConsoleKey.NumPad0;
            }
            return -1;
        }

        void iniciarmapa()
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

            mapa[playerX, playerY] = '@';
        }

        void DesenharMapa()
        {
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    Console.Write(mapa[x, y]);
                }

                Console.WriteLine();
            }

            foreach (var item in armazem)
            {
                item.desenhar();
            }
        }

        public void VerArmazem()
        {
            Console.Clear();
            Console.WriteLine("--------------");
            //Console.WriteLine("tomatin: " + armazemTomatin);
            Console.WriteLine("--------------");
            //Console.WriteLine("melaozin: " + armazemMelaozin);
            Console.WriteLine("--------------");
            //Console.WriteLine("amoralina: " + armazemAmoralina);
            Console.WriteLine("--------------");
            Console.WriteLine("Aperte enter para voltar <-- ('_')");
            string sairArmazem = Console.ReadLine();
        }

    }

}
