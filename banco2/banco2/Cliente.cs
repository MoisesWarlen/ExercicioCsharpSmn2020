namespace banco2
{
    public class Cliente
    {
        string documentos;
        public string nome { get; private set; }
        public int idade { get; set; }

        public string cpf { get; set; }
        public Cliente(string nome)
        {
            this.nome = nome;
        }


        public bool PodeAbrirContaSozinho
        {
            get
            {
                var maiorDeIdade = this.idade >= 18;
                var emancipado = this.documentos=="emancipacao";
                var possuiCPF = !string.IsNullOrEmpty(this.cpf);
                return (maiorDeIdade || emancipado) && possuiCPF;
            }
        }

        }
}

        

    
