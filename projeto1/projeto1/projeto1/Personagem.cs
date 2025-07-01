using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    class Personagem
    {
        public int armazemTomatin = 0;
        public int armazemMelaozin = 0;
        public int armazemAmoralina = 0;
        public int carteira = 300;
        public int tomatin = 0;
        public int melaozin = 0;
        public int amoralina = 0;
        public int[] Slot = [1, 2, 3, 4, 5, 6];

        public int tomatinPreço = 50;
        public int melaozinPreço = 100;
        public int amoralinaPreço = 200;

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
                armazemTomatin++;
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
                armazemMelaozin++;
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
                armazemAmoralina++;
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
            Console.Clear();
            Console.WriteLine("Selecione um Slot");
            Console.WriteLine("--------");
            Console.WriteLine("Slot - 1");
            Console.WriteLine("Slot - 2");
            Console.WriteLine("Slot - 3");
            Console.WriteLine("Slot - 4");
            Console.WriteLine("Slot - 5");
            Console.WriteLine("Slot - 6");
            Console.WriteLine("--------");
            string plantacao = Console.ReadLine();
        }


        public void VerArmazem()
        {
            Console.Clear();
            Console.WriteLine("--------------");
            Console.WriteLine("tomatin: " + armazemTomatin);
            Console.WriteLine("--------------");
            Console.WriteLine("melaozin: " + armazemMelaozin);
            Console.WriteLine("--------------");
            Console.WriteLine("amoralina: " + armazemAmoralina);
            Console.WriteLine("--------------");
            Console.WriteLine("Aperte enter para voltar <-- ('_')");
            string sairArmazem = Console.ReadLine();
        }

    }
}
