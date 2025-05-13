namespace MBGestaoEscolarAN.Entities
{
    public class Aluno
    {
        private int alunoId;
        private string nome;
        private string cpf;
        private string matricula;
        private string email;
        private string telefone;
        private DateTime dataNascimento;
        private string Endereco;
        private string statusAluno;
        private DateTime dataCadastro;

        public int AlunoId { get => alunoId; set => alunoId = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Endereco1 { get => Endereco; set => Endereco = value; }
        public string StatusAluno { get => statusAluno; set => statusAluno = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
    }
}
