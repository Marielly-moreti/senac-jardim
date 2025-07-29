using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    public class Menu : MonoBehaviour
    {
        private Menu()
        {
            Run();
        }
        static private Menu instancia;
        static public Menu Instancia => instancia ??= new Menu();

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


                    GameManager.Instancia.jardim = Jardim.Instancia;
                    GameManager.Instancia.jardim.visible = true;
                    GameManager.Instancia.jardim.input = true;

                    break;

                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Não implementado");
                    Console.WriteLine("Aperte qualquer tecla para voltar");
                    Console.ReadKey(true);
                    break;

                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Environment.Exit(0);
                    break;
            }
            
        }



        public override void Draw()
        {
            Console.Clear();
            
            Console.WriteLine("Jardinzinho da Silva");
            Console.WriteLine("Play - 1");
            Console.WriteLine("Opçoes - 2");
            Console.WriteLine("Sair - 3");
            
        }
    }
}
