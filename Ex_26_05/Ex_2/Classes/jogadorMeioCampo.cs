using System;
namespace Ex_2.Classes
{
    public class jogadorMeioCampo : jogadorFutebol
    {
            public void TempoAposentar() {
            int TempoAposentar = 38 - Idade();
            Console.WriteLine($"Falta {TempoAposentar} anos para o {nome} se aposentar");
        }
    }
}