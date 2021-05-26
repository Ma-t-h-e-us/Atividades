using System;
using Ex_3.Classes;
namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            maquinaCafe m = new maquinaCafe();
            bool loop1 = true;
            do
            {
            Console.WriteLine($@"
B E M  V I N D O 
O que deseja?
1 - Fazer café 
2 - Fazer café padrão
3 - Ver açucar disponível
4 - Adicionar açucar à máquina
0 - Sair");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Açucar desejado:");
                    m.FazerCafe(int.Parse(Console.ReadLine()));
                    break;
                case 2:
                    m.FazerCafe();
                    break;
                case 3:
                    Console.WriteLine($"{m.acucarDisponivel}");
                    break;
                case 4:
                    Console.WriteLine("Quanto de açucar deseja adicionar a máquina?");
                    int acucarAdicionado = int.Parse(Console.ReadLine());
                    m.acucarDisponivel += acucarAdicionado;
                    break;
                case 0:
                    loop1 = false;
                    break;
                default:
                    break;
            }
            } while (loop1 == true);            
        }
    }
}
