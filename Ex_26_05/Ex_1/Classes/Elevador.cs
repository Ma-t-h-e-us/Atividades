using System;

namespace Ex_1.Classes
{
    public abstract class Elevador
    {
        protected int andarAtual = 0;
        protected int totalAndares;
        public int capacidadeEle;
        protected int quantidadeP = 0;
        public virtual void Inicializar()
        {
            Console.WriteLine($"Qual o total de andares do elevador?");
            totalAndares = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual a capacidade máxima de pessoas no elevador?");
            capacidadeEle = int.Parse(Console.ReadLine());
        }
        public void Entrar()
        {
            if (quantidadeP == capacidadeEle)
            {
                Console.WriteLine("Desculpe, o elevador está cheio!");
            }
            else
            {
                quantidadeP++;
                Console.WriteLine($"Há {quantidadeP} pessoas no elevador");
            }
        }
        public void Sair()
        {
            if (quantidadeP == 0)
            {
                Console.WriteLine("não há ninguém no elevador");
            }
            else
            {
                quantidadeP--;
                Console.WriteLine($"Há {quantidadeP} no elevador");
            }
        }
        public void Subir()
        {
            if (andarAtual == totalAndares)
            {
                Console.WriteLine("Ops, Andar máximo");
            }
            else
            {
                andarAtual++;
                Console.WriteLine($"está no {andarAtual}º andar");
            }
        }
        public void Descer()
        {
            if (andarAtual == 0)
            {
                Console.WriteLine("Você está no térreo :)");
            }
            else
            {
                andarAtual--;
                Console.WriteLine($"está no {andarAtual}º andar");
            }
        }
    }
}