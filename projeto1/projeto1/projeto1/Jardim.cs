﻿using System;
using System.ComponentModel.Design;

namespace projeto1
{
    /*
    class Jardim
    {
        static char[,] mapa;
        static int largura = 20;
        static int altura = 10;
        static int playerX = 1;
        static int playerY = 1;
        static bool jogando = true;

        static void Main()
        {
            Console.Clear();

            //Aqui vai entrar o menu de nós

            jogar();

        }


        static void jogar()
        {
            while (jogando)
            {
                Console.Clear();
                DesenharMapa();

                var tecla = Console.ReadKey(true).Key;

                AtualizarPosicao(tecla);
            }

        }

        static void iniciarmapa()
        {
            mapa = new char[largura, altura];
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    // ultima posição do vetor é tamanho -1
                    if (x == 0 || y == 0 || x == largura - 1 || y == altura - 1)
                    {
                        mapa[x, y] = '#';

                    }
                    else
                    {
                        mapa[x, y] = ' ';
                    }
                }

            }

            mapa[playerX, playerY] = '@';
        }


        static void DesenharMapa()
        {
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    Console.Write(mapa[x, y]);
                }

                Console.Write(mapa[playerX, playerY]);
        }
        }
        static void AtualizarPosicao(ConsoleKey tecla)
        {
            int tempX = playerX;
            int tempY = playerY;

            switch (tecla)
            {
                case ConsoleKey.A: tempX--; break;
                case ConsoleKey.D: tempX++; break;
                case ConsoleKey.W: tempY--; break;
                case ConsoleKey.S: tempY++; break;
            }
            if (mapa[tempX, tempY] == ' ')
            {
                mapa[playerX, playerY] = ' ';
                mapa[tempX, tempY] = '@';

                playerX = tempX;
                playerY = tempY;

    class Personagem
    {
    List <Item> Armazem = new List<Item>();
    update(){
    Armazem.add(Tomatin);
    Armazem.add(Melaozin);
    Armazem.add(Amoralina);
    }

    protected void ...() // so pode ser chamado dentro da classe
    public void ...() // pode ser chamado de fora da classe

    public char forma { get; set; } // get (pega) set (muda)
                                                                                 
               

            }















        }
    }
    */
}



