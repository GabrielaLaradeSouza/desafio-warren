using System;

namespace WarrenDesafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAlunos = 0; // Inicia Total de alunos
            int limiteAtraso = 0; // Inicia limite de atraso
            
            Console.WriteLine("Olá Professor! \nInforme a quantidade de alunos da sua aula: ");
            totalAlunos = Int32.Parse(Console.ReadLine());
            int[] alunos = new int[totalAlunos]; // Cria Array para armazenar os horarios de chegada de cada aluno

            Console.WriteLine("Agora informe o limite de atraso para seguir com a aula: ");
            limiteAtraso = Int32.Parse(Console.ReadLine()); // Informa o limite de atraso para suspensão da aula
            

            Console.Clear(); // Limpa Console, abaixo gerei um cabeçalho para facilitar leitura
            Console.WriteLine("Total de Alunos : " + totalAlunos.ToString() + "\n"
                            + "Limite de atrasos: " + limiteAtraso.ToString());
            Console.WriteLine("\n\nPara marcar as presenças dos alunos use números inteiros,\n" +
                "sendo eles menores que zero e zero para no HORARIO e maiores que 0 para ATRASADOS.");
            Console.WriteLine("--------------------------------------------------------");
            for (int i = 0; i < totalAlunos; i++) { // Preenche os horários de chegada de cada aluno
                Console.WriteLine("Aluno " + (i+1).ToString() + " chegou, marque seu horario: ");
                alunos[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Clear(); // Limpa e gera cabeçalho
            Console.WriteLine("Total de Alunos : " + totalAlunos.ToString() + "\n"
                            + "Limite de atrasos: " + limiteAtraso.ToString());
            Console.WriteLine("--------------------------------------------------------");

            for (int i = 0; i < alunos.Length; i++) {
                if (alunos[i] > 0) { // verifica se o aluno está atrasado
                    limiteAtraso--; // Reduz total do limite
                }
            }

            if (limiteAtraso < 0) { // Valida se o limite foi passado ou não 
                Console.WriteLine("A Aula foi Suspensa!"); // Caso passou, o limite fica abaixo de 0, indicando suspensao da aula
            } else {
                Console.WriteLine("Aula Normal!");// Caso não alcançe o limite, fica acima de 0, indicando aula normal
            }

        }
    }
}
