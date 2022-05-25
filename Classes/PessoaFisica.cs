using Back_End_5.Interfaces;

namespace Back_End_5.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set;}
        public DateTime ?DataNascimento { get; set;}
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNascimento(DateTime datanasc)
        {
            throw new NotImplementedException();
        }
    }
}