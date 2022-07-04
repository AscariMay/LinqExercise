using LinqExercise.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExercise
{
    class NotaFiscal
    {
        public int Id { get; set; }
        public int IdCliente { get; private set; }
        public Cliente Cliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public TipoFreteEnums TipoFrete { get; set; }
        public StatusNotaFiscalEnums Status { get; set; }

        public NotaFiscal()
        {
        }

        public NotaFiscal(int id, Cliente cliente, DateTime dataEmissao, TipoFreteEnums tipoFrete, StatusNotaFiscalEnums status)
        {
            Id = id;
            IdCliente = cliente.Id;
            Cliente = cliente;
            DataEmissao = dataEmissao;
            TipoFrete = tipoFrete;
            Status = status;
        }
    }
}
