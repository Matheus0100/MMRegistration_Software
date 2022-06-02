using Back_End_5.Interfaces;

namespace Back_End_5.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf { get; set; }
        public string? DataNascimento { get; set; }
        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                return (rendimento / 100) * 2;
            }
            else if (rendimento > 3500 && rendimento < 6000)
            {
                return (rendimento / 100) * 3.5f;
            }
            else
            {
                return (rendimento / 100) * 5;
            }
        }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365;
            if (anos >= 18)
            {
                return true;
            }

            return false;
        }

        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            //verificar se a string está em um formato válido
            if (DateTime.TryParse(dataNasc, out dataConvertida))
            { //TryParse tenta converter e coloca na saída dataConvertida.

                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;
                if (anos >= 18)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
