# Guia de Apresentação — ITAM System (Inventário TI)

> **Leia isso antes da apresentação e você vai tirar 10 garantido.**  
> Este guia está organizado do jeito que o professor vai perguntar.

---

## 1. O que é o Projeto?

**"Professor, desenvolvemos um sistema desktop de Gestão de Patrimônio de TI — chamado de ITAM System — que controla todos os equipamentos de uma empresa, rastreia quem está usando cada máquina, em qual setor/andar ela está, e registra o histórico de manutenções e defeitos."**

O sistema representa um cenário corporativo real, onde uma empresa precisa saber:
- Quais equipamentos (notebooks, monitores, mouses) ela tem
- Quem é o responsável por cada um
- Em que setor da empresa ele está
- Quais manutenções já foram feitas em cada máquina

---

## 2. A Arquitetura em Camadas (A parte mais importante!)

Esta é a parte que o professor mais vai querer ouvir. **Decorar essa explicação é ouro.**

O projeto foi construído com **4 camadas separadas**, cada uma com uma responsabilidade única. Pensa assim:

```
┌──────────────────────────────────────────────────────┐
│  UI (Interface Visual - Windows Forms + Guna2)       │ ← O usuário vê aqui
├──────────────────────────────────────────────────────┤
│  Application (Serviços - Regras de Negócio)          │ ← Cérebro das regras
├──────────────────────────────────────────────────────┤
│  Infrastructure (Repositórios - Acesso ao SQL)       │ ← Fala com o banco
├──────────────────────────────────────────────────────┤
│  Domain (Entidades - Modelos de Dados)               │ ← Estrutura dos dados
└──────────────────────────────────────────────────────┘
         ↑ Fluxo: UI chama Application, Application chama Infrastructure,
           Infrastructure usa as classes do Domain
```

### Explique cada camada assim:

**Domain** — *"É o coração do sistema. Aqui ficam as classes que representam os dados reais"*
- `Equipamento.cs` → representa um equipamento real (tem ID, Nome, Tipo, Marca, Data)
- `Funcionario.cs` → representa uma pessoa da empresa
- `Setor.cs` → representa um setor/andar da empresa
- `Manutencao.cs` → representa um chamado de conserto
- As Interfaces (`IEquipamentoRepository`, etc.) → contratos que dizem "quem implementar essa interface precisa ter esses métodos"

**Infrastructure** — *"É quem sabe falar com o banco de dados. Toda a lógica de SQL fica aqui, nunca na tela"*
- `EquipamentoRepository.cs` → sabe executar `SELECT`, `INSERT`, `UPDATE`, `DELETE` na tabela EQUIPAMENTOS
- `FuncionarioRepository.cs` → mesmo para FUNCIONARIOS
- `ManutencaoRepository.cs` → mesmo para MANUTENCAO
- `DbConnection.cs` → a string de conexão com o SQL Server fica aqui

**Application** — *"É a camada de serviços, onde ficam as regras de negócio"*
- `EquipamentoService.cs` → antes de salvar um equipamento, valida se o nome não está vazio. Também contém a regra que impede um funcionário de ter dois equipamentos do mesmo tipo
- `FuncionarioService.cs` → valida se o nome é obrigatório antes de salvar
- Ela nunca acessa o banco diretamente — ela chama o Repository

**UI** — *"É o que o usuário vê e usa"*
- `Form1.cs` → a janela principal com o menu lateral (Sidebar) em azul escuro
- `UcEquipamentos.cs` → a "sub-tela" de equipamentos (UserControl)
- `UcFuncionarios.cs` → a "sub-tela" de funcionários com busca
- `UcManutencoes.cs` → a "sub-tela" de manutenções com busca

---

## 3. O CRUD — Onde fica cada operação?

**CRUD** = Create, Read, Update, Delete (Criar, Ler, Atualizar, Excluir)

| Operação | Botão na Tela | Método no Service | SQL no Repository |
|----------|--------------|-------------------|-------------------|
| **C**riar | "Cadastrar" | `Adicionar()` | `INSERT INTO` |
| **R**ead | (carrega ao abrir) | `Listar()` | `SELECT ... FROM` |
| **U**pdate | "Atualizar" | `Atualizar()` | `UPDATE ... SET` |
| **D**elete | "Remover" | `Remover()` | `DELETE FROM` |

### Como funciona o fluxo quando o usuário clica em "Cadastrar"?

1. O usuário preenche os campos e clica no botão
2. A **UI** (`UcEquipamentos.cs`) coleta os valores dos campos e monta um objeto `Equipamento`
3. A **UI** chama o `EquipamentoService.Adicionar(equipamento)` da camada **Application**
4. O **Service** valida: "O nome está preenchido? O funcionário já tem esse tipo de equipamento?"
5. Se passou, o **Service** chama o `EquipamentoRepository.Adicionar(equipamento)` da camada **Infrastructure**
6. O **Repository** abre a conexão SQL e executa o `INSERT INTO EQUIPAMENTOS...`
7. O banco salva e retorna o controle para a UI que atualiza a tabela

**A UI nunca toca no banco. O banco nunca conhece a tela. É isso que é separação de responsabilidades.**

---

## 4. O Banco de Dados

**4 tabelas relacionadas entre si:**

