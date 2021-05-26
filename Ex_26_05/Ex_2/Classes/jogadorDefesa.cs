using System;
namespace Ex_2.Classes
{
    public class jogadorDefesa : jogadorFutebol
    {
        public void TempoAposentar() {
            int TempoAposentar = 40 - Idade();
            Console.WriteLine($"Falta {TempoAposentar} anos para o {nome} se aposentar");
        }
    }
}