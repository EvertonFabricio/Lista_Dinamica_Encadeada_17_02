using System;

namespace Lista_Dinamica_Encadeada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila lista = new Fila();
            string nome, ano, isbn;
            Console.WriteLine("Lista de Livros");
            do
            {
                Console.WriteLine("\nDigite a opção desejada:\n");
                Console.WriteLine("1 - Cadastrar Livros.");
                Console.WriteLine("2 - Remover Livro");
                Console.WriteLine("3 - Imprimir Relação de Livros");
                Console.WriteLine("4 - Ver quantidade cadastrada");
                Console.WriteLine("5 - Buscar um Livro");
                Console.WriteLine("0 - Sair");
                Console.Write("\nOpção: ");
                string menu = (Console.ReadLine());
                Console.Clear();

                switch (menu)
                {
                    case "0":
                        Console.WriteLine("O programa foi encerrado.");
                        break;

                    case "1"://inserir
                        Console.Write("Informe o nome do livro: ");
                        nome = Console.ReadLine();
                        Console.Clear();

                        Console.Write("Informe o ano em que foi publicado: ");
                        ano = (Console.ReadLine());
                        Console.Clear();

                        Console.Write("Informe seu ISBN: ");
                        isbn = Console.ReadLine();
                        Console.Clear();
                        lista.push(new Livro(nome, ano, isbn));
                        break;

                    case "2":  //remover não ta funcionando
                        lista.pop();
                        break;

                    case "3":  //imprimir a lista toda
                        lista.print();
                        break;

                    case "4":  //recuperar a quantidade
                        lista.contar();
                        break;

                    case "5": //buscar
                        lista.buscar();
                        break;

                    default:
                        Console.WriteLine("\nOpção incorreta. Tente novamente.");
                        break;
                }
                if (menu == "0")
                    break;
            }
            while (true);
        }
    }
}
