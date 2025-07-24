            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{

    class Jardim : MonoBehaviour
    {
        private Jardim() { }
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

       
        Vector2 pos = new Vector2(2, 2);

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

        void comprarMelaozin()
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

        void comprarAmoralina()
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


        public override void Update()
        {
            Console.Clear();
            DesenharMapa();
            var tecla = Console.ReadKey(true).Key;
            AtualizarPosicao(tecla);
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
                case ConsoleKey.E: EscolherEPlantar(); break;
            }

            if (Mapa[x, y] == '#')
            {
                pos.x = oldX;
                pos.y = oldY;
            }

            if(pos.x == 1 && pos.y == 1)
            {
                Stop();
            }
        }

        void EscolherEPlantar()
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
                        Console.WriteLine("Opção inválida. Tente novamente. \n Aperte qualquer tecla para voltar");
                        Console.ReadKey(true);
                        return;
                    }
                    if (armazem[index].Quantidade < 1)
                    {
                        Console.WriteLine("Você não tem sementes suficientes para plantar.\n Aperte qualquer tecla para voltar");
                        Console.ReadKey(true);
                        return;
                    }
                    armazem[index].Quantidade--;
                    armazem[index].x = pos.x; 
                    armazem[index].y = pos.y;
                    armazem[index].Run();
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
