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
 TABELAS:
 
 
 
CREATE TABLE [dbo].[Fornecedor] (
    [Id_fornecedor]    INT          IDENTITY (1, 1) NOT NULL,
    [Nome_fornecedor]  VARCHAR (50) NOT NULL,
    [Cpf_fornecedor]   VARCHAR (14) NOT NULL,
    [Senha_fornecedor] VARCHAR (50) NOT NULL,
    [Email_fornecedor] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_fornecedor] ASC)
);

CREATE TABLE [dbo].[Produto] (
    [Id_produto]         INT          IDENTITY (1, 1) NOT NULL,
    [Nome_produto]       VARCHAR (50) NOT NULL,
    [Descricao_produto]  VARCHAR (200) NOT NULL,
    [Quantidade_produto] INT          NOT NULL,
    [Preco_produto]      FLOAT (53)   NOT NULL,
    [Id_fornecedorFK]    INT          NULL,
    PRIMARY KEY CLUSTERED ([Id_produto] ASC),
    CONSTRAINT [FK_Produto_Fornecedor] FOREIGN KEY ([Id_fornecedorFK]) REFERENCES [dbo].[Fornecedor] ([Id_fornecedor])
);

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


INSERT INTO Fornecedor 
(Nome_fornecedor, Cpf_fornecedor, Senha_fornecedor, Email_fornecedor)
VALUES
('Saúde Mais Distribuidora', '111.222.333-44', 'forn123', 'contato@saudemais.com'),
('Pharma Supply', '555.666.777-88', 'supply2024', 'vendas@pharmasupply.com'),
('Distribuidora Medic Pharma', '999.000.111-22', 'medicpass', 'suporte@medicpharma.com');

INSERT INTO Produto 
(Nome_produto, Descricao_produto, Quantidade_produto, Preco_produto, Id_fornecedorFK)
VALUES
('Dipirona 500mg', 'Analgésico e antitérmico – caixa com 20 comprimidos', 120, 9.90, 1),
('Paracetamol 750mg', 'Medicamento para febre e dor – caixa com 10 comprimidos', 200, 12.50, 1),
('Ibuprofeno 400mg', 'Anti-inflamatório – caixa com 20 comprimidos', 150, 18.90, 2),
('Xarope de Guaco', 'Expectorante – frasco 150ml', 95, 13.50, 1);


INSERT INTO Colaborador
(Cpf_colaborador, Nome_colaborador, Cargo_colaborador, Nivel_acesso, Email_colaborador, Senha_colaborador, Salario_colaborador)
VALUES
('123.456.789-00', 'Ana Souza', 'Atendente', 'Funcionario', 'ana@farmacia.com', 'ana123', 1800.00),
('987.654.321-00', 'Carlos Mendes', 'Farmacêutico Responsável', 'Funcionario', 'carlos@farmacia.com', 'admin123', 3800.00),
('456.789.123-00', 'Juliana Rocha', 'Caixa', 'Funcionario', 'juliana@farmacia.com', 'juliana321', 1650.00),
('789.123.456-00', 'Calebe', 'Gerente', 'Admin', 'calebe@gmail.com', '12345678', 4200.00);




SELECT * FROM dbo.Colaborador;
SELECT * FROM dbo.Fornecedor;
SELECT * FROM dbo.Produto;





DELETE FROM Produto;
DELETE FROM Fornecedor;
DELETE FROM Colaborador;


DBCC CHECKIDENT ('Fornecedor', RESEED, 0);
DBCC CHECKIDENT ('Colaborador', RESEED, 0);
DBCC CHECKIDENT ('Produto', RESEED, 0);

*/