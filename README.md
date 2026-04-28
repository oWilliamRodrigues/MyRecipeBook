# My Recipe Book API 🍲

### Descrição Técnica

Esta é uma **API REST** desenvolvida em **.NET** voltada para o gerenciamento de receitas culinárias. O projeto foi estruturado para suportar um fluxo completo de autenticação, operações de CRUD e integrações externas, focando em padrões de mercado para aplicações escaláveis e manutenção de longo prazo.

A API gerencia o ciclo de vida do usuário (cadastro e login) e o armazenamento de dados detalhados de receitas, incluindo metadados como nível de dificuldade, tempo de preparo e persistência de imagens ilustrativas.

### Especificações da Arquitetura

O projeto foi implementado seguindo padrões de design que visam a manutenibilidade e a testabilidade:

* **Domain-Driven Design (DDD):** Divisão clara entre as camadas de Domínio, Aplicação, Infraestrutura e API.
* **SOLID:** Aplicação rigorosa dos princípios de responsabilidade única e inversão de dependência.
* **Injeção de Dependência:** Utilizada nativamente para promover o desacoplamento entre componentes.
* **ORM:** Uso de **Entity Framework Core** para abstração e mapeamento do banco de dados.
* **Migrações:** Gerenciamento de esquema de dados via migrations para evolução controlada do banco.

### Recursos Técnicos (Features)

* **Autenticação:** Sistema de login via **JWT (JSON Web Token)** com suporte a **Refresh Token** e integração com **Google Auth**.
* **Integração com IA:** Consumo da API do **ChatGPT** para processamento de linguagem natural e geração automática de receitas.
* **Mensageria:** Uso de **Azure Service Bus** (Queues) para processamento assíncrono de tarefas (ex: exclusão de contas).
* **Validação de Dados:** Implementação de regras de negócio através do **FluentValidation**.
* **Armazenamento:** Persistência de arquivos de imagem vinculados aos registros de receitas.
* **Banco de Dados:** Compatibilidade configurável para **MySQL** e **SQLServer**.
* **Qualidade e DevOps:** Cobertura de **testes de unidade e integração**, análise estática via **SonarCloud** e automação via pipelines de **CI/CD**.

### Tecnologias Utilizadas

* **.NET (C#)**
* **Entity Framework Core**
* **FluentValidation**
* **AutoMapper**
* **Azure Service Bus**
* **BCrypt** (para hashing de senhas)
* **Swagger (OpenAPI)**

### Configuração e Execução

#### Requisitos
* .NET SDK
* MySQL ou SQL Server
* IDE (Visual Studio 2022 ou VS Code)

#### Setup

Instalação e Setup

1- Clone o repositório (Certifique-se de estar na pasta onde deseja salvar o projeto):

```bash

Clonando o projeto para sua máquina local
git clone https://github.com/oWilliamRodrigues/MyRecipeBook.git

Acessando a pasta do projeto
cd MyRecipeBook
```

2- Configuração de ambiente:

Edite o arquivo appsettings.Development.json com suas credenciais.

```bash

O arquivo deve conter as chaves para:
- ConnectionStrings (MySQL ou SQLServer)
- Settings:Jwt:SigningKey (Chave de segurança do Token)
- Settings:OpenAI:ApiKey (Caso use a integração com ChatGPT)
```

3- Banco de Dados e Execução:

Rode os comandos abaixo para criar as tabelas e subir a API.

```bash

Aplica as migrations ao banco de dados configurado
dotnet ef database update

Compila e inicia a aplicação
dotnet run
```
