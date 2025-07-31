using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{

    public class Jardim : MonoBehaviour
    {
        private Jardim() 
        {
            Run();
        }
        static private Jardim instancia;
        static public Jardim Instancia => instancia ??= new Jardim();

        public int carteira = 150;
        public int tomatin = 0;
        public int melaozin = 0;
        public int amoralina = 0;
        public List<Item> armazem = new List<Item>();

        public int tomatinPreço = 50;
        public int melaozinPreço = 100;
        public int amoralinaPreço = 200;


        public override void Draw() {
            Console.Clear();
            Console.WriteLine("Moedinhas: " + GameManager.Instancia.jardim.carteira);
            Console.WriteLine("1 - Comprar Semente");
            Console.WriteLine("2 - Plantar");
            Console.WriteLine("3 - Ver armazem");
        }

        public override void Update()
        {
            if (!input) return;

            ConsoleKey tecla = Console.ReadKey(true).Key;
            switch (tecla)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    visible = false;
                    input = false;

                    ComprarSemente();
                    break;

                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    visible = false;
                    input = false;

                    GameManager.Instancia.mapa = Mapa.Instancia;
                    GameManager.Instancia.mapa.visible = true;
                    GameManager.Instancia.mapa.input = true;
                    break;

                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    visible = false;
                    input = false;
                    VerArmazem();
                    break;
            }
        }

        private void ComprarSemente()
        {
            Console.Clear();
            Console.WriteLine("Moedinhas: " + carteira);
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - tomatin = 50$");
            Console.WriteLine("2 - melaozin = 100$");
            Console.WriteLine("3 - amoralina = 200$");
            Console.WriteLine("--------------------");
            Console.WriteLine("4 - voltar");
            
            ConsoleKey tecla = Console.ReadKey(true).Key;


            switch (tecla)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    comprarTomatin();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    comprarMelaozin();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    comprarAmoralina();
                    break;
            }
            visible = true;
            input = true;

        }

        private void comprarTomatin()
        {
            if (carteira >= tomatinPreço)
            {
                Item semente_tomatin = new Item('.',"tomatin",50,ConsoleColor.Red, Item.Tomatin);
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

        private void comprarMelaozin()
        {
            if (carteira >= melaozinPreço)
            {
                Item semente_melaozin = new Item('.', "melaozin", 100, ConsoleColor.Yellow, Item.Melaozin);
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

        private void comprarAmoralina()
        {
            if (carteira >= amoralinaPreço)
            {
                Item semente_amoralina = new Item('.', "amoralina", 200, ConsoleColor.Magenta, Item.Amoralina);
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
       
        private void VerArmazem()
        {
            Console.Clear();
            Console.WriteLine("--------------");
            Console.WriteLine("tomatin: " + armazem);
            Console.WriteLine("--------------");
            Console.WriteLine("melaozin: " + armazem);
            Console.WriteLine("--------------");
            Console.WriteLine("amoralina: " + armazem);
            Console.WriteLine("--------------");
            Console.WriteLine("Aperte qualquer tecla para voltar <-- ('_')");
            Console.ReadKey(true);
            visible = true;
            input = true;
        }

       


    }

}
