using Back_End_5.Classes;
using Back_End_5.Personalization;

Console.WriteLine(@$"
================================================================================
|                    Bem vindo ao sistema de cadastro de                       |
|                         Pessoas Físicas e Jurídicas                          |
================================================================================
");

BarraCarregamento.Mostrar("Carregando", 300);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
PessoaFisica novaPf = new PessoaFisica();
PessoaFisica metodoPF = new PessoaFisica();
Endereco novoEnd = new Endereco();

string opcao;

// ********************** Menu principal ************************ //

do
{
    Console.Clear();
    Console.WriteLine(@$"
================================================================================
|                         Escolha uma das Opções Abaixo                        |
|------------------------------------------------------------------------------|
|                              1- Pessoa Física                                |
|                              2- Pessoa Jurídica                              |
|                                                                              |
|                              0- Sair                                         |
================================================================================
");

    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            Console.Clear();

            // ******* Submenu ************ //
            string opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
            ================================================================================
            |                         Escolha uma das Opções Abaixo                        |
            |------------------------------------------------------------------------------|
            |                              1- Cadastrar Pessoa Física                      |
            |                              2- Mostrar Pessoas Físicas                      |
            |                                                                              |
            |                              0- voltar ao menu anterior                      |
            ================================================================================
            ");

                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\nCadastro de Pessoas escolhido");
                        // Criação dos objetos


                        Console.WriteLine($"Digite o Nome Completo:");
                        novaPf.Nome = Console.ReadLine();

                        // ******* Loop para validar data de nascimento ************ //
                        bool DataValida;
                        do
                        {

                            Console.WriteLine($"Digite a data de nascimento, Ex: DD/MM/AAAA");
                            string DataNasc = Console.ReadLine();

                            DataValida = metodoPF.ValidarDataNascimento(DataNasc);
                            if (DataValida)
                            {
                                novaPf.DataNascimento = DataNasc;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data inválida, por favor digite uma data válida.");
                                Console.ResetColor();
                            }
                        } while (DataValida == false);
                        // ******* Loop para validar data de nascimento ************ //

                        Console.WriteLine($"Digite o número do CPF:");
                        novaPf.CPF = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (Digite apenas números):");
                        novaPf.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro:");
                        novoEnd.Logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número:");
                        novoEnd.Numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento: (Aperte Enter se não houver)");

                        novoEnd.Complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereco é comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();
                        if (endCom == "S")
                        {
                            novoEnd.EndComercial = true;
                        }
                        else
                        {
                            novoEnd.EndComercial = false;
                        }

                        novaPf.Endereco = novoEnd;
                        listaPf.Add(novaPf);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso.");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        break;
                    case "2":
                        Console.Clear();
                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica CadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
                        Nome: {CadaPessoa.Nome}
                        Endereco: {CadaPessoa.Endereco.Logradouro}, {CadaPessoa.Endereco.Numero}
                        Data de Nascimento: {CadaPessoa.DataNascimento}
                        A taxa de imposto a ser paga é de: {metodoPF.PagarImposto(CadaPessoa.Rendimento).ToString("C")}
                        ");
                                Console.WriteLine("Aperte 'Enter' para continuar...");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia!!!");
                            Thread.Sleep(3000);
                        }
                        break;
                    case "0":
                        Console.Clear();
                        BarraCarregamento.Mostrar("Saindo", 300);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, por favor digite outra opção.");
                        Thread.Sleep(2000);
                        break;
                }

            } while (opcaoPf != "0");

            break;
        case "2":
            Console.Clear();
            // Objetos
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();
            //Mensagem de início
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Cadastro de Pessoa Jurídica escolhido");
            Thread.Sleep(2000);
            Console.ResetColor();
            Console.Clear();
                //Nome da empresa
            Console.WriteLine(@$"Informe o nome da empresa:");
            novaPj.Nome = Console.ReadLine();

            //novaPj.Nome = "InfoTech Informática";
            // Validar CNPJ
            bool CnpjValido;
            do
            {
                Console.Clear();

                Console.WriteLine(@$"Informe o CNPJ:");
                novaPj.CNPJ = Console.ReadLine();
                //string PJCNPJ = Console.ReadLine();
                //metodoPj.ValidarCnpj() = PJCNPJ;

            //metodoPj.ValidarCnpj(novaPj.CNPJ);
            if(metodoPj.ValidarCnpj(novaPj.CNPJ) == false)
            {
                Console.WriteLine("Por favor, insira um CNPJ válido.");
            }
            else{};
            } while ( metodoPj.ValidarCnpj(novaPj.CNPJ) == true);
            

            novaPj.CNPJ = "00.000.000/0001-00";
            novaPj.RazaoSocial = "Razao Social PJ";
            novaPj.Rendimento = 8000.5f;//f de float
            novoEndPj.Logradouro = "Rua Canadá";
            novoEndPj.Complemento = "Apartamento Azul";
            novoEndPj.Numero = 505;
            novoEndPj.EndComercial = true;
            novaPj.Endereco = novoEndPj;

            Console.Clear();

            Console.WriteLine(@$"
            Nome: {novaPj.Nome}
            Razão Social: {novaPj.RazaoSocial}
            CNPJ: {novaPj.CNPJ}
            CNPJ Válido? {metodoPj.ValidarCnpj(novaPj.CNPJ)}
            A taxa de imposto a ser paga é de: {metodoPj.PagarImposto(novaPj.Rendimento).ToString("C")}
            ");
            Console.WriteLine("Aperte 'Enter' para continuar...");
            Console.ReadLine();
            break;
        case "0":
            Console.Clear();
            BarraCarregamento.Mostrar("Saindo", 300);
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção");
            Thread.Sleep(2000);
            break;
    }

} while (opcao != "0");