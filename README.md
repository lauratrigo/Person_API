# 💻 Person API 

Esta é uma API simples desenvolvida com **.NET 9** (entretanto, tem como adapta-la de acordo com a sua versão) e **Entity Framework Core**. A API permite realizar operações **CRUD** (Criar, Ler, Atualizar e Deletar) em um banco de dados **SQLite** que armazena informações sobre pessoas.

# 🛠 Tecnologias Usadas

- **.NET 9**
- **Entity Framework Core**
  - Entity Framework Core Sqlite
  - Entity Framework Core Design
- **SQLite**
- **Swagger**

![.NET 9 Badge](https://img.shields.io/badge/.NET-9.0-blue?logo=.net&logoColor=white)
![Entity Framework Core Badge](https://img.shields.io/badge/Entity_Framework_Core-9.0-blue?logo=entity-framework&logoColor=white)
![Entity Framework Core Sqlite Badge](https://img.shields.io/badge/Entity_Framework_Core_Sqlite-9.0-blue?logo=sqlite&logoColor=white)
![Entity Framework Core Design Badge](https://img.shields.io/badge/Entity_Framework_Core_Design-9.0-blue?logo=visualstudio&logoColor=white)
![SQLite Badge](https://img.shields.io/badge/SQLite-3.49-green?logo=sqlite&logoColor=white)
![Swagger Badge](https://img.shields.io/badge/Swagger-API-orange?logo=swagger&logoColor=white)

## 💡 Objetivo 

O objetivo deste projeto é implementar uma **API RESTful** simples que permite realizar operações **CRUD** (Criar, Ler, Atualizar e Deletar) de **pessoas** em um banco de dados **SQLite**. A API tem como foco a gestão de dados de pessoas, com a capacidade de adicionar, listar, atualizar e excluir registros. Além disso, ela utiliza o **Entity Framework Core** para comunicação com o banco de dados e **Swagger** para facilitar os testes e documentação das rotas.

## 🚀 Funcionalidades 

- **POST /person**: Adiciona uma nova pessoa ao banco de dados.
- **GET /person**: Retorna todas as pessoas armazenadas no banco de dados.
- **PUT /person/{id}**: Atualiza as informações de uma pessoa com base no `id`.
- **DELETE /person/{id}**: Exclui uma pessoa com base no `id`.

## 📋 Pré-Requisitos 

Antes de rodar a aplicação, certifique-se de ter os seguintes itens instalados:

- [Visual Studio Code](https://code.visualstudio.com/)
- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQLite](https://www.sqlite.org/download.html)

## 📦 Como Rodar o Projeto

### Passo 1: Clone o repositório

```bash
git clone https://github.com/lauratrigo/Person_API.git
cd Person_API
```

### Passo 2: Clone o repositório

Certifique-se de ter o .NET SDK instalado. Depois, no diretório do projeto, execute:

```bash
dotnet restore
```

### Passo 3: Migre o banco de dados

Antes de rodar a API pela primeira vez, será necessário aplicar as migrações ao banco de dados:

```bash
dotnet ef database update
```

### Passo 4: Execute o projeto

```bash
dotnet run
```
A API estará disponível em http://localhost:5199

### Passo 5: Teste as rotas

Acesse http://localhost:5199/swagger para explorar e testar as rotas da API através do Swagger.

## 📂 Estrutura do Projeto

```
person/
├── bin/                                     # Arquivos compilados do projeto
├── obj/                                     # Arquivos temporários de build
├── Data/                                    # Contém o contexto do banco de dados
│   └── PersonContext.cs                     # Contexto do banco de dados (SQLite)
├── Migrations/                              # Armazena as migrações do banco de dados
│   ├── 20250209152812_Initial.cs            # Arquivo de migração gerado
│   ├── 20250209152812_Initial.Designer.cs   # Arquivo de migração gerado
│   └── PersonContextModelSnapshot.cs        # Snapshot do contexto do banco de dados
├── Models/                                  # Modelos de dados utilizados na aplicação
│   ├── PersonModel.cs                       # Modelo de dados para a pessoa
│   └── PersonRequest.cs                     # Request para criação de uma pessoa
├── Properties/                              # Configurações de propriedades do projeto
│   └── launchSettings.json                  # Configurações de inicialização do projeto
├── routes/                                  # Contém as rotas da API
│   └── PersonRoute.cs                       # Arquivo com as rotas de pessoa
├── appsettings.Development.json             # Configurações para o ambiente de desenvolvimento
├── appsettings.json                         # Configurações gerais da aplicação
├── Person.csproj                            # Arquivo do projeto .NET
├── Person.http                              # Arquivo para testar rotas (se necessário)
├── Person.sln                               # Arquivo da solução do projeto
├── person.sqlite                            # Banco de dados SQLite
├── Program.cs                               # Configuração inicial da API
└── tempCodeRunnerFile.cs                     # Arquivo temporário criado pelo VSCode
```


## 🤝 Agradecimentos

Este projeto foi criado com base em um vídeo do YouTube, onde pude aprender as práticas de criação de uma API com **.NET**. O objetivo principal foi praticar o uso de **C#** e **SQLite** em uma API RESTful.

Caso deseje contribuir, fique à vontade! Para sugestões e melhorias, você pode fazer um fork do repositório, criar uma branch com suas mudanças e enviar um pull request.

## 📜 Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo LICENSE para mais detalhes.

## 🎥 Créditos

Este projeto foi desenvolvido por Laura Trigo com base no vídeo [API CRUD completa com C# e .NET 8 do Zero](https://www.youtube.com/watch?v=UXMKOgmQ7zI&list=PLdP0_O7ZLFU1ze1Lkg1aE8AilZ-_B2JOG&index=2).