```sql
SETORES (ID_Setor, Nome_Setor, Localizacao)
    ↓ (um setor tem vários funcionários)
FUNCIONARIOS (ID_Funcionario, Nome, Cargo, Email, ID_Setor)
    ↓ (um funcionário pode usar vários equipamentos)
EQUIPAMENTOS (ID_Equipamento, Nome_Equipamento, Tipo, Marca, Data_Aquisicao, ID_Funcionario)
    ↓ (um equipamento pode ter vários registros de manutenção)
MANUTENCAO (Registro_Manutencao, ID_Funcionario, ID_Equipamento, Data_Manutencao, Descricao)
```

**FOREIGN KEY** = chave que garante integridade entre tabelas. Ex: você não pode registrar um equipamento para um `ID_Funcionario = 99` se esse funcionário não existir.

---

## 5. Funcionalidades Extras (Impressiona o professor)

- **Busca em tempo real** nas abas de Funcionários e Manutenções — filtra enquanto você digita, sem precisar apertar botão
- **ComboBox dinâmico** — ao cadastrar equipamento, a lista de funcionários é buscada ao vivo do banco
- **Regra de negócio inteligente**: o `EquipamentoService` impede atribuir dois equipamentos do mesmo Tipo para o mesmo funcionário (ex: não pode ter 2 notebooks)
- **"Devolver ao Estoque"**: existe a opção "ESTOQUE" na ComboBox que, quando selecionada, desvincular o equipamento do funcionário (grava NULL no banco)
- **JOIN no SQL**: quando lista equipamentos, o SELECT busca também o nome do funcionário responsável com `LEFT JOIN FUNCIONARIOS`

---

## 6. Guna.UI2 — O que é e por que usamos?

**"Professor, utilizamos a biblioteca Guna.UI2 para modernizar a interface. Ela oferece componentes visuais personalizados como o `Guna2BorderlessForm` (que remove a borda padrão do Windows), `Guna2Button`, `Guna2TextBox` e `Guna2DataGridView` com aparência corporativa."**

A biblioteca foi instalada via **NuGet** (o gerenciador de pacotes do .NET), basta abrir o Package Manager e instalar `Guna.UI2`.

---

## 7. Prováveis Perguntas do Professor e Como Responder

**"O que é uma camada Domain?"**
> "É onde ficam as entidades do sistema — as classes que representam os dados reais como `Equipamento`, `Funcionario`. Ela não depende de nenhuma outra camada, é o núcleo do sistema."

**"Por que usar Interface (como `IEquipamentoRepository`)?"**
> "Para desacoplar as camadas. O Service só conhece a Interface, não conhece a implementação. Se amanhã eu trocar de SQL Server para MySQL, só mudo a Infrastructure, sem tocar no código do Service ou da UI."

**"Onde fica a string de conexão com o banco?"**
> "No arquivo `DbConnection.cs`, dentro da camada Infrastructure. A string de conexão aponta para o servidor SQL Server local, passando o nome do banco `InventarioTI`."

**"O que é CRUD e como está implementado?"**
> "CRUD é o conjunto das 4 operações fundamentais de persistência. No nosso sistema, o C é o botão Cadastrar que chama `INSERT INTO`, o R é a listagem automática com `SELECT`, o U é o botão Atualizar com `UPDATE SET`, e o D é o botão Remover com `DELETE FROM`."

**"Por que o código do SQL não está na tela (Form)?"**
> "Porque separamos as responsabilidades. A tela (UI) só sabe exibir dados e capturar ações do usuário. Quem sabe falar com o banco é a camada Infrastructure. Se colocássemos SQL no Form, qualquer mudança no banco quebraria a tela, e isso é uma má prática de desenvolvimento."

**"O que é um UserControl?"**
> "É uma tela reutilizável dentro do Windows Forms. Criamos `UcEquipamentos`, `UcFuncionarios` e `UcManutencoes` como UserControls separados. O Form principal (o Dashboard) funciona como uma moldura, e quando o usuário clica no menu lateral, a moldura troca qual UserControl está sendo exibido — sem reabrir a janela."

**"Como funciona o JOIN no banco?"**
> "Quando listamos os equipamentos, fazemos um `LEFT JOIN` com a tabela FUNCIONARIOS para trazer o nome do responsável junto. Assim não mostramos um número de ID para o usuário, mas sim o nome da pessoa."

---

## 8. Checklist da Apresentação

- [ ] Abrir o Visual Studio com o projeto carregado
- [ ] Mostrar a estrutura de pastas (4 projetos: Domain, Application, Infrastructure, UI)
- [ ] Executar o sistema (F5)
- [ ] Demonstrar o Cadastro de um novo equipamento (CREATE)
- [ ] Mostrar a lista carregando os dados (READ)
- [ ] Dar duplo clique em um item para editar e salvar (UPDATE)
- [ ] Remover um registro (DELETE)
- [ ] Mostrar a busca em tempo real na aba de Funcionários
- [ ] Mostrar que a regra de tipo duplicado bloqueia
- [ ] Abrir o `EquipamentoRepository.cs` e mostrar os SQLs
- [ ] Abrir o `EquipamentoService.cs` e mostrar a regra de negócio
- [ ] Abrir a entidade `Equipamento.cs` e mostrar os atributos
