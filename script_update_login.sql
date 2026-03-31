USE InventarioTI;
GO

-- Criação da tabela de controle de Acesso
IF OBJECT_ID('USUARIOS', 'U') IS NOT NULL DROP TABLE USUARIOS;
GO

CREATE TABLE USUARIOS (
    ID_Usuario INT PRIMARY KEY IDENTITY(1,1),
    Login VARCHAR(50) NOT NULL UNIQUE,
    Senha VARCHAR(255) NOT NULL,
    Perfil VARCHAR(20) NOT NULL, -- Exemplo: 'Admin' (Tem tudo), 'Comum' (Apenas leitura/gestão básica)
    ID_Funcionario INT NOT NULL, -- Vincula o usuário ao cadastro original de Funcionarios na empresa!

    CONSTRAINT FK_Usuarios_Funcionarios 
    FOREIGN KEY (ID_Funcionario) 
    REFERENCES FUNCIONARIOS(ID_Funcionario)
);
GO

-- INSERINDO USUÁRIOS FANTASIA BASEADOS NOS FUNCIONARIOS DO SEU SCRIPT DE TESTE:
-- (Se a tabela de funcionarios estiver vazia, esse script dará erro de Foreign Key. 
--  Mas sabemos que o ID 1, 2 e 3 existem no script do projeto original!)

-- 1. João Silva -> Analista RH (Não deveria registrar consertos de maquinas).
INSERT INTO USUARIOS (Login, Senha, Perfil, ID_Funcionario) VALUES ('joao', '123', 'Comum', 1);

-- 2. Maria Souza -> A Técnica de Redes (A "TI" Suprema - Tudo liberado).
INSERT INTO USUARIOS (Login, Senha, Perfil, ID_Funcionario) VALUES ('admin', 'admin', 'Admin', 2);

-- 3. Carlos Diretor -> O Chefão, colocaremos como Admin tbm.
INSERT INTO USUARIOS (Login, Senha, Perfil, ID_Funcionario) VALUES ('carlos', 'senha', 'Admin', 3);
GO
