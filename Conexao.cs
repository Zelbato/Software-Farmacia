using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Software_Farmacia
{
    internal class Conexao
    {
        public static string conexao =
        @"Data Source=(localdb)\MSSQLLocalDB;
        Initial Catalog=FarmaciaBD;
        Integrated Security=True";
    }
}

/*
 
CREATE TABLE [dbo].[Fornecedor] (
    [Id_fornecedor]    INT          IDENTITY (1, 1) NOT NULL,
    [Nome_fornecedor]  VARCHAR (50) NOT NULL,
    [Cpf_fornecedor]   VARCHAR (14) NOT NULL,
    [Senha_fornecedor] VARCHAR (50) NOT NULL,n
    [Email_fornecedor] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_fornecedor] ASC)
);

CREATE TABLE [dbo].[Produto] (
    [Id_produto]         INT          IDENTITY (1, 1) NOT NULL,
    [Nome_produto]       VARCHAR (50) NOT NULL,
    [Descricao_produto]  VARCHAR (50) NOT NULL,
    [Quantidade_produto] INT          NOT NULL,
    [Preco_produto]      FLOAT (53)   NOT NULL,
    [Id_fornecedorFK]    INT          NULL,
    PRIMARY KEY CLUSTERED ([Id_produto] ASC),
    CONSTRAINT [FK_Produto_Fornecedor] FOREIGN KEY ([Id_fornecedorFK]) REFERENCES [dbo].[Fornecedor] ([Id_fornecedor])
);vai

CREATE TABLE [dbo].[Colaborador] (
   [Id_colaborador] INT IDENTITY(1,1) NOT NULL,
    [Cpf_colaborador] VARCHAR(14) NOT NULL,
    [Nome_colaborador] VARCHAR(50) NOT NULL,
    [Cargo_colaborador] VARCHAR(50) NOT NULL,

    [Nivel_acesso] VARCHAR(20)
    DEFAULT 'Funcionario',

    [Email_colaborador] VARCHAR(50) NOT NULL,
    [Senha_colaborador] VARCHAR(50) NOT NULL,
    [Salario_colaborador] FLOAT NOT NULL,

    PRIMARY KEY CLUSTERED ([Id_colaborador] ASC),

    CONSTRAINT CK_NivelAcesso
    CHECK (

        Nivel_acesso IN
        ('Admin', 'Funcionario')
    )

);
*/