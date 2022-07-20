using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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