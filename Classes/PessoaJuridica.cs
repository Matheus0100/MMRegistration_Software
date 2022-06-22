using System.Text.RegularExpressions;
using Back_End_5.Interfaces;

namespace Back_End_5.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? CNPJ { get; set; }
        public string? RazaoSocial { get; set; }

        public override float PagarImposto(float Rendimento)
        {
            if (Rendimento <= 1500)
            {
                return (Rendimento * 0.03f);
            }
            else if (Rendimento <= 3500)
            {
                return (Rendimento * 0.05f);
            }
            else if (Rendimento <= 6000)
            {
                return (Rendimento * 0.07f);
            }
            else
            {
                return (Rendimento * 0.09f);
            }
        }

        public bool ValidarCnpj(string CNPJ)
        {
            //o Regex vai validar o formato da entrada dos dados.
            if (Regex.IsMatch(CNPJ, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (CNPJ.Length == 18)
                {
                    if (CNPJ.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if (CNPJ.Length == 14)
                {
                    if (CNPJ.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}