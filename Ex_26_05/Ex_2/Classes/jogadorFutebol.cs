using System;
namespace Ex_2.Classes
{
    public abstract class jogadorFutebol
    {
        protected string nome = "Ismot Mota";
        protected string dataNas = "21/12/1987";
        protected int ano = int.Parse("1987");
        protected string nac = "brasileiro";
        protected float alt = 1.80f;
        protected string peso = "80 kg";

        public void Dados(){
            Console.WriteLine($@"
nome: {nome}
Data de nascimento: {dataNas}
Nacionalidade: {nac}
Altura: {alt}m
Peso: {peso}");
        }
        public int Idade() {
            int anoAtual = DateTime.Now.Year;
            int idade = anoAtual - ano;
            return idade;
        }
    }
}