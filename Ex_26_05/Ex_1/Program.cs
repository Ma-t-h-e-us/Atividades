using System;
using Ex_1.Classes;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            elevadorServico eS = new elevadorServico();
            elevadorSocial eSO = new elevadorSocial();

            Console.WriteLine($@"
Qual elevador usará?
1 - Elevador de Serviço
2 - Elevador Social
0 - Sair");
            string escolha = Console.ReadLine();

            bool loop = true;
            bool loop2 = true;

            if (escolha == "1")
            {
                eS.Inicializar();
                do
                {
                    Console.WriteLine($@"
1 - Entrar
2 - Sair
3 - Subir
4 - Descer
0 - Sair :)");
                    string escolha2 = Console.ReadLine().ToLower();

                    switch (escolha2)
                    {
                        case "1":
                        case "entrar":
                            eS.Entrar();
                            break;
                        case "2":
                        case "sair":
                            eS.Sair();
                            break;
                        case "3":
                        case "subir":
                            eS.Subir();
                            break;
                        case "4":
                        case "descer":
                            eS.Descer();
                            break;
                        case "0":
                            loop = false;
                            break;
                        default:
                            break;
                    }
                } while (loop == true);
            }
            else if (escolha == "2")
            {
                eSO.Inicializar();
                do
                {
                    Console.WriteLine($@"
1 - Entrar
2 - Sair
3 - Subir
4 - Descer
0 - Sair");
                    string escolha3 = Console.ReadLine().ToLower();

                    switch (escolha3)
                    {
                        case "1":
                        case "entrar":
                            eSO.Entrar();
                            break;
                        case "2 ":
                        case "sair":
                            eSO.Sair();
                            break;
                        case "3":
                        case "subir":
                            eSO.Subir();
                            break;
                        case "4":
                        case "descer":
                            eSO.Descer();
                            break;
                        case "0":
                            loop2 = false;
                            break;
                        default:
                            break;
                    }
                } while (loop2 == true);
            }
            else
            {
            }
        }
    }
}
