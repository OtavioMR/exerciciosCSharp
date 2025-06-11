using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendendoC_
{
    internal class pares
    {
        public static void Executar()
        {
            //🔢 Desafio 1 – Soma dos Pares
            //Peça 10 números ao usuário e mostre a soma apenas dos números pares

            List<int> numerosPares = new List<int>();


            Console.WriteLine("Insira 10 numero: \n");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Número {i}");
                int numero = int.Parse(Console.ReadLine());










                numerosPares.Add(numero);
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", numerosPares));

            //foreach (int nome in nomes)
            //{
            //    Console.WriteLine(nome);
            //}

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
