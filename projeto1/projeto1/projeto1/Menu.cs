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


        public string tecla;

        Jardim fazenda = Jardim.Instancia;

        public override void Update()
        {
            if (!input) return;
            tecla = Console.ReadLine();
            GameManager.Instancia.jardim = fazenda;

            string escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":
                GameManager.Instancia.visible = false;
                GameManager.Instancia.input = false;
                fazenda.ComprarSemente();
                break;

                case "2":
                fazenda.Run();
                break;

                case "5":
                fazenda.VerArmazem();
                break;
            }
        }



        public override void Draw()
        {            
                Console.WriteLine("Jardinzinho da Silva");
                Console.WriteLine("Play - 1");
                Console.WriteLine("Opçoes - 2");
                Console.WriteLine("Sair - 3");
 

            if (tecla == "1")
            {
                Console.Clear();     
               

                Console.WriteLine("Moedinhas: " + fazenda.carteira);
                Console.WriteLine("1 - Comprar Semente");
                Console.WriteLine("2 - Plantar");
                Console.WriteLine("3 - Regar");
                Console.WriteLine("4 - Colher");
                Console.WriteLine("5 - Ver armazem");
           
            }   
        }
    }
}
