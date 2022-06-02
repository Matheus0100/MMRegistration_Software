using System.Text.RegularExpressions;
using Back_End_5.Interfaces;

namespace Back_End_5.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }
        public string? razao { get; set; }

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return (rendimento * 0.03f);
            }
            else if (rendimento <= 3500)
            {
                return (rendimento * 0.05f);
            }
            else if (rendimento <= 6000)
            {
                return (rendimento * 0.07f);
            }
            else
            {
                return (rendimento * 0.09f);
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            //o Regex vai validar o formato da entrada dos dados.
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}