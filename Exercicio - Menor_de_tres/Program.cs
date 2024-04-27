using System;
using Exercicio___Menor_de_tres.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Menor_de_tres
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("First Number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Third Number: ");
            int n3 = int.Parse(Console.ReadLine());

            Numbers numbers = new Numbers(n1, n2, n3);

            Console.WriteLine(numbers);   
        }
    }
}
