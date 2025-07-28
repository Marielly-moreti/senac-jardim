using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    public  class Item : MonoBehaviour
    {
        public char Forma { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public int Tamanho { get; set; }
        public int Valor { get; set; }
        public ConsoleColor Cor { get; set; }
        public int Tempo { get; set; }

        public static int Tomatin = 4;  //2 segundos
        public static int Melaozin = 10;  //5 segundos
        public static int Amoralina = 20;  //10 segundos

        public Item(char forma, string nome, int valor, ConsoleColor cor, int tempo)
        {
            Forma = forma;
            Nome = nome;
            Quantidade = 1;
            Tamanho = 0;
            Valor = valor;
            Cor = cor;
            Tempo = tempo;
        }

        public override void Draw()
        {
            Console.ForegroundColor = Cor;
            Console.SetCursorPosition(x, y);
            Console.Write(Forma);
            Console.ResetColor();
        }

        public override void Update()
        {
            if (Tempo > 0)
            {
                Tempo--;
            }
            else {
                Forma = 'o'; // Representa que o item está em fase de crescimento
                Stop();
            }
        }
    }
}
