using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using LinqExercise.Enums;
using System.Globalization;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> listaClientes = new List<Cliente>
            {
                new Cliente(1, "Jefté"),
                new Cliente(2, "Bruna"),
                new Cliente(3, "Mayara"),
                new Cliente(4, "Barbara"),
                new Cliente(5, "Enzo"),
                new Cliente(6, "Vinicius"),
                new Cliente(7, "Andre"),
                new Cliente(8, "Gustavo"),
                new Cliente(9, "Natalia"),
                new Cliente(10,"Alisson"),
            };
            List<Produto> listaProdutos = new List<Produto>
            {
                new Produto(1, "Abacaxi"),
                new Produto(2, "Laranja"),
                new Produto(3, "Melao"),
                new Produto(4, "Uva"),
                new Produto(5, "Banana"),
                new Produto(6, "Melancia"),
                new Produto(7, "Abacate"),
                new Produto(8, "Maca"),
                new Produto(9, "Morango"),
                new Produto(10,"Pera"),
            };

            List<NotaFiscal> notaFiscal = new List<NotaFiscal>
            {
                new NotaFiscal(1, listaClientes[0], new DateTime(2022, 05, 10, 22, 10, 00), TipoFreteEnums.Fob, StatusNotaFiscalEnums.Faturado),
                new NotaFiscal(2, listaClientes[1], new DateTime(2022, 09, 11, 12, 10, 03), TipoFreteEnums.Fob, StatusNotaFiscalEnums.Ativo),
                new NotaFiscal(3, listaClientes[2], new DateTime(2022, 07, 05, 10, 22, 05), TipoFreteEnums.Fob, StatusNotaFiscalEnums.Cancelado),
                new NotaFiscal(4, listaClientes[3], new DateTime(2022, 08, 01, 05, 03, 00), TipoFreteEnums.Cif, StatusNotaFiscalEnums.Cancelado),
                new NotaFiscal(5, listaClientes[4], new DateTime(2022, 02, 07, 07, 05, 10), TipoFreteEnums.Fob, StatusNotaFiscalEnums.Faturado),
                new NotaFiscal(6, listaClientes[5], new DateTime(2022, 04, 03, 09, 17, 50), TipoFreteEnums.Cif, StatusNotaFiscalEnums.Ativo),
                new NotaFiscal(7, listaClientes[6], new DateTime(2022, 03, 09, 11, 10, 45), TipoFreteEnums.Cif, StatusNotaFiscalEnums.Faturado),
                new NotaFiscal(8, listaClientes[7], new DateTime(2022, 01, 10, 01, 11, 34), TipoFreteEnums.Cif, StatusNotaFiscalEnums.Faturado),
                new NotaFiscal(9, listaClientes[8], new DateTime(2022, 10, 12, 12, 22, 00), TipoFreteEnums.Fob, StatusNotaFiscalEnums.Ativo),
                new NotaFiscal(10,listaClientes[9], new DateTime(2022, 05, 10, 22, 30, 00), TipoFreteEnums.Fob, StatusNotaFiscalEnums.Cancelado)
            };

            List<ItensNotaFiscal> ItensNotaFiscal = new List<ItensNotaFiscal>
            {
                new ItensNotaFiscal() { Id = 1, NotaFiscal = notaFiscal[0], Produto = listaProdutos[0], Quantidade = 2, PrecoUnitario = 5.50M },
                new ItensNotaFiscal() { Id = 2, NotaFiscal = notaFiscal[0], Produto = listaProdutos[0], Quantidade = 1, PrecoUnitario = 2.00M },
                new ItensNotaFiscal() { Id = 3, NotaFiscal = notaFiscal[2], Produto = listaProdutos[2], Quantidade = 3, PrecoUnitario = 7.70M },
                new ItensNotaFiscal() { Id = 4, NotaFiscal = notaFiscal[4], Produto = listaProdutos[3], Quantidade = 2, PrecoUnitario = 6.20M },
                new ItensNotaFiscal() { Id = 5, NotaFiscal = notaFiscal[5], Produto = listaProdutos[4], Quantidade = 7, PrecoUnitario = 1.50M },
                new ItensNotaFiscal() { Id = 6, NotaFiscal = notaFiscal[0], Produto = listaProdutos[0], Quantidade = 1, PrecoUnitario = 5.00M },
                new ItensNotaFiscal() { Id = 7, NotaFiscal = notaFiscal[6], Produto = listaProdutos[6], Quantidade = 5, PrecoUnitario = 3.40M },
                new ItensNotaFiscal() { Id = 8, NotaFiscal = notaFiscal[7], Produto = listaProdutos[7], Quantidade = 2, PrecoUnitario = 2.20M },
                new ItensNotaFiscal() { Id = 9, NotaFiscal = notaFiscal[8], Produto = listaProdutos[8], Quantidade = 1, PrecoUnitario = 5.30M },
                new ItensNotaFiscal() { Id = 10,NotaFiscal = notaFiscal[9], Produto = listaProdutos[9], Quantidade = 2, PrecoUnitario = 7.00M },
            };

            var notasFaturadas = notaFiscal.Where(n => n.Status == StatusNotaFiscalEnums.Faturado).Count();
            Console.WriteLine($"Total Notas Fiscais Faturadas: {notasFaturadas}");

            var notasCanceladas = notaFiscal.Where(n => n.Status == StatusNotaFiscalEnums.Cancelado).Count();
            Console.WriteLine($"Total Notas Fiscais Canceladas: { notasCanceladas}");

            var dataNotaFiscal = notaFiscal.Where(n => n.Status == StatusNotaFiscalEnums.Ativo).OrderBy(n => n.DataEmissao).FirstOrDefault();
            Console.WriteLine($"Data e hora da primeira NF Ativa: {dataNotaFiscal.DataEmissao}");

            var quantidadeProdutos = notaFiscal.Where(n => n.TipoFrete == TipoFreteEnums.Cif).Count(n => n.Status == StatusNotaFiscalEnums.Faturado);
            Console.WriteLine($"Unidades de produtos vendidos e faturados com a NF tipo CIF: {quantidadeProdutos} ");

            var valorFaturado = ItensNotaFiscal.Where(n => n.NotaFiscal.TipoFrete == TipoFreteEnums.Fob && n.NotaFiscal.Status == StatusNotaFiscalEnums.Faturado).Sum(n => n.TotalNotaFiscal());
            Console.WriteLine($"Total valor faturado com as NF faturadas com o tipo FOB: {valorFaturado:C2} ");

            var quantidadeAbacaxi = ItensNotaFiscal.Where(n => n.Produto.NomeProduto.Contains("Abacaxi") && n.NotaFiscal.Status == StatusNotaFiscalEnums.Faturado).Sum(n => n.Quantidade);
            Console.WriteLine($"Quantidade abacaxi vendido(faturado): {quantidadeAbacaxi}");

            var lucroAbacaxi = ItensNotaFiscal.Where(n => n.Produto.NomeProduto.Contains("Abacaxi") && n.NotaFiscal.Status == StatusNotaFiscalEnums.Faturado).Sum(n => n.TotalNotaFiscal());
            var lucroLaranja = ItensNotaFiscal.Where(n => n.Produto.NomeProduto.Contains("Laranja") && n.NotaFiscal.Status == StatusNotaFiscalEnums.Faturado).Sum(n => n.TotalNotaFiscal());
            Console.WriteLine($"Lucro total de Abacaxi e Laranja: {lucroAbacaxi + lucroLaranja:C2}");
            Console.WriteLine();

            for (int i = 0; i < notaFiscal.Count(); i++)
            {
                Console.WriteLine($"\n********** Pedido {notaFiscal[i].Id} - Emitido em: {notaFiscal[i].DataEmissao} - Tipo de Frete: {notaFiscal[i].TipoFrete} - Situação: {notaFiscal[i].Status} **********");
                Console.WriteLine($"Cliente: {listaClientes[i].Id}  - {listaClientes[i].NomeCliente}");
                Console.WriteLine("--------------- Itens do pedido --------------------");
                Console.WriteLine("Produto".PadRight(15) + "Qtde.".PadRight(15) + "Valor unit.".PadRight(15) + "Total");
                Console.WriteLine($"{listaProdutos[i].NomeProduto,-15}  {ItensNotaFiscal[i].Quantidade,-15} {ItensNotaFiscal[i].PrecoUnitario,-11} {ItensNotaFiscal[i].TotalNotaFiscal().ToString("F2")}");
                Console.WriteLine();
            }

        }
    }
}
