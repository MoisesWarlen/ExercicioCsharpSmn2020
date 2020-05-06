namespace Banco
{
    internal class Cliente //criando a classe
    {
       
     public string Nome { get; private set; } //declarando variaveis
        public Cliente(string nome) //contrutor 
        {
            this.Nome = nome;
        }

      
    }
}