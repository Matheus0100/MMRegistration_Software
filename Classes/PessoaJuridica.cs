using System.Text.RegularExpressions;
using Back_End_5.Interfaces;

namespace Back_End_5.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? CNPJ { get; set; }
        public string? RazaoSocial { get; set; }
        
        public string caminho {get; private set;} = "Database/PessoaJuridica.csv";

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
        public void Inserir(PessoaJuridica pj)
        {
            VerificarPastaArquivo(caminho);
            string[] pjString = {$"{pj.Nome},{pj.CNPJ},{pj.RazaoSocial}"};
            File.AppendAllLines(caminho, pjString);
        }
        public List<PessoaJuridica> Ler(){
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.CNPJ = atributos[1];
                cadaPj.RazaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }
            return listaPj;
        }

    }
}