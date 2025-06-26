using System;

namespace projeto1
{
    class JardimC
    {
        static void Main()


        {
            /*
            if () { }
            else if { }
            else { }
            */

            int armazemTomatin = 0;
            int armazemMelaozin = 0;
            int armazemAmoralina = 0;
            int carteira = 100;
            int tomatin = 0;
            int melaozin = 0;
            int amoralina = 0;
            int[] Slot = [1,2,3,4,5,6]; 

            int tomatinPreço = 50;
            int melaozinPreço = 100;
            int amoralinaPreço = 200;



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
                    Console.WriteLine("Moedinhas: " + carteira);
                    Console.WriteLine("1 - Comprar semente");
                    Console.WriteLine("2 - Plantar");
                    Console.WriteLine("3 - Regar");
                    Console.WriteLine("4 - Colher");
                    Console.WriteLine("5 - Ver armazem");
                    string escolha = Console.ReadLine();

                    if (escolha == "1")
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

                        if (comprinhas == "1")
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
                        else if (comprinhas == "2")
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
                        else if (comprinhas == "3")
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
                        else if (comprinhas == "4")
                        {
                            Console.Clear();
                        }

                    }

                    if (escolha == "2")
                    {
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

                    if (escolha == "5")
                    {
                        Console.Clear();
                        Console.WriteLine("--------------");
                        Console.WriteLine("tomatin: " + armazemTomatin);
                        Console.WriteLine("--------------");
                        Console.WriteLine("melaozin: " + armazemMelaozin);
                        Console.WriteLine("--------------");
                        Console.WriteLine("amoralina: " + armazemAmoralina);
                        Console.WriteLine("--------------");
                        Console.WriteLine("Aperte enter para voltar");
                        string sairArmazem = Console.ReadLine();
                    }
                }


            }


        }

    }
}