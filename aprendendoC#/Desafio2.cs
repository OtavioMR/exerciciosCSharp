using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendendoC_
{
    internal class Desafio2
    {
        public static void Executar()
        {
            static bool EhPalindromo(string palavra)
            {
                string palavraNormalizada = palavra.Replace(" ", "").ToLower();

                string palavraInvertida = "";

                for (int i = palavraNormalizada.Length - 1; i >= 0; i--)
                {
                    palavraInvertida += palavraNormalizada[i];
                }

                return palavraNormalizada == palavraInvertida;

            }

            Console.WriteLine("Insira uma palavra: ");
            string input = Console.ReadLine();

            string inputNormalizada = input.Replace(" ", "").ToLower();

            if (EhPalindromo(input))
            {
                Console.WriteLine($"\nA palavra: {inputNormalizada} é um palíndromo!");
            }

            else
            {
                Console.WriteLine($"\nA palavra {inputNormalizada} não é um palíndromo!");
            }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
        }

        
    }
}
