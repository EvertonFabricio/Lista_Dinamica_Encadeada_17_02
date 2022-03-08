using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Dinamica_Encadeada
{
    internal class Fila
    {
        public Livro Cabeca { get; set; } //criei atributo ponta
        public Livro Cauda { get; set; } //criei atributo cauda

        public Fila() //inicio ponta e cauda = nulo.
        {
            Cabeca = null;
            Cauda = null;
        }

        public bool vazia()
        {
            if (Cabeca == null)
                return true;
            else
                return false;
        }

        public void push(Livro aux)
        {
            if (Cabeca == null && Cauda == null)
            {
                Cabeca = aux;
                Cauda = aux;
                Console.WriteLine("Livro inserido com sucesso!\n\nPressione ENTER para prosseguir.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Cauda.Proximo = aux;
                Cauda = aux;
                aux = null;
                Console.WriteLine("Livro inserido com sucesso!\n\nPressione ENTER para prosseguir.");
                Console.ReadKey();
                Console.Clear();
            }
            cont++;
        }

        public void pop()
        {
            if (vazia())
                Console.WriteLine("A pilha está vazia.\n\nPressione ENTER para prosseguir.");
            else
            {
                Cabeca = Cabeca.Proximo;
                Console.WriteLine("O livro foi removido.\n\nPressione ENTER para prosseguir.");
                cont--;
                if (Cabeca == null)
                {
                    Cauda = null;
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void print()
        {
            if (vazia())
                Console.WriteLine("\nnão existem livros cadastrados.");
            else
            {
                Livro aux = Cabeca;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                    Console.WriteLine("\n*********************\n");
                }
                while (aux != null);
                Console.WriteLine("\nFim da impressão");
            }
            Console.WriteLine("\nPressione ENTER para prosseguir.");
            Console.ReadKey();
            Console.Clear();
        }

        public void buscar()
        {
            if (vazia())
                Console.WriteLine("Não existem livros cadastrados.");
            else
            {
                Console.WriteLine("Digite o nome do livro ou seu ISBN para realizar a busca: ");
                string busca = Console.ReadLine();
                Livro aux = Cabeca;
                Console.Clear();
                do
                {
                    if (busca == aux.Nome || busca == aux.ISBN)
                    {
                        Console.WriteLine(aux.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Sua busca não encontrou resultados.");
                    }
                        aux = aux.Proximo;
                } while (aux != null);
            }
            Console.WriteLine("\nPressione ENTER para prosseguir.");
            Console.ReadKey();
            Console.Clear();

        }

        int cont = 0;
        public void contar()
        {
            if (cont == 0)
            {
                Console.WriteLine("Não existem livros cadastrados.");
                Console.WriteLine("\nPressione ENTER para prosseguir.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"Você tem {cont} livro(s) cadastrado(s).");
                Console.WriteLine("\nPressione ENTER para prosseguir.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
