using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovaProva
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal nota;

            Console.WriteLine("Informe a nota1: ");
            nota = Convert.ToDecimal(Console.ReadLine());

            if (nota >= 6)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
            Console.ReadKey();
        }
    }
}
