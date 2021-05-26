using System;

namespace Ex_1.Classes
{
    public class elevadorServico : Elevador
    {
        public override void Inicializar()
        {
            Console.WriteLine($"Qual o total de andares do elevador?");
            totalAndares = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual a capacidade máxima de caixas no elevador?");
            capacidadeEle = int.Parse(Console.ReadLine());
        } 
    }
}