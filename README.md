# AprovaProva
Crie um programa que solicite a nota de um aluno em uma prova (nota entre 0 e 10). O programa deve verificar se a nota é maior ou igual a 6. Se for, o aluno está aprovado, caso contrário, está reprovado. Exiba o resultado (Aprovado ou Reprovado).

using System;

namespace VerificacaoAprovacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário a nota do aluno
            Console.WriteLine("Digite a nota do aluno (entre 0 e 10):");
            double nota = Convert.ToDouble(Console.ReadLine());

  // Verifica se a nota é válida (entre 0 e 10)
            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("Nota inválida! A nota deve estar entre 0 e 10.");
            }
            else
            {
  // Verifica se o aluno está aprovado ou reprovado
                if (nota >= 6)
                {
                    Console.WriteLine("Aprovado!");
                }
                else
                {
                    Console.WriteLine("Reprovado.");
                }
            }
        }
    }
}
