using System;
namespace Ex_3.Classes
{
    public class maquinaCafe
    {
        public int acucarDisponivel = 100;
        public void FazerCafe(int acucarNoCafe) {
            if (acucarDisponivel < acucarNoCafe)
            {
                Console.WriteLine($@"
Açucar disponível insuficiente :(
Café sem açucar feito");
            } else {
                acucarDisponivel -= acucarNoCafe;
                Console.WriteLine("Café feito!");
            }
        }
        public void FazerCafe() {
            if (acucarDisponivel > 0)
            {
                acucarDisponivel -= 10;
                Console.WriteLine("Café feito!");
            } else {
                Console.WriteLine("Café sem açucar feito");
            }
        }
    }
}