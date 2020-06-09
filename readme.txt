###################################### modulo 00  #########################################
#preparação
#Nome: AutomaçãoComercial

#IDE visualstudio2019
#NetFramwor4.7
#DB Sql Serve2014 adavance. ta na raiz de dev do sistema.pass.Mixer sistema user *******sa


#modelo 3 camadas:

1º)-camada de banco de dados:
(Definir Tabelas/Modelagem/Telas)

CRIAR TABELA DE CATEGORIA:
*Banco de Dados:
nome banco de dado: dbcomercio
usuario: sa

*Tabelas de clico de produtos (categoria/apresentacao/):
######################################### criar tabelas ##################################
tabela: categoria
idcategoria int NOnull -chaveprimaria- auto-incremento
nome varchar(50) NOnull
descricao varchar(100) null
-------------------------------------------------------------
tabela: apresentacao
idapresentacao int Nonull -cp- auto-incremento
nome varchar(50) Nonull
descricao  varchar(100) null
-------------------------------------------------------------
tabela: produtos
idproduto int Nonull -cp- auto-incremento
codigo varchar(50) Nonull
nome varchar(50) Nonull
descricao varchar(500) null
imagem image null
idcategoria int Nonull
idapresentacao int Nonull
------------------------------------------------------------
tabela: fornecedor
idfornecedor int -cp- -ai- NOnull
idempresa varchar(50) Nonull
setor_comercial varchar(50) NOnull
tipo_documento varcha(50) Nonull
num_documento varchar(50) Nonull
endereco varchar (150) NOnull
telefone varchar (50) Nonull
email varchar (50) null
url varchar(50) null
------------------------------------------------------------
tabela: login
vou usar tabela de funcionário
------------------------------------------------------------
tabela: funcionario
idfuncionario int -cp- -ac- Nonull
nome varchar(50) Nonull
sobrenome varchar(50) Noll
sexo varchar(1) Nonull
data_nascimento	date Nonull
num_documento varchar(50) Nonull
endereco varchar(50) Nonull
telefone varchar(50) Nonull
email varchar(50) null
acesso varchar(50) Nonull
usuario Varchar (50) Nonull
senha varchar(50) Nonull
-------------------------------------------------------------
tabela : entrada (entrada de produtos)
identrada int -cp- -ac- Nonull
idfuncionario int 
idfornecedor int
data date
tipo_comprovante v(50)
serie v(4) 
correlativo v(7) 
imposto decimal(4,2) - caso se tiver muito volume de produto pode aumentar
-------------------------------------------------------------

tabela: descricao
iddetalhe_entrda	int -ap- -ac- Nonull
identrada int	
idproduto int
preco_compra money
preco_venda money
estoque_atual int	
data_producao	date null
date_vencimento date
------------------------------------------------------------
tabela: cliente
idcliente int
nome v(50)
sobrenome v(50) null -pode ser vendido por uma empresa por q pode ser null
sexo v(1) null
tipo_documento v(50) null 
num_documento V(50) null
endereco v(150) null
telefone v(50) null
email v(50) null
---------------------------------------------------------

tabela: venda
idvenda int -cp- -ac- Nonull
idcliente int
idfuncionario int
data date
tipo_comprovante	v(50)
serie v(4)
correlativo v(7) null
imposto decimal(4,2) null

---------------------------------------------------------

tabela: detalhe_venda
iddetalhe_venda int -cp- -ac-
idvenda int
iddetalhe_entrada int
quantidade int
preco_venda money
desconto money null
--------------------------------------------------------

############################# Fim criar tabelas ##################################


*********vamos relacionar as tabelas*****************

####################################criar diagramas das tabelas#######################

organizar o diagrama das tabelas:

ligar os ID das tabela, criando as ForKeys:
CATEGORIA C/ PRODUTOS
"ligar o idcategoria de -CATEGORIA- com idcategoria de -PRODUTOS-"
(com isso, a PK 'primary key' da tab categoria tá gerando uma chave estrangera 'FK' com a tab. produtos no campo idcategoria ) - OK confirmar / OK confirmar
(é criada um chave de 1paramuitos - uma categoria para muitos produtos)

APRESENTACAO C/ PRODUTOS
"idcategoria --> idapresentacao"

PRODUTOS C/ DETALHE_ENRTRADA
"idproduto --> idprodutos"

ENTRADA C/ DETALHE_ENTRADA
"identrada --> identrada" ---(aqui vamos alterar o seguinte detalhes: DESINGNER DE BANCO DE DADOS --> ESPECIFICAR 'INSERT' E 'UPDATE', vamos deixar em 'atualizar regra' e 'excluir regra'como cascata, para toda vez q a tabela ENTRADA ou DETELHE_ENTRADA for alterada, automaticamente ELAS se atualizarem por si só.)

FORNECEDOR C/ ENTRADA
"idfornecedor --> idfornecedor"

FUNCIONARIO /C ENTRADA
"idfuncionario --> idfuncionario"

VENDA C/ DETALHE_VENDA
"idvenda --> idvenda"  ---(aqui vamos alterar o seguinte detalhes: DESINGNER DE BANCO DE DADOS --> ESPECIFICAR 'INSERT' E 'UPDATE', vamos deixar em 'atualizar regra' e 'excluir regra'como cascata, para toda vez q a tabela VENDA ou DETELHE_VENDA for alterada, automaticamente ELAS se atualizarem por si só.)


DETALHE_ENTRADA C/ DETALHE_VENDA
"iddetalhe_entrada --> iddetalheentrada"


CLIENTES C/ VENDA
"idcliente --> idcliente"

FUNCIONARIOS C/ VENDA
"idfuncionario --> idfuncionario"

############################################   fim diagrama  ######################################



2º)-camada de apresentacao:
Vamos criar referencia com a CamadaApresentacao com a CamadaNegocio,
-Referencia --> CamadaNegocio

3º)-camada de negocio:
Vamos criar referencia com a camada de negocio com a camada de banco de dados,
-Referencia --> CamadaDados

4º o AutomaComercial:
Vamos criar referencia de AutomaComercial  com a CamadaApresentacao,
-Referencia --> CamadaApresentacao

--
--
--
> O projeto 'AutomaComercial'passa informaçoes pra CamadaApresentacao que vai passar informaçoes para CamadaNegocio q vai passar pra CamadaDados.
> Vamos criar na CamadaDados uma classe chamada 'Conexao' que vai regerenciar o banco de dados, como nome do servidor e o [BD],



#Sistema p/ Comércio:
******************************************************************************


























































>>








