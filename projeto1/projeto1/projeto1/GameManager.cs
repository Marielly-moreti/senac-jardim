using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    class GameManager
    {
        private GameManager() { } 
        static private GameManager instancia;
        static public GameManager Instancia => instancia ??= new GameManager(); 

        public void Start()
        {
            Jardim fazenda = new Jardim();




            bool acontecendo = true;

            Console.WriteLine("Jardinzinho da Silva");
            Console.WriteLine("Play - 1");
            Console.WriteLine("Opçoes - 2");
            Console.WriteLine("Sair - 3");
            string tecla = Console.ReadLine();

            while (acontecendo)
            {
                if (tecla == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Moedinhas: " + fazenda.carteira);
                    Console.WriteLine("1 - Comprar Semente");
                    Console.WriteLine("2 - Plantar");
                    Console.WriteLine("3 - Regar");
                    Console.WriteLine("4 - Colher");
                    Console.WriteLine("5 - Ver armazem");
                    string escolha = Console.ReadLine();

                    if (escolha == "1")
                    {
                        fazenda.ComprarSemente();

                    }

                    if (escolha == "2")
                    {
                        fazenda.Plantar();

                    }

                    if (escolha == "5")
                    {
                        fazenda.VerArmazem();


                    }
                }


            }


        }


    }
}
