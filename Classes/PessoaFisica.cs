using Back_End_5.Interfaces;

namespace Back_End_5.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? CPF { get; set; }
        public string? DataNascimento { get; set; }
        public override float PagarImposto(float Rendimento)
        {
            if (Rendimento <= 1500)
            {
                return 0;
            }
            else if (Rendimento > 1500 && Rendimento <= 3500)
            {
                return (Rendimento / 100) * 2;
            }
            else if (Rendimento > 3500 && Rendimento < 6000)
            {
                return (Rendimento / 100) * 3.5f;
            }
            else
            {
                return (Rendimento / 100) * 5;
            }
        }

        public bool ValidarDataNascimento(DateTime DataNasc)
        {
            DateTime DataAtual = DateTime.Today;
            double anos = (DataAtual - DataNasc).TotalDays / 365;
            if (anos >= 18)
            {
                return true;
            }

            return false;
        }

        public bool ValidarDataNascimento(string DataNasc)
        {
            DateTime DataConvertida;
            //verificar se a string está em um formato válido
            if (DateTime.TryParse(DataNasc, out DataConvertida))
            { //TryParse tenta converter e coloca na saída DataConvertida.

                DateTime DataAtual = DateTime.Today;
                double anos = (DataAtual - DataConvertida).TotalDays / 365;
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
