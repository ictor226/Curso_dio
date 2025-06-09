using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        // Propriedade que armazena o nome do curso.
        public string Nome { get; set; }

        // Lista de objetos do tipo Pessoa, chamada de Carros aqui por fins ilustrativos.
        public List<Pessoa> Carros { get; set; }

        // Método que adiciona uma Pessoa (carro) à lista Carros.
        public void AdicionarCarro(Pessoa carro)
        {
            Carros.Add(carro);
        }

        // Retorna a quantidade total de elementos (carros) na lista.
        public int ObterQuantidadeDeCarros()
        {
            int quantidade = Carros.Count;
            return quantidade;
        }

        // Remove um carro (Pessoa) da lista, retornando verdadeiro se conseguiu remover.
        public bool RemoverCarrs(Pessoa carro)
        {
            return Carros.Remove(carro);
        }

        // Lista os carros (pessoas) com seu nome completo.
        public void ListarCarros()
        {
            Console.WriteLine($"Carros mais zicass que eu quero {Nome}");

            // Loop para exibir cada carro com índice e nome completo.
            for (int Count = 0; Count < Carros.Count; Count++)
            {
                // Usa interpolação de strings para formatar a saída.
                string texto = $"Nº {Count + 1} - {Carros[Count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}
