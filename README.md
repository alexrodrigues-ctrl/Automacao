# Automacao
Sistema de vendas
Liguagem C#
BD: sql server2014
IDE Visual Studio 2019
.NET Framework 4.7.2
3 camadas, usando as procedures p/ BD, usando query, relacionando as tabelas do BD, fazendo tudo procedimento do BD e chamando do C#. 
---
1)Cria um Projeto:
nome: SysComercio
pasta: E:\Sistema
2)Cria as 3 camadas:
no projeto principal dentro da pasta E:\Sistema\SysComercio onde foi criado o 'SysComercio', adiciona as 3 classes que serao as camadas, CamadaApresentacao, CamadaNegocio e CamadaDados.

CamadaApresentacao: onde ira abrir as telas, parte grafica.
CamadaDados: ira fazer a conexao com o BD e comunicar com o sistema c#.
CamadaNegocio: ira fazer a transicao entre as CamadaDados e CamadaApresentacao. 

Vamos começar pela CamadaDados, primeiro vamos preparar o BD (sqlserver2014), ou seja a modelagem.
No BD que vamos definir quais serao as telas que vamos criar, categoria, produtos, clientes, produtos, etc...
Apos intalação do BD... é muito simples busque uns vídeo que irá fazer sem problemas...

partindo do pre suposto que sabemos trabalhar com BD, instalar, criar tabelas, fazer as query, relacionar chave-primaria e chave-estrangera
(se tiver dúvidas posso mostar todos os passos)
Uma vez com BD sqlserver 2014, instalado (vou usar em portugues) 

Criando a estrutura:
Abre o DB SQLServee2014, loga e conecta:
Cria um novo BD, vou chamar de (dbcomercio)
Criar as tabelas(apresentacao/categoria/cliente/detalhe_entrada/detalhe_venda/entrada/fornecedor/funcionario/produtovenda) se precisar de mais criaremos.

Vamos relacionar as tabelas:

-Cria os diagrama das tabelas:
da tabela categoria liga o idcategoria com idcategoria da tabela produto (chave-primaria de idcategoria da tabela categoria com chave-estrangera de idcategoria da tabela produto) o chamado chave de um para muitos. uma categoria pra muitos produtos.
(se tiver dúvidas posso mostar todos os passos)

-da tabela apresentacao idapresentacao liga com o idapresentacao da tabela produtos... segue mesma instrucao de cima.

-da tabela produto idproduto liga com o idproduto da tabela detelhe_entrada... segue mesma instrucao a cima.

-da tabela Entrada identrada com identrada da tabela detalhe_entrada... aqui é um pouco diferente: na tela de chave estrangera, na opcao Especificao de Tabela e Coluna, tem a opcao de ESPERCIFICACAO DE INSERCAO E ATUALIZACAO, coloca os dois campos como: em cascata. (quando tiver uma algum movimento em entrada ira alterar tb em detalhe_entrada )

-da tabela funcionario idfuncionario com idfuncionario da tabela entrada... apenas isso, segue

-idvenda com idvenda: aqui é um pouco diferente: na tela de chave estrangera, na opcao Especificao de Tabela e Coluna, tem a opcao de ESPERCIFICACAO DE INSERCAO E ATUALIZACAO, coloca os dois campos como: em cascata.

idfuncionario com idfunciona (venda)
-iddetalhevenda com iddetalhevenda
-idcliente com idcliente

salva com DiagramaER
- pronto:
