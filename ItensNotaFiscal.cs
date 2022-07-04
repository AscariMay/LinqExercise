using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExercise
{
   class ItensNotaFiscal
    {
        public int Id { get; set; }
        public int IdNotaFiscal { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Total { get; set; }

        public ItensNotaFiscal()
        {
        }

        public ItensNotaFiscal(int id, NotaFiscal notaFiscal, Produto produto, int quantidade, decimal precoUnitario)
        {
            Id = id;
            IdNotaFiscal = notaFiscal.Id;
            NotaFiscal = notaFiscal;
            IdProduto = produto.Id;
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;            
        }

        public decimal TotalNotaFiscal()
        {
            Total = Quantidade * PrecoUnitario;
            return Total;
        }
    }
}
