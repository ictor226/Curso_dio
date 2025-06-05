using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Carros { get; set; }

        public void AdicionarCarro(Pessoa carro)
        {
            Carros.Add(carro);
        }

        public int ObterQuantidadeDeCarros()
        {
            int quantidade = Carros.Count;
            return quantidade;
        }

        public bool RemoverCarrs(Pessoa carro)
        {
            return Carros.Remove(carro);
        }
        public void ListarCarros()
        {
            Console.WriteLine($"Carros mais zicass que eu quero {Nome}");
            foreach (Pessoa carro in Carros)
            {
                Console.WriteLine(carro.NomeCompleto);
            }
        }
    }
}