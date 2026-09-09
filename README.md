# 💼 Plataforma Vagas Tech

Desafio prático focado em Banco de Dados, SQL, Persistência de Dados e integração com C# utilizando ADO.NET.

## Descrição

O projeto **Vagas Tech** foi desenvolvido como desafio final do módulo de **Banco de Dados e Persistência de Dados** da formação de Desenvolvimento Back-End .NET.

A aplicação simula uma plataforma de vagas afirmativas para mulheres na área de tecnologia, permitindo o cadastro de vagas, candidatas e candidaturas, utilizando persistência de dados com SQLite e integração em C# através do ADO.NET.

## Objetivos

- Aplicar conceitos de modelagem de dados.
- Criar e manipular bancos relacionais com SQL.
- Utilizar operações CRUD (Create, Read, Update e Delete).
- Implementar integração entre aplicação C# e banco de dados SQLite.
- Utilizar consultas com relacionamentos através de JOIN.

## Tecnologias Utilizadas

- C#
- .NET 8
- ADO.NET
- SQLite
- DBeaver
- Google Colab

## Estrutura do Banco de Dados

### Tabela VAGAS

| Campo | Tipo |
|---------|---------|
| ID_VAGA | INT (PK) |
| TITULO | VARCHAR(100) |
| EMPRESA | VARCHAR(100) |
| SALARIO | DECIMAL |

### Tabela CANDIDATAS

| Campo | Tipo |
|---------|---------|
| ID_CANDIDATA | INT (PK) |
| NOME | VARCHAR(100) |
| EMAIL | VARCHAR(100) |

### Tabela CANDIDATURAS

| Campo | Tipo |
|---------|---------|
| ID_CANDIDATURA | INT (PK) |
| DATA_ENVIO | DATETIME |
| ID_VAGA | INT (FK) |
| ID_CANDIDATA | INT (FK) |

## Funcionalidades

### Create
- Cadastrar vaga
- Cadastrar candidata
- Enviar candidatura

### Read
- Consultar candidaturas utilizando INNER JOIN

### Update
- Atualizar salário da vaga

### Delete
- Cancelar candidatura

## Fluxo Executado

1. Cadastro de duas vagas:
   - Engenheira de Dados
   - Analista de BI

2. Cadastro da candidata:
   - Mariana Souza

3. Envio de candidaturas para as duas vagas.

4. Consulta das candidaturas cadastradas.

5. Atualização salarial da vaga de Engenheira de Dados.

6. Cancelamento da candidatura da vaga de Analista de BI.

7. Consulta final para validar os dados persistidos.

## 📁 Arquivos do Projeto

### Banco de Dados
- `DDL_Criacao.sql`
- `vagas_tech.db`

### Aplicação C#
- `Program.cs`
- `MetodosCRUD.cs`
- `VagasTechApp.csproj`

### Documentação
- `README.md`
- `VagasTech.ipynb`

## Google Colab

Notebook utilizado para desenvolvimento e execução do projeto:

🔗 https://colab.research.google.com/drive/1WUDQGoGDK4s-iebpGpsslFHtUqoM1yqZ?usp=sharing

## Aprendizados

Durante o desenvolvimento deste projeto foram praticados conceitos de:

- Modelagem de dados
- Relacionamentos entre tabelas
- Chaves primárias e estrangeiras
- SQL DDL e DML
- Persistência de dados
- Integração entre banco de dados e aplicações C#
- Operações CRUD
- Consultas utilizando JOIN

## 👥 Integrantes da Squad Carmen Portinho

* **Aline Shimoi Rodrigues** - [GitHub](https://github.com/AlineShimoi)
* **Daianne Coelho Pinheiro** (Líder da Squad) - [GitHub](https://github.com/daiannec-p)
* **Luana Ferreira Souza** - [GitHub](https://github.com/luanaferreirasouza)
* **Marcia Daniele da Silva Moreira** - [GitHub](https://github.com/Marcia-Moreira)
* **Mariana Lemos** - [GitHub](https://github.com/mariananlemos)

## 🏛️ Instituição e Contexto

* **Comunidade:** WoMakersCode
* **Programa:** Bootcamp Back-End .NET 2026.2
