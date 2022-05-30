using Back_End_5.Classes;
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

Console.WriteLine($"{novaPf.nome}");
Console.WriteLine($"{novaPf.DataNascimento}");
Console.WriteLine($"{novaPf.cpf}");
Console.WriteLine($"{novaPf.rendimento}");
Console.WriteLine($"{novaPf.endereco.logradouro}");
Console.WriteLine($"{novaPf.endereco.numero}");
Console.WriteLine($"{novaPf.endereco.complemento}");
Console.WriteLine($"{novaPf.endereco.endComercial}");

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereco: {novaPf.endereco.logradouro}
Maior de idade: {novaPf.ValidarDataNascimento(novaPf.DataNascimento)}
");*/


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

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razao}
CNPJ: {novaPj.cnpj}
CNPJ Válido? {metodoPj.ValidarCnpj(novaPj.cnpj)}
");

//Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0002-00")}");
