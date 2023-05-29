/*
@(#)File:           hello.cs
@(#)Purpose:        Help students with first commit on GitHub using Git.
@(#)Author:         Lucas Mellone
@(#)Copyright:      (C) Lucas Mellone 2023 under MIT License
*/

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Olá! Essa é a lista de contribuintes do curso INF-0991:");
            Console.WriteLine("Hello! This is the contributors list of the INF-0991 course");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello world! My name is Lucas");
            // Insira a partir dessa linha conforme o exemplo acima um Hello World com seu nome:
            //Alteração realizada por Thiago Rodrigues
            Console.WriteLine("Hello world! My name is Thiago Rodrigues");
            // Insert a Hello World with your name following the example above after this line:
            Console.WriteLine("Hello world! My name is Byron"); // Modificação do código feito por Byron

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello world! My name is Jefferson Ibiapino"); //MOdificação do código por Jefferson Ibiapino

        }
    }
}
