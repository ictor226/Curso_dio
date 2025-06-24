using ExemploExplorando.Models;
using System.Globalization;

// Lê todas as linhas do arquivo texto localizado no diretório 'Arquivos'.
// O método ReadAllLines retorna um array de strings, onde cada string é uma linha do arquivo.
string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// Usamos um laço foreach para percorrer cada linha do array 'linhas'.
foreach (string linha in linhas)
{
    // Exibe no console o conteúdo de cada linha lida do arquivo.
    Console.WriteLine(linha);
}

// Bloco comentado abaixo: exemplo de manipulação de datas com DateTime
// DateTime data = DateTime.Parse("06/06/2025 18:03");
// Console.WriteLine(data);

// Bloco comentado: exemplo de criação de objetos Pessoa e manipulação de uma lista no Curso
// Pessoa p1 = new Pessoa(nome: "Porche", sobrenome:"GT3 RS");
// Pessoa p2 = new Pessoa(nome:"Ferrari", sobrenome:"458 spyder");

// Curso CarrosZicas = new Curso();
// CarrosZicas.Nome = "desta lista";
// CarrosZicas.Carros = new List<Pessoa>();

// Adiciona os objetos Pessoa à lista do curso.
// CarrosZicas.AdicionarCarro(p1);
// CarrosZicas.AdicionarCarro(p2);
// CarrosZicas.ListarCarros();

// Outro exemplo de uso de classe Pessoa com propriedades e método.
// Pessoa p1 = new Pessoa();
// p1.Nome = "victor";
// p1.Sobrenome = "Huggo";
// p1.Idade = 18;
// p1.Apresentar();

// Bloco comentado: exemplos de formatação de valores monetários, porcentagem e números.
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("PT-BR");
// decimal ValorMonetario = 55582.40M;
// Console.WriteLine(ValorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine("R$ "+ValorMonetario);

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// long numero2 = 19998566685;
// Console.WriteLine(numero2.ToString("(##) #####-####"));



