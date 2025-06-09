using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        // Construtor padrão (sem parâmetros).
        public Pessoa() { }

        // Construtor que permite inicializar os campos nome e sobrenome diretamente.
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Campo privado que guarda o nome internamente.
        private string _nome;

        // Campo privado que guarda a idade internamente.
        private int _idade;

        // Propriedade Nome com get que converte o nome para letras maiúsculas.
        // O set valida se o valor é vazio e lança exceção se for.
        public string Nome
        {
            get => _nome.ToUpper(); // Exibe sempre em maiúsculas
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("o nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        // Propriedade Sobrenome pública simples.
        public string Sobrenome { get; set; }

        // Propriedade somente leitura que concatena Nome + Sobrenome em maiúsculo.
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        // Propriedade Idade com validação (não aceita idade negativa).
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        // Método que apresenta os dados da pessoa no console.
        public void Apresentar()
        {
            Console.WriteLine($"Nome completo: {NomeCompleto}, Idade: {Idade}");
        }
    }
}
