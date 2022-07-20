using ProjetoClasse.src;
using System;
using static System.Console;

namespace ProjetoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bem vindo!");
            WriteLine("Para ver a listagem dos vestidos 0");
            int opUser = int.Parse(ReadLine());


            Vestido Liso = new Vestido("Tecido Liso Azul", "Linha Azul", "Classico", "Hering");
            Vestido Margarida = new Vestido("Tecido Margarida", "Linha Branca", "Amarelos", "C&A");
            Vestido Xadrez = new Vestido("Tecido Xadrez", "Linha Rosa", "Mateira", "DocedaCabana");
            Vestido Poa = new Vestido("Tecido Poa", "Linha Preta", "Preto", "Nike");

            WriteLine(Liso.ToString());
            WriteLine(Margarida.ToString());
            WriteLine(Xadrez.ToString());
            WriteLine(Poa.ToString());
            WriteLine("\nAplicativo finalizado\n");
        }
    }
}



   