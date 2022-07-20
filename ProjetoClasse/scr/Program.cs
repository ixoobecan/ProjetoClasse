using ProjetoClasse.src;
using System;
using static System.Console;

namespace ProjetoClasse.scr
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
namespace ProjetoClasse.src
{


    public class Vestido
    {
        public string Tecido { get; set; }
        public string Linha { get; set; }
        public string Botoes { get; set; }
        public string Etiqueta { get; set; }

        public Vestido()
        {
        }

        public Vestido(string tecido, string linha, string botoes, string etiqueta)
        {
            Tecido = tecido;
            Linha = linha;
            Botoes = botoes;
            Etiqueta = etiqueta;

        }
        public override string ToString()
        {
            return $"Materia: {Tecido};\n" +
                $"Aviamento: {Linha};\n" +
                $"Acabamento: {Botoes};\n" +
                $"Marca: {Etiqueta};\n";

        }
    }

}