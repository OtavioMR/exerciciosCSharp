using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendendoC_
{
    internal class calculadora
    {
        public static void Executar()
        {
            string nome;
            int idade;

            Console.WriteLine("Insira seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("\nAgora escolha o tipo de operação matemática você quer fazer: ");

            Console.WriteLine("\n1. para adição" +
                "\n2. para subtração" +
                "\n3. para multiplicação" +
                "\n4. para divisão");

            Console.WriteLine("\nSua escolha: ");
            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira os numeros para realizar sua operação: \n");
            Console.WriteLine("\nPrimeiro número: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nSegundo número: ");
            float n2 = float.Parse(Console.ReadLine());

            float Somar(float numero1, float numero2)
            {
                float resultado = numero1 + numero2;
                return resultado;
            }

            float Subtrair(float numero1, float numero2)
            {
                float resultado = numero1 - numero2;
                return resultado;
            }

            float Multiplicar(float numero1, float numero2)
            {
                float resultado = numero1 * numero2;
                return resultado;
            }

            float Dividir(float numero1, float numero2)
            {
                float resultado = numero1 / numero2;
                return resultado;
            }

            switch (operacao)
            {
                case 1:
                    float soma = Somar(n1, n2);
                    Console.WriteLine($"\nO resultado da sua soma é: {soma}");
                    break;

                case 2:
                    float subtracao = Subtrair(n1, n2);
                    Console.WriteLine($"\nO resultado da sua subtração é: {subtracao}");
                    break;

                case 3:
                    float multiplicacao = Multiplicar(n1, n2);
                    Console.WriteLine($"\nO resultado da sua multiplicação é: {multiplicacao}");
                    break;

                case 4:
                    float divisao = Dividir(n1, n2);
                    Console.WriteLine($"\nO resultado da sua divisão é: {divisao}");
                    break;

                default:
                    Console.WriteLine("\nNão foi possível fazer o cálculo!");
                    break;



            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
