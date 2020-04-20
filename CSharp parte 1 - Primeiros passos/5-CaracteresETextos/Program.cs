using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caracteres e Textos");

            char primeiraLetra = 'a';
            Console.WriteLine("Primeira letra: " + primeiraLetra);

            //Pega representação na ASCII
            primeiraLetra = (char)65;
            Console.WriteLine("Primeira letra (char)65: " + primeiraLetra);
            
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine("Primeira letra (char)(primeiraLetra + 1): " + primeiraLetra);

            string titulo = "Alura";
            Console.WriteLine("Título: " + titulo);

            string cursosProgramação = 
@" - .NET
- Java
- JavaScript";
            Console.WriteLine("Cursos: " + cursosProgramação);

            Console.WriteLine("\nExecução finalizada. \nAperte ENTER para sair...");
            Console.ReadLine();
        }
    }
}
