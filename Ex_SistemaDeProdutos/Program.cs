using System;

namespace Ex_SistemaDeProdutos
{
    class Program
    {
        static int adicaoProdutos = 0;
        static int quantMax = 10;
        static int i = 0;
        static int a = 0;
        static string[] nomeP = new string[quantMax];
        static float[] preco = new float[quantMax];
        static bool[] promocao = new bool[quantMax];
        static bool iniciar = true;
        static void Main(string[] args)
        {
            do
            {
                string menuU = menu();
                switch (menuU)
                {
                    case "c":
                    case "1":
                        cadastrar();
                        break;
                    case "l":
                    case "2":
                        listarProdutos();
                        break;
                    case "s":
                    case "3":
                        iniciar = false;
                        Console.WriteLine("obrigado por contar conosco, tenha um bom dia :)");
                        break;
                    default:
                        Console.WriteLine("desculpe, insira uma instrução válida :)");
                        break;
                }

            } while (iniciar == true);
        }
        static string menu()
        {
            Console.WriteLine(@"
m e n u

1 - Cadastrar Produto
2 - Listar Produtos
3 - Sair");

            string resposta = Console.ReadLine().ToLower().Substring(0, 1);
            return resposta;
        }
        static void cadastrar()
        {
            for (i = 0; i <= quantMax + adicaoProdutos;)
            {
                Console.WriteLine($"você ainda pode fazer {quantMax + a} cadastros.");
                Console.WriteLine("Nome:");
                nomeP[i] = Console.ReadLine();
                Console.WriteLine("preço:");
                preco[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Está em promoção?(sim/não)");
                string promocaoFake = Console.ReadLine().ToLower().Substring(0, 1);

                if (promocaoFake == "s")
                {
                    promocao[i] = true;
                }
                else
                {
                    promocao[i] = false;
                }

                Console.WriteLine("Deseja cadastrar mais um?(sim/não");
                string resposta2 = Console.ReadLine().ToLower().Substring(0, 1);

                if (resposta2 == "n")
                {
                    break;
                }
                else
                {
                    if (quantMax + a == 1)
                    {
                        Console.WriteLine("O console está cheio, deseja cadastrar mais produtos? (sim/não)");
                        string resposta3 = Console.ReadLine().ToLower().Substring(0, 1);
                        if (resposta3 == "s")
                        {
                            Console.WriteLine("deseja cadastrar quantos produtos a mais?");
                            adicaoProdutos = int.Parse(Console.ReadLine());
                            Array.Resize(ref nomeP, quantMax + adicaoProdutos); 
                            Array.Resize(ref preco, quantMax + adicaoProdutos); 
                            Array.Resize(ref promocao, quantMax + adicaoProdutos); 
                            a += adicaoProdutos;
                        } else {
                            break;
                        }
                    }
                    i++;
                    a--;
                }
            }
        }
        static void listarProdutos()
        {
            for (int c = 0; c <= i; c++)
            {
                Console.WriteLine($"Nome: {nomeP[c]} | Preço: {preco[c]} | Promoção: {promocao[c]}");
            }
        }
    }
}
