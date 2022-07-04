### Exercicio com Linq ###

##### 1 - Criar as seguintes classes seguindo as respectivas estruturas: #####

###### CREATE TABLE CLIENTE
###### (
###### id INTEGER NOT NULL,
###### NOMECLIENTE VARCHAR(100)
###### );

###### CREATE TABLE PRODUTO
###### (
###### id INTEGER NOT NULL,
###### NOMEPRODUTO VARCHAR(100)
###### );

###### CREATE TABLE NOTAFISCAL
###### (
###### id INTEGER NOT NULL,
###### DATAEMISSAO DATETIME,  
###### TIPOFRETE varchar Dica: Tipos de frete possível, C - Cif, F - Fob,
###### idcliente INTEGER,
###### Status varchar     Dica: Status possíveis, A - Ativo, F - Faturado, C - Cancelado
###### );

###### CREATE TABLE ITENSNOTAFISCAL
###### (
###### id INTEGER NOT NULL,
###### idnotafiscal / notafiscalid INTEGER NOT NULL,
###### idproduto / produtoid INTEGER NOT NULL,
###### QUANTIDADE INTEGER NOT NULL,
###### PRECOUNITARIO DECIMAL NOT NULL,
###### );

##### 2 - Alimentar TODOS os objetos das classes criadas acima em estruturas <List>, criar no mínimo 10 objetos de cada classe #####

##### 3 - Usar FLUENT expression para retornar os seguintes resultados: #####

###### 1) QUANTAS NOTAS FISCAIS FORAM FATURADAS
###### 1.2) QUANTAS NOTAS FISCAIS canceladas no dia
###### 2) QUAL É A DATA E HORA DA PRIMEIRA NOTA FISCAL ATIVA
###### 3) QUANTAS UNIDADES DE PRODUTOS FORAM VENDIDAS NAS NOTAS COM TIPO DE FRETE CIF e FORAM faturadas
###### 4) QUAL O VALOR VENDIDO (faturado) COM AS NOTAS COM TIPO DE FRETE FOB
###### 5) QUANTOS Abacaxis FORAM VENDIDOS (faturado)
###### 6) QUAL FOI O LUCRO (faturado) TOTAL DE Abacaxi e Laranja

##### 4 - Usar Query Expression para GERAR UM RELATÓRIO DE PEDIDOS COM O SEGUINTE LAYOUT #####
********** Pedido 99999999 - Emitido em: DD/MM/AAAA - HH/MM/SS - Tipo de Frete: C - Cif ou F - Fob - Situação: ativo / faturado / cancelado **********

Cliente: 999 - AAAAAAAAAAAAAAAAAAAAAAA

--------------- Itens do pedido --------------------

Produto _______________________qtde.__________________valor unit._______total

NOMEPRODUTO_______________9999___________________999_____________999
NOMEPRODUTO_______________9999___________________999_____________999
NOMEPRODUTO_______________9999___________________999_____________999
NOMEPRODUTO_______________9999___________________999_____________999
