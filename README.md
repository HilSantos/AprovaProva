# AprovaProva
Crie um programa que solicite a nota de um aluno em uma prova (nota entre 0 e 10). O programa deve verificar se a nota é maior ou igual a 6. Se for, o aluno está aprovado, caso contrário, está reprovado. Exiba o resultado (Aprovado ou Reprovado).

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
