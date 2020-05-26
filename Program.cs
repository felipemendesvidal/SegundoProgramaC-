using System;
//para simplificar comandos
using static System.Console;

namespace segundoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Aluno 01 ----------\n");
            Alunos felipe = new Alunos();
            felipe.nome ="Felipe";
            felipe.idade =23;
            felipe.bolsista = true;
            felipe.mediaFinal = 9.9f;
            WriteLine("\n\n");
            WriteLine("----------Resultados aluno 1 ----------\n");
            Console.WriteLine("felipe: "+felipe.verMedia());
            
        }
    }
}
