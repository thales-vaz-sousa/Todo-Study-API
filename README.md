# 📝 Todo List API (ASP.NET Core)

Esta é uma Web API simples e funcional para gerenciamento de tarefas (To-do list), desenvolvida para demonstrar o uso do **Entity Framework Core** com **SQLite** e o padrão de **Injeção de Dependência** no ASP.NET Core.

---

## 🚀 Tecnologias Utilizadas

- **C# / .NET 8** (ou superior)
    
- **ASP.NET Core Web API**
    
- **Entity Framework Core** (ORM)
    
- **SQLite** (Banco de dados local)
    
- **DBeaver** (Sugestão para visualização do banco)
    

---

## 🏗️ Estrutura do Projeto

O projeto segue uma organização limpa dividida em pastas:

- **`Controllers/`**: Gerencia as rotas e a lógica de recebimento de requisições.
    
- **`Models/`**: Contém a classe `TodoModel` que representa a tarefa no banco de dados.
    
- **`Data/`**: Contém o `AppDbContext`, responsável pela comunicação com o banco de dados via EF Core.
    
- **`Migrations/`**: Histórico de versões do banco de dados (gerado pelo EF).
    

---

## 🛠️ Como rodar o projeto

### 1. Clonar o repositório

Bash

```
git clone https://github.com/seu-usuario/nome-do-repositorio.git
cd nome-do-repositorio
```

### 2. Restaurar dependências e atualizar o banco

Certifique-se de ter o [Entity Framework Tools](https://learn.microsoft.com/pt-br/ef/core/cli/dotnet) instalado e execute:

Bash

```
dotnet restore
dotnet ef database update
```

### 3. Executar a aplicação

Bash

```
dotnet run
```

A API estará disponível por padrão em `http://localhost:5000` ou `https://localhost:5001`.

---

## 🛣️ Endpoints (Rotas)

|Método|Rota|Descrição|
|---|---|---|
|**GET**|`/`|Lista todas as tarefas|
|**GET**|`/{id}`|Busca uma tarefa específica por ID|
|**POST**|`/`|Cria uma nova tarefa|
|**PUT**|`/{id}`|Atualiza o título ou status de uma tarefa|
|**DELETE**|`/{id}`|Remove uma tarefa do banco|

Export to Sheets

### Exemplo de JSON para POST/PUT:

JSON

```
{
  "title": "Estudar ASP.NET Core",
  "done": false
}
```

---

## 💡 Conceitos Aplicados

- **Injeção de Dependência:** O `AppDbContext` é injetado diretamente nos métodos do controller via `[FromServices]`.
    
- **Minimal API com Controllers:** Uso de `MapControllers()` para organizar as rotas.
    
- **SQLite:** Persistência de dados em arquivo local (`app.db`).
    
- **EntityFramework Code First:** O banco de dados é gerado a partir das classes C#.
    

---

### 📝 Licença

Este projeto é para fins de estudo. Sinta-se à vontade para usar e modificar!
