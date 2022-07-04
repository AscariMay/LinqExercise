using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExercise
{
   public class Cliente
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }

        public Cliente()
        {
        }

        public Cliente(int id, string nomeCliente)
        {
            Id = id;
            NomeCliente = nomeCliente;
        }

        public override string ToString()
        {
            return  $"{Id} {NomeCliente}";
        }
    }
}
