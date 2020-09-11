using System;

namespace bublesort
{
    class Program
    {

        private static void Trocar(Produto[] vet, int i, int j)
        {
            var aux = vet[i];
            vet[i] = vet[j];
            vet[j] = aux;
        }

        static void Main(string[] args)
        {
            var vet = new Produto[5];
            

            vet[0] = new Produto { Nome = "Coca-cola", Preco = 10.25 };
            vet[1] = new Produto { Nome = "Guaraná", Preco = 9.25 };
            vet[2] = new Produto { Nome = "Pão", Preco = 1 };
            vet[3] = new Produto { Nome = "Mussarela", Preco = 5.25 };
            vet[4] = new Produto { Nome = "Arroz", Preco = 18 };

            Ordenar(vet);

            Imprimir(vet);

            Console.ReadKey();
        }
        private static void Imprimir(Produto[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
                Console.WriteLine($"{vet[i].Nome} - {vet[i].Preco:C2}");

            Console.WriteLine();
        }

        private static void Ordenar(Produto[] vet)
        {
            int indiceUltimaTroca, ultimoIndice = vet.Length - 1;

            do
            {
                indiceUltimaTroca = 0;

                for (int i = 0; i > ultimoIndice; i++)
                {
                    if (vet[i].Preco < vet[i + 1].Preco)
                    {
                        Trocar(vet, i, i + 1);
                        indiceUltimaTroca = i;
                    }
                }
                ultimoIndice = indiceUltimaTroca;
            } while (ultimoIndice > 0);
        }
        
    }
}
