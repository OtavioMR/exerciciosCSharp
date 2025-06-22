using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendendoC_
{
    internal class Fatorial
    {
        public static void Executar()
        {
            Console.Write("Insira um número para calcular o fatorial: ");
            int num = int.Parse(Console.ReadLine());
            int total = 1;

            for (int i = num; i > 0; i--)
            {
                total = total * i;
                Console.WriteLine(total);

            }

            Console.WriteLine($"O fatorial de {num} é: {total}");

        }
    }
}
