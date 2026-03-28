-- 0. Criando o Banco de Dados (Se ele não existir)
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'InventarioTI')
BEGIN
    CREATE DATABASE InventarioTI;
END
GO

-- 1. Entrar no banco de dados
USE InventarioTI;
GO

-- Limpando tabelas antigas (se existirem) para o novo formato
IF OBJECT_ID('MANUTENCAO', 'U') IS NOT NULL DROP TABLE MANUTENCAO;
IF OBJECT_ID('EQUIPAMENTOS', 'U') IS NOT NULL DROP TABLE EQUIPAMENTOS;
IF OBJECT_ID('FUNCIONARIOS', 'U') IS NOT NULL DROP TABLE FUNCIONARIOS;
IF OBJECT_ID('SETORES', 'U') IS NOT NULL DROP TABLE SETORES;
GO

-- 2. Tabela SETORES
CREATE TABLE SETORES (
    ID_Setor INT PRIMARY KEY IDENTITY(1,1),
    Nome_Setor VARCHAR(50) NOT NULL,
    Localizacao VARCHAR(50) NOT NULL
);
GO

-- 3. Tabela FUNCIONARIOS
CREATE TABLE FUNCIONARIOS (
    ID_Funcionario INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100) NOT NULL,
    Cargo VARCHAR(50) NOT NULL,
    Email VARCHAR(100),
    ID_Setor INT,
    CONSTRAINT FK_Funcionarios_Setores 
    FOREIGN KEY (ID_Setor) 
    REFERENCES SETORES(ID_Setor)
);
GO

-- 4. Tabela EQUIPAMENTOS
CREATE TABLE EQUIPAMENTOS (
    ID_Equipamento INT PRIMARY KEY IDENTITY(1,1),
    Nome_Equipamento VARCHAR(100) NOT NULL,
    Tipo VARCHAR(50) NOT NULL,
    Marca VARCHAR(25) NOT NULL,
    Data_Aquisicao DATE NOT NULL,
    ID_Funcionario INT,
    CONSTRAINT FK_Equipamentos_Funcionarios 
    FOREIGN KEY (ID_Funcionario) 
    REFERENCES FUNCIONARIOS(ID_Funcionario)
);
GO

-- 5. Tabela MANUTENCAO
CREATE TABLE MANUTENCAO (
    Registro_Manutencao INT PRIMARY KEY IDENTITY(1,1),
    ID_Funcionario INT NOT NULL,
    ID_Equipamento INT NOT NULL,
    Data_Manutencao DATE NOT NULL,
    Descricao VARCHAR(250) NOT NULL,

    CONSTRAINT FK_Manutencao_Equipamento 
    FOREIGN KEY (ID_Equipamento) 
    REFERENCES EQUIPAMENTOS(ID_Equipamento),
 
    CONSTRAINT FK_Manutencao_Funcionario
    FOREIGN KEY (ID_Funcionario)
    REFERENCES FUNCIONARIOS(ID_Funcionario)
);
GO

-- Inserindo Dados Falsos de Teste (OPCIONAL, MAS RECOMENDADO!)
INSERT INTO SETORES (Nome_Setor, Localizacao) VALUES 
('Recursos Humanos', 'Andar 1'),
('Suporte TI', 'Andar 2'),
('Diretoria', 'Cobertura');
GO

INSERT INTO FUNCIONARIOS (Nome, Cargo, Email, ID_Setor) VALUES 
('João Silva', 'Analista de RH', 'joao@empresa.com', 1),
('Maria Souza', 'Técnico de Redes', 'maria@empresa.com', 2),
('Carlos Diretor', 'CEO', 'carlos@empresa.com', 3);
GO

INSERT INTO EQUIPAMENTOS (Nome_Equipamento, Tipo, Marca, Data_Aquisicao, ID_Funcionario) VALUES 
('Notebook Latitude', 'Notebook', 'Dell', '2023-01-10', 1),
('Servidor Rack G10', 'Servidor', 'HP', '2022-05-15', 2);
GO

INSERT INTO MANUTENCAO (ID_Funcionario, ID_Equipamento, Data_Manutencao, Descricao) VALUES 
(2, 1, '2023-08-20', 'Troca de pasta térmica e limpeza de cooler.'),
(2, 2, '2023-11-05', 'Substituição de HD defeituoso do servidor.');
GO
