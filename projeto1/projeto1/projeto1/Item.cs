using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    public class Item : MonoBehaviour
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

        public static int Tomatin = 20;  //10 segundos
        public static int Melaozin = 40;  //20 segundos
        public static int Amoralina = 60;  //30 segundos

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
            else
            {
                Forma = 'o'; // Representa que o item está em fase de crescimento
                Stop();
            }
        }

        public override void LateUpdate()
        {
            Tomatin = 10;
            Melaozin = 20;
            Amoralina = 30;

            if (Tempo > 0)
            {
                Tempo--;
            }
            else
            {
                Forma = '$'; // Representa que o item está em fase de crescimento
                Stop();
            }
        }

        class Personagem
        {
            List<Item> armazem = new List<Item>();
            public void Update()
            {
                armazem.Add(new Item('T', "Tomatin", 10, ConsoleColor.Red, Item.Tomatin));
                armazem.Add(new Item('M', "Melaozin", 20, ConsoleColor.Yellow, Item.Melaozin));
                armazem.Add(new Item('A', "Amoralina", 30, ConsoleColor.Magenta, Item.Amoralina));
            }
        }
    }
}
