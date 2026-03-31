# 🎓 Guia Master de Apresentação (Defesa do CRUD)

Você tem 8 dias para dominar não apenas as telas, mas o *coração* desse software. Este documento é o seu manual definitivo. Se você ler isso 2 ou 3 vezes, vai dominar sua apresentação e responder qualquer "pegadinha" do seu professor com maestria técnica.

---

## 1. A Arquitetura do Seu Software (O Segredo da Nota Máxima)

A exigência de ouro do professor foi: **"Seguir arquitetura em camadas e separar responsabilidades"**. Nós dividimos seu código em 4 camadas restritas onde **nenhuma atravessa o limite da outra ilegalmente**.

### 🔹 1. Camada de Domínio (`InventarioTI.Domain`)
**A Cama de Pilares Básicos**
- Aqui não tem lógica, tela, nem conexão de banco. É o **esquema puro** dos seus dados.
- **O que tem nela?** Classes simples chamadas de *Entidades* (`Equipamento.cs`, `Funcionario.cs`). Elas só tem propriedades (`Id`, `Nome`).
- Tem também as *Interfaces* (`IEquipamentoRepository.cs`). Interfaces são **"Contratos"** dizendo: *“Olha, não me importa como, mas quem lidar com equipamento na unha precisa saber: Salvar, Editar e Excluir”*.

### 🔹 2. Camada de Infraestrutura (`InventarioTI.Infrastructure`)
**O Operário da Obra**
- Aqui é o **ÚNICO LUGAR DO SISTEMA QUE SABE QUE O SQL SERVER EXISTE**. Se o professor abrir qualquer outra pasta procurando código SQL e não achar, você ganha 10.
- Usamos a biblioteca `System.Data.SqlClient`.
- **O que tem nela?** Classes de Repositório (`EquipamentoRepository.cs`). Quando chamam a função `Adicionar()`, ele monta a string `INSERT INTO dbo.Equipamento`, adiciona as variáveis limpas via `cmd.Parameters.AddWithValue()` (o que prova que você nos **protegeu contra Hacking de Sql Injection**) e manda executar no Banco.

### 🔹 3. Camada de Aplicação (`InventarioTI.Application`)
**O Gerente (A Regra de Negócio)**
- Fica no meio do caminho entre o que o Operário da Obra faz, e o que o Usuário (tela) quer.
- Ela pega regras lógicas. Por exemplo, criamos o arquivo global estático `Sessao.cs` para guardar aquele Usuário que fez Login para sempre na Memória RAM do PC, permitindo rastrear as permissões!
- Os "Services" (`EquipamentoService.cs`) conferem os cálculos matemáticos ou obrigatoriedades de texto antes de pedir pro Infraestrutura salvar algo.

### 🔹 4. Camada Visual / Interface (`InventarioTI.UI`)
**A Vitrine (Onde tudo fica bonito)**
- Essa camada foi banhada inteiramente pelo Framework `Guna.UI2.dll`.
- Ela **não manipula banco**. Quando você digita "Dell Latitude" e clica no botão Verde, a tela simplesmente enfia os textos digitados em um Objeto (`Equipamento `) e despacha pro *Application Gerente* lidar com o resto.

---

## 2. Anatomia de Execução (O Ciclo de Vida do CRUD)
Se o professor te perguntar *"Explica pra mim como funciona quando você Exclui um Equipamento"*, responda esse exato passo a passo:

1. **(UI)** O código do botão de cliques (`btnRemover_Click`) em `UcEquipamentos.cs` primeiro varre a tabela Zebrada `Grid` e descobre qual é o `ID` (número mágico) da linha selecionada.
2. **(UI)** Exibimos uma caixinha `MessageBox` segura perguntando "Tem certeza?". 
3. Se Sim, despachamos a Odem: `_equipService.Remover(meuID)`.
4. **(Application)** O Serviço de Equipamento recebe e passa pra `Infrastructure` cego, pois ele sabe que o ID é válido.
5. **(Infrastructure)** O Nosso Repositório cria a conexão `SqlConnection`, gruda na string "DELETE FROM EQUIPAMENTOS WHERE ID=@Id" e manda o machado final `cmd.ExecuteNonQuery()`.
6. Por fim a interface atualiza o Grid novamente listando tudo do zero `CarregarDados()` mostrando que a linha já não existe!

---

## 3. O Diferencial de Nota (Você vs Os Outros Grupos)

Três coisas no seu projeto explodem a régua dos alunos da sala:

### 🏆 Chaves Estrangeiras Lógicas (Trilha SQL INNER JOIN)
No seu painel de *Sistema de Registros de Manutenção*, a Tabela só devolvia números vazios (`1, 2, 4`). Na infraestrutura usamos um poderoso modelo de `INNER JOIN` para unir a MÁQUINA, ao DONO e ao TÉCNICO para preencher propriedades extras no C# do que apenas ler uma única tabela. 

### 🏆 Login Criptografado (Sombra Segura e Controle RBAC)
Você não tem um sisteminha aberto. Uma janela flutuante baseada no Design ShadowEdge inicia a aplicação validando Perfis. Quem preenche as planilhas do Banco *sempre* carrega nas costas a permissão (Admin vs Comum).

### 🏆 O Trato Guna2 Moderno
Suas tabelas ignoram os blocos datados dos Windows 98. Elas usam Zebras Alternadas nos DataGrid `AlternatingRowsDefaultCellStyle` e as sombras formam a mesma paleta elegante de azuis de Sites da Microsoft (`Color #11223C` e Edge ShadowMode). O aluno que usa Guna por tabela deixa os controles crus por não saber configurar as cores e as listagens.

---

## 4. O "Quiz" Surpresa do Professor

> **Professor:** *"Por que nos projetos as pessoas usam essa pasta 'Domain' cheia de 'Interfaces' vazias (`IEquipamentoRepository`) começando com a letra 'I' sendo que elas não tem código nenhum dentro?"*

**Sua Resposta:** *"As interfaces são **Contratos de Garantia**. Elas obrigam que qualquer programador no futuro, se quiser trocar a nossa infraestrutura de um banco SQL Server para enviar dados na Nuvem do Google ou arquivo de Texto, terá por lei que escrever as funções de 'Salvar, Excluir e Editar' assinadas lá! Como a camada Application se conecta ao contrato, ela jamais quebra nem percebe se eu trocar a forma como gravo os dados no HD!"*

> **Professor:** *"No seu banco de dados, se eu tentar Excluir um Funcionário que tenha 15 equipamentos nas costas dele, o que acontece com a interface?"*

**Sua Resposta:** *"O SQL Sever tentará travar através de erro de Chave Estrangeira (Foreign Key). Esse erro de conflito SqlException vai tentar estourar na Camada Infraestrutura, mas como meu Form está envolto em blocos fechados de `Try/Catch`, o EXE não congela (crash). Ao invés disso, uma gentil caixinha subirá na tela dizendo 'Erro ao tentar deletar' protegendo tudo."*
