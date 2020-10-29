CREATE TABLE [dbo].[cliente] (
    [Codigo]          INT          IDENTITY (1, 1) NOT NULL,
    [Nome]            VARCHAR (80) NOT NULL,
    [Data_Nascimento] DATE         NOT NULL,
    [CPF]             CHAR (14)    NOT NULL,
    CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED ([Codigo] ASC)
);


CREATE TABLE [dbo].[funcionario] (
    [Codigo]        INT          IDENTITY (1, 1) NOT NULL,
    [Nome]          VARCHAR (80) NOT NULL,
    [CPF]           CHAR (14)    NOT NULL,
    [Data_Admissao] DATE         NOT NULL,
    [Matricula]     INT          NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);


CREATE TABLE [dbo].[Servicos] (
    [Codigo_Servico] INT          NOT NULL,
    [Nome_Servico]   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Servicos] PRIMARY KEY CLUSTERED ([Codigo_Servico] ASC)
);


CREATE TABLE [dbo].[Servicos_Contratados] (
    [Codigo]         INT NOT NULL,
    [Codigo_Servico] INT NOT NULL,
    CONSTRAINT [PK_Servicos_Contratados] PRIMARY KEY CLUSTERED ([Codigo] ASC, [Codigo_Servico] ASC),
    CONSTRAINT [FK_Servicos_Contratados_ToTable] FOREIGN KEY ([Codigo]) REFERENCES [dbo].[cliente] ([Codigo]),
    CONSTRAINT [FK_Servicos_Contratados_ToTable_1] FOREIGN KEY ([Codigo_Servico]) REFERENCES [dbo].[Servicos] ([Codigo_Servico])
);

INSERT INTO Servicos (Codigo_Servico, Nome_Servico) VALUES (1, 'Biometria');
INSERT INTO Servicos (Codigo_Servico, Nome_Servico) VALUES (2, 'Análise de Riscos');
INSERT INTO Servicos (Codigo_Servico, Nome_Servico) VALUES (3, 'Workshop');
INSERT INTO Servicos (Codigo_Servico, Nome_Servico) VALUES (4, 'Serviços de Segurança');