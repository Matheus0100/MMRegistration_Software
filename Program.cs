using Back_End_5.Classes;

Console.WriteLine(@$"
================================================================================
|                    Bem vindo ao sistema de cadastro de                       |
|                         Pessoas Física e Jurídicas                           |
================================================================================
");

BarraCarregamento("Carregando ", 500);

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
            BarraCarregamento("Finalizando ", 500);
            break;
        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodoPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();
            novaPf.nome = "Matheus";
            novaPf.DataNascimento = "19/02/2002";
            novaPf.cpf = "12345678902";
            novaPf.rendimento = 600.0f;
            novoEnd.logradouro = "Rua Canadá";
            novoEnd.numero = 123;
            novoEnd.complemento = "Apartamento";
            novoEnd.endComercial = false;
            novaPf.endereco = novoEnd;

            Console.Clear();

            Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
            Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.DataNascimento)}
            ");
            Console.WriteLine("Aperte 'Enter' para continuar...");
            Console.ReadLine();
            break;
        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "InfoTech Informática";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razao = "Razao Social PJ";
            novaPj.rendimento = 8000.5f;
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
                CNPJ Válido? {metodoPj.ValidarCnpj(novaPj.cnpj)}");
            Console.WriteLine("Aperte 'Enter' para continuar...");
            Console.ReadLine();
            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção");
            Thread.Sleep(2000);
            break;
    }
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo){
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





/*
PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();
Console.WriteLine(novaPf.nome);
novaPf.ValidarDataNascimento("01.01.2000");
novaPf.nome = "Matheus";
novaPf.DataNascimento = "19/02/2002";
novaPf.cpf = "12345678902";
novaPf.rendimento = 600.0f;
novoEnd.logradouro = "Rua Canadá";
novoEnd.numero = 123;
novoEnd.complemento = "Apartamento";
novoEnd.endComercial = false;
novaPf.endereco = novoEnd;


Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereco: {novaPf.endereco.logradouro}
Maior de idade: {novaPf.ValidarDataNascimento(novaPf.DataNascimento)}
");*/

//Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0002-00")}");
