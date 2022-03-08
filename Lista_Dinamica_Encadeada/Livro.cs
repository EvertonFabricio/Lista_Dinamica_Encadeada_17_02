using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Dinamica_Encadeada
{
    internal class Livro
    {
        public string Nome { get; set; }
        public string Ano_Publicacao { get; set; }
        public string ISBN { get; set; }
        public Livro Proximo { get; set; }

        public Livro(string nome, string ano_Publicacao, string iSBN)
        {
            Nome = nome;
            Ano_Publicacao = ano_Publicacao;
            ISBN = iSBN;
            Proximo = null;
        }
        public override string ToString()
        {
            return $"Dados do Livro cadastrado:\nTitulo: {Nome}\nAno de Publicação: {Ano_Publicacao}\nISBN: {ISBN}.";
        }
    }
}
