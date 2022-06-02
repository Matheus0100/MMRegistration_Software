using Back_End_5.Classes;


Console.WriteLine(@$"
================================================================================
|                    Bem vindo ao sistema de cadastro de                       |
|                         Pessoas Físicas e Jurídicas                          |
================================================================================
");

BarraCarregamento("Carregando ", 300);

List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;



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
        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");
            BarraCarregamento("Finalizando ", 300);
            break;
        case "1":
            PessoaFisica metodoPf = new PessoaFisica();
            string? opcaoPf;
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
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o Nome Completo:");
                        novaPf.nome = Console.ReadLine();

                        bool dataValida;
                        do
                        {

                            Console.WriteLine($"Digite a data de nascimento, Ex: DD/MM/AAAA");
                            string dataNasc = Console.ReadLine();

                            dataValida = metodoPf.ValidarDataNascimento(dataNasc);
                            if (dataValida)
                            {
                                novaPf.DataNascimento = dataNasc;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data inválida, por favor digite uma data válida.");
                                Console.ResetColor();
                            }
                        } while (dataValida == false);
                } while (dataValida == false) ;


                Console.WriteLine($"Digite o número do CPF:");
                novaPf.cpf = Console.ReadLine();

                Console.WriteLine($"Digite o rendimento mensal (Digite apenas números):");
                novaPf.rendimento = float.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o logradouro:");
                novoEnd.logradouro = console.ReadLine();

                Console.WriteLine($"Digite o número:");
                novoEnd.numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o complemento: (Aperte Enter se não houver)");

                novoEnd.complemento = Console.ReadLine();

                Console.WriteLine($"Este endereco é comercial? S/N");
                string endCom = console.ReadLine().ToUpper();
                if (endCom == "S")
                {
                    novoEnd.endComercial = true;
                }
                else
                {
                    novoEnd.endComercial = false;
                }

                novaPf.endereco = novoEnd;
                listaPf.add(novaPf);

                Console.ForegroundColor = ConsoleColor.darkgreen;
                Console.WriteLine($"Cadastro realizado com sucesso.");
                Thread.Sleep(3000);
                Console.ResetColor();
            } while ("0");
            break;

        case "2":
            console.clear();
            if (listaPf.count > 0)
            {
                foreach (PessoaFisica cadaPessoa in listaPf)
                {
                    Console.clear();
                    Console.WriteLine(@$"
            Nome: {cadaPessoa.nome}
            Endereco: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
            Data de Nascimento: {cadaPessoa.DataNascimento}
            A taxa de imposto a ser paga é de: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
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
            PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "InfoTech Informática";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.razao = "Razao Social PJ";
novaPj.rendimento = 8000.5f;//f de float
novoEndPj.logradouro = "Rua Canadá";
novoEndPj.complemento = "Apartamento Azul";
novoEndPj.numero = 505;
novoEndPj.endComercial = true;
novaPj.endereco = novoEndPj;

Console.Clear();

Console.WriteLine(@$"
                Nome: {novaPj.nome}
                Razão Social: {novaPj.razao}
                CNPJ: {novaPj.cnpj}
                CNPJ Válido? {metodoPj.ValidarCnpj(novaPj.cnpj)}
                A taxa de imposto a ser paga é de: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
                ");
Console.WriteLine("Aperte 'Enter' para continuar...");
Console.ReadLine();
break;

default:
            Console.Clear();
Console.WriteLine($"Opção inválida, por favor digite outra opção");
Thread.Sleep(2000);
break;
    
 }while (opcao! = "0") ;

static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.White;

    Console.Write(texto);

    for (var contador = 0; contador < 10; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(tempo);
    };
    Console.ResetColor();
}
    }
}