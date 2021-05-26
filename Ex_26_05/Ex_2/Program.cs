using System;
using Ex_2.Classes;
namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {

            jogadorFutebol j = new jogadorMeioCampo();

            bool loop1 = true;
            do
            {
                Console.WriteLine($@"
1 - Dados do Jogador
2 - Idade
3 - Tempo para se aposentar
0 - sair");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        j.Dados();
                        break;
                    case "2":
                        Console.WriteLine($"{j.Idade()} anos");
                        break;
                    case "3":
                        Console.WriteLine($@"Qual a posição do jogador?
1 - Jogador de defesa
2 - Jogador de meio-campo
3 - Jogador de ataque");
                        string escolha2 = Console.ReadLine();

                        switch (escolha2)
                        {
                            case "1":
                                jogadorDefesa jD = new jogadorDefesa();
                                jD.TempoAposentar();
                                break;
                            case "2":
                                jogadorMeioCampo jM = new jogadorMeioCampo();
                                jM.TempoAposentar();
                                break;
                            case "3":
                                jogadorAtaque jA = new jogadorAtaque();
                                jA.TempoAposentar();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "0":
                        loop1 = false;
                        break;
                    default:
                        break;
                }
            } while (loop1 == true);

        }
    }
}
