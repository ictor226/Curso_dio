using ExemploExplorando.Models;


Pessoa p1 = new Pessoa(nome: "Porche", sobrenome:"GT3 RS");
Pessoa p2 = new Pessoa(nome:"Ferrari", sobrenome:"458 spyder");

Curso CarrosZicas = new Curso();
CarrosZicas.Nome = "desta lista";
CarrosZicas.Carros = new List<Pessoa>();

CarrosZicas.AdicionarCarro(p1);
CarrosZicas.AdicionarCarro(p2);
CarrosZicas.ListarCarros();


// Pessoa p1 = new Pessoa();

// p1.Nome = "victor";
// p1.Sobrenome = "Huggo";
// p1.Idade = 18;
// p1.Apresentar();
