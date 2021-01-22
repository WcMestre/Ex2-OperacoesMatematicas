using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            Console.Write("Escolha a Operação Desejada");
            Console.Write("\n1 - Soma");
            Console.Write("\n2 - Subtração");
            Console.Write("\n3 - Multiplicação");
            Console.Write("\n4 - Divisão\n");
            op = int.Parse(Console.ReadLine());

            if(op == 1)
            {
                int numero1, resultado=0, quantidade, contador=1;

                Console.Write("Quantos números irá somar? ");
                quantidade = int.Parse(Console.ReadLine());

                while (contador <= quantidade)
                {
                    Console.Write("Digite o número " + contador +": ");
                    numero1 = int.Parse(Console.ReadLine());
                    resultado = resultado + numero1;
                    contador++;
                }

                Console.Write("O resultado da soma é: " + resultado);
            }

            else if (op == 2)
            {
                int numero1, resultado = 0, quantidade, contador = 1;

                Console.Write("Quantos números irá subtrair? ");
                quantidade = int.Parse(Console.ReadLine());

                while (contador <= quantidade)
                {
                    Console.Write("Digite o número " + contador + ": ");
                    numero1 = int.Parse(Console.ReadLine());
                    resultado = resultado - numero1;
                    contador++;
                }

                Console.Write("O resultado da subtração é: " + resultado);
            }

            else if (op == 3)
            {
                int numero1, resultado = 1, quantidade, contador = 1;

                Console.Write("Quantos números irá multiplicar? ");
                quantidade = int.Parse(Console.ReadLine());

                while (contador <= quantidade)
                {
                    Console.Write("Digite o número " + contador + ": ");
                    numero1 = int.Parse(Console.ReadLine());
                    resultado = resultado * numero1;
                    contador++;
                }

                Console.Write("O resultado da multiplicação é: " + resultado);
            }

            else if (op == 4)
            {
                int numero1, resultado = 1, quantidade, contador = 1;

                Console.Write("Quantos números irá dividir? ");
                quantidade = int.Parse(Console.ReadLine());

                while (contador <= quantidade)
                {
                    Console.Write("Digite o número " + contador + ": ");
                    numero1 = int.Parse(Console.ReadLine());
                    resultado = resultado / numero1;
                    contador++;
                }

                Console.Write("O resultado da divisão é: " + resultado);
            }

            else 
            {
                Console.Write("Opção Inválida!");
            }

            Console.Write("Aperte qualquer tecla para encerrar o programa...");
            Console.ReadKey();
        }
    }
}
