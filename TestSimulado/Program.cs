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
            /*
            Exercicios.Ex1();
            Console.ReadKey();
            

            Exercicios.Ex2();
            Console.ReadKey();
            */

            Exercicios.Ex3();
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

        public static void Ex2()
        {
            Console.WriteLine("Digite uma palavra para ser lida");
            string palavra = Console.ReadLine();

            string reversa = new string(palavra.Reverse().ToArray());

            if(palavra == reversa)
            {
                Console.WriteLine("A string " + palavra + " é um palíndromo");
            }
            else
            {
                Console.WriteLine("A string " + palavra + " não é um palíndromo");

            }

        }

        public static void Ex3()
        {
            Console.WriteLine("Digite uma lista de números, os separando por espaço");
           string[] lista = Console.ReadLine().Split(' ');

            double[] numeros = new double[lista.Length];
            
            /* Eu até tentei, mas não consegui realizar a atividade sem o uso de métodos.
             * Peço a compreensão do professor.
            double menor = 0;
            double maior = 0;

            for(int i = 0; i < lista.Length;i++)
            {
                double numero = double.Parse(lista[i]);
                if(i == 0)
                {
                    numeros[i] = numero;
                    numeros[numeros.Length - 1] = numero;

                    menor = numero;
                    maior = numero;
                }

                else if(i > 0)
                {
                    if(numero < menor)
                    {
                        menor = numero;
                        numeros[0] = numero;
                    }

                    if(numero > maior)
                    {
                        maior = numero;
                        numeros[numeros.Length - 1] = numero;
                    }

                    else
                    {
                        numeros[i] = numero;
                    }
                }*/
            

            for(int i = 0; i < lista.Length; ++i)
            {
                numeros[i] = double.Parse(lista[i]);
            }

           Array.Sort(numeros);

            for(int i = 0;i < lista.Length;i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
