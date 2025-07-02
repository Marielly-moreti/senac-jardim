using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    class Item
    {
        public char Forma { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public int Tamanho { get; set; }
        public int Valor { get; set; }
        public ConsoleColor Cor { get; set; }

        public Item(char forma, string nome, int valor, ConsoleColor cor)
        {
            Forma = forma;
            Nome = nome;
            Quantidade = 1;
            Tamanho = 0;
            Valor = valor;
            Cor = cor;
        }

        public void desenhar()
        {
            Console.ForegroundColor = Cor;
            Console.SetCursorPosition(x, y);
            Console.Write(Forma);
            Console.ResetColor();
        }
    }
}
