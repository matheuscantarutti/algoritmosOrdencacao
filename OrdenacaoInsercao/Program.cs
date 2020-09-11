using System;

namespace ExercicioOrdenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var produtos = new Produto[] {
               new Produto { Descricao = "Coca-cola", Preco = 5.5 },
                new Produto { Descricao = "Fanta", Preco = 4.5 },
                new Produto { Descricao = "Arroz", Preco = 25 },
                new Produto { Descricao = "Contra-file", Preco = 38 },
                new Produto { Descricao = "Pão", Preco = 1 }

            };

            
            Insercao(produtos);
            Imprimir(produtos);

            Console.ReadKey();
        }


        private static void Imprimir(Produto[] vetor)
        {
            foreach (var item in vetor)
            {
                Console.WriteLine($"{item.Descricao}, {item.Preco}");
            }
        }

        private static void Insercao(Produto[] vetor)
        {
            for (int i = 1; i < vetor.Length; i++)
            {
                Produto chave = vetor[i];
                int j = i - 1;

                while (j >= 0 && chave.Preco < vetor[j].Preco)
                {
                    vetor[j + 1] = vetor[j--];
                }

                vetor[j + 1] = chave;

            }
        }
    }
}
