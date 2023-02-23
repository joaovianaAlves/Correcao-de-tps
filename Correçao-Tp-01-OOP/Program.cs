using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correçao_Tp_01_OOP
{
    internal class Program
    {

        //Tp 01

        static bool Primo(int num)
        {
            int contador = 2, achou = 0;
            //se o num for maior que contador procura um divisor, se dividir achou = 1 e da false porque nao e primo, se achar = 0 retorna true
            while (num > contador && achou == 0)
            {
                if(num % contador == 0)
                {
                    achou = 1;
                }
                contador++;
            }
            if (achou == 0)
            {
                return (true);
            }
            return (false);
        }

        //Tp 02

        static int CalcularIdade(int anos, int meses, int dias)
        {
            return(anos * 365) + (meses * 30) + (dias);
      
        }

        //Tp 03

        static void IdentificaMaiorMenor(int[] valores, ref int maior, ref int menor)
        {
            maior = menor = valores[0];
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] > maior)
                {
                    maior = valores[i];
                }
                else
                {
                    if (valores[i] < menor)
                    {
                        menor = valores[i];
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numero = int.Parse(Console.ReadLine());

            if (Primo(numero))
            {
                Console.WriteLine("É primo");
            }
            else
            {
                Console.WriteLine("Não é primo");
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Digite a idade anos de uma pessoa");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade meses de uma pessoa");
            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade dias de uma pessoa");
            int dias = int.Parse(Console.ReadLine());

            Console.WriteLine("idade em dias");
            Console.WriteLine("idade em dias: {0}", CalcularIdade(anos, meses, dias));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Digite 10 valores");
            //int[] valores = new int[10];

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    Console.WriteLine("Digite 10 valores");
            //    valores[i] = int.Parse(Console.ReadLine());
            //}

            int[] valor = new int[] {1,2,3,4,5,6,7,8,9,10};
            int maior = 0,menor = 0;

            IdentificaMaiorMenor(valor, ref maior, ref menor);
            Console.WriteLine("Menor:{0}, Maior{1}", menor, maior);
            Console.ReadKey();



        }
    }
}
