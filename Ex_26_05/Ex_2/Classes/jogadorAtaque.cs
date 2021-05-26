using System;
namespace Ex_2.Classes
{
    public class jogadorAtaque : jogadorFutebol
    {
        public void TempoAposentar() {
            int TempoAposentar = 35 - Idade();
            Console.WriteLine($"Falta {TempoAposentar} anos para o {nome} se aposentar");
        }
    }
}