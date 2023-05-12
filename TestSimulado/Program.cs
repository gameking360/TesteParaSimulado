using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSimulado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Exercicios.Ex1();
            Console.ReadKey();

        }
    }

    class Exercicios
    {

        public static void Ex1()
        {
             char[] letras = new char[]{ 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Random random = new Random();

            char[] palavra = new char[random.Next(1, 8)];


            for (int i = 0; i < palavra.Length; i++)
            {
                palavra[i] = letras[random.Next(0, letras.Length - 1)];
            }
            char[] resposta = new char[palavra.Length];


            for(int i = 0; i < resposta.Length; i++)
            {
                resposta[i] = '_';
            }


            while (true)
            {
                Console.Clear();
                Console.Write("Palavra: ");
                Console.Write(resposta);
                Console.Write("\nDigite a letra para tentar acertar: ");
                char letra = char.Parse(Console.ReadLine().ToLower());

                for(int i = 0; i < resposta.Length; i++)
                {
                    if(letra == palavra[i])
                    {
                        resposta[i] = letra;
                    }
                }

                if (!resposta.Contains('_'))
                {
                    Console.WriteLine("Você venceu :)");
                    break;
                }
            }




        }
    }
}
