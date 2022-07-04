using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace LinqExercise
{
    class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }

        public Produto(int id, string nomeProduto)
        {
            Id = id;
            NomeProduto = nomeProduto;
        }

        public override string ToString()
        {
            return $"{Id} {NomeProduto}";
        }

    }
}
